using Backend_Task.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backend_Task
{
    public partial class StudentsMarkForm : Form
    {
     
        StudentsMark studentsMarkGlobal = new StudentsMark();
        public StudentsMarkForm()
        {
            InitializeComponent();
            GenerateTasksMarks();
            FillTasks();
        }

        private void TxtMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa reqem daxil edin:)");
            }
        }
        private void GenerateTasksMarks()
        {
            dgvStudentMarks.Rows.Clear();
           


            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.StudentsMark> studentsMarks = db.StudentsMarks.ToList();
                List<Models.Student> students = db.Students.ToList();
                List<Models.Task> tasks = db.Tasks.ToList();

                foreach (var studentmark in studentsMarks)
                {
                    string sName = "";
                    db.StudentsMarks.FirstOrDefault();
                    Student stu = studentmark.Task.Group.Students.FirstOrDefault(s => s.Id == studentmark.StudentId);
                    if (stu != null)
                    {
                        sName = stu.Name;
                    }
                    dgvStudentMarks.Rows.Add(studentmark.Id,
                                             sName,
                                             studentmark.Task.Name,
                                             studentmark.Mark
                                         );
                }

            }
        }

        private void FillTasks()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                cmbStudent.DataSource = db.Students.Select(g => g.Name).ToList();
                cmbTask.DataSource = db.Tasks.Select(g => g.Name).ToList();


            }
        }
        private bool CreateTaskMarks()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                int studentId = (db.Students.Where(g => g.Name == cmbStudent.SelectedItem.ToString()).FirstOrDefault()).Id;
                int taskId = (db.Tasks.Where(g => g.Name == cmbTask.SelectedItem.ToString()).FirstOrDefault()).Id;

                Models.StudentsMark studentsMark = new Models.StudentsMark
                {
                    StudentId = studentId,
                    TaskId = taskId,
                    Mark =Convert.ToInt32(txtMark.Text),
                  

                };



                db.StudentsMarks.Add(studentsMark);

                affectedRows = db.SaveChanges();

            }
            if (affectedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private bool UpdateStudentMarks()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                int studentId = (db.Students.Where(g => g.Name == cmbStudent.SelectedItem.ToString()).FirstOrDefault()).Id;
                int taskId = (db.Tasks.Where(g => g.Name == cmbTask.SelectedItem.ToString()).FirstOrDefault()).Id;


                Models.Task newtask = db.Tasks.Where(s => s.Id == studentsMarkGlobal.Id).FirstOrDefault();

                studentsMarkGlobal.StudentId = studentId;
                studentsMarkGlobal.TaskId = taskId;
                studentsMarkGlobal.Mark =Convert.ToInt32(txtMark.Text);

                affectedRows = db.SaveChanges();
            }
            if (affectedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void DgvStudentMarks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int taskId = (int)dgvStudentMarks.Rows[e.RowIndex].Cells[0].Value;

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                studentsMarkGlobal = db.StudentsMarks.FirstOrDefault();
                if (studentsMarkGlobal != null)
                {
                    
                    cmbTask.SelectedItem = studentsMarkGlobal.Task.Name;
                    txtMark.Text = studentsMarkGlobal.Mark.ToString();
                }
            }

            btnSaveStudenMark.Text = "Update";
            btnDeleteStudentMark.Enabled = true;
        }

        private void ResetStudentMarkForm()
        {
            txtMark.Clear();
        
            cmbStudent.SelectedIndex = -1;
            cmbTask.SelectedIndex = -1;


            btnSaveStudenMark.Text = "Save";
            btnDeleteStudentMark.Enabled = false;

        }

        private void BtnResetStudentMark_Click(object sender, EventArgs e)
        {
            ResetStudentMarkForm();
        }

        private void BtnDeleteStudentMark_Click(object sender, EventArgs e)
        {
            DeleteStudentsMarks();
            ResetStudentMarkForm();
        }

        private void DeleteStudentsMarks()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                for (int i = 0; i < dgvStudentMarks.SelectedRows.Count; i++)
                {
                    int stdmarkId = (int)dgvStudentMarks.SelectedRows[i].Cells[0].Value;
                    StudentsMark studentsMark = db.StudentsMarks.FirstOrDefault(u => u.Id == stdmarkId);
                }
                db.SaveChanges();
            }
            GenerateTasksMarks();

        }

        private void BtnSearchStudentMarks_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchStudentMark.Text.Trim();
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.StudentsMark> stdMarkList = db.StudentsMarks.Where(g =>
                  g.Task.Name.ToLower().Contains(searchText)).ToList();

                dgvStudentMarks.Rows.Clear();

                foreach (var item in stdMarkList)
                {
                    dgvStudentMarks.Rows.Add(item.Id, item.StudentId, item.Task.Name, item.Mark);
                }
            }
        }

        private void BtnSaveStudenMark_Click(object sender, EventArgs e)
        {
            if (txtMark.Text == "")
            {
                MessageBox.Show("Zehmet olmasa,Xanalari bos buraxmayin");
            }
            if (btnDeleteStudentMark.Enabled)
            {
                if (!UpdateStudentMarks())
                {
                    MessageBox.Show("Telebenin Qiymeti yenilənmədi.");
                    return;
                }

                MessageBox.Show("Telebenin Qiymeti yeniləndi");
            }
            else
            {
                if (!CreateTaskMarks())
                {
                    MessageBox.Show("Telebenin Qiymeti yaradılmadı.");
                    return;
                }

                MessageBox.Show("Telebenin Qiymeti yaradıldı");
            }
            GenerateTasksMarks();
            ResetStudentMarkForm();
        }

        private void BtnGroupFill_Click(object sender, EventArgs e)
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                cmbGroupStudent.DataSource = db.Groups.Select(g => g.Name).ToList();
                cmbGroupStudent.SelectedItem = dgvStudentMarks.SelectedRows;
 
            }
        }
    }
}
