using Backend_Task.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backend_Task
{
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();
            GenerateTeacher();
        }

        Teacher teacherGlobal = new Teacher();
        private void TxtNameTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }
        private void TxtSpecStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtSurnameTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtPhoneTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa reqem daxil edin:)");
            }
        }

        private void BtnSaveTeacher_Click(object sender, EventArgs e)
        {
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (txtNameTeacher.Text == "" || txtSurnameTeacher.Text == "" || txtSpecStudent.Text == "" || txtEmailTeacher.Text == "" || txtPhoneTeacher.Text == "")
            {
                MessageBox.Show("Zehmet olmasa Xanalari bos buraxmayin!");
            }
            else if (!Regex.IsMatch(txtEmailTeacher.Text, pattern))
            {
                MessageBox.Show("Email-i Sehv daxil etdiniz.Meselen: ToghrulRr@code.edu.az bu sekilde daxil edin");
            }
            else if (btnDeleteTeacher.Enabled)
            {
                if (!UpdateTeacher())
                {
                    MessageBox.Show("Teacher yenilənmədi.");
                    return;
                }

                MessageBox.Show("Teacher yeniləndi");
            }
            else
            {
                if (!CreateTeacher())
                {
                    MessageBox.Show("Teacher yaradılmadı.");
                    return;
                }

                MessageBox.Show("Teacher yaradıldı");
            }
            GenerateTeacher();
            ResetTeacherForm();

        }

        private void BtnDeleteTeacher_Click(object sender, EventArgs e)
        {
            DeleteTeacher();
        }

        private void BtnResetTeacher_Click(object sender, EventArgs e)
        {
            ResetTeacherForm();
        }
        private void GenerateTeacher()
        {
            dgvTeacher.Rows.Clear();

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Teacher> teachers = db.Teachers.Where(g => g.Status == true).ToList();

                foreach (var teacher in teachers)
                {
                    dgvTeacher.Rows.Add(teacher.Id,
                                         teacher.Name,
                                         teacher.Surname,
                                         teacher.Speciality,
                                         teacher.Email,
                                         teacher.Phone);

                    if (!teacher.Status)
                    {
                        dgvTeacher.Rows[dgvTeacher.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    }
                }

            }
        }
        private bool CreateTeacher()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                Teacher teacher = new Teacher
                {
                    Name = txtNameTeacher.Text,
                    Surname = txtSurnameTeacher.Text,
                    Speciality = txtSpecStudent.Text,
                    Email = txtEmailTeacher.Text,
                    Phone = txtPhoneTeacher.Text,
                    Status = true
                };

                db.Teachers.Add(teacher);

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

        private bool UpdateTeacher()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
 
                Teacher newteac = db.Teachers.Where(s => s.Id == teacherGlobal.Id).FirstOrDefault();

                newteac.Name = txtNameTeacher.Text;
                newteac.Surname = txtSurnameTeacher.Text;
                newteac.Speciality = txtSpecStudent.Text;
                newteac.Email = txtEmailTeacher.Text;
                newteac.Phone = txtPhoneTeacher.Text;

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

        private void DgvTeacher_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int teacherId = (int)dgvTeacher.Rows[e.RowIndex].Cells[0].Value;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                teacherGlobal = db.Teachers.Where(s => s.Id == teacherId).FirstOrDefault();
                if (teacherGlobal != null)
                {
                    txtNameTeacher.Text = teacherGlobal.Name;
                    txtSurnameTeacher.Text = teacherGlobal.Surname;
                    txtSpecStudent.Text =teacherGlobal.Speciality;
                    txtEmailTeacher.Text = teacherGlobal.Email;
                    txtPhoneTeacher.Text = teacherGlobal.Phone;

                }
            }

            btnSaveTeacher.Text = "Update";
            btnDeleteTeacher.Enabled = true;

        }
        private void ResetTeacherForm()
        {
            txtNameTeacher.Clear();
            txtSurnameTeacher.Clear();
            txtSpecStudent.Clear();
            txtEmailTeacher.Clear();
            txtPhoneTeacher.Clear();



            btnSaveTeacher.Text = "Save";
            btnDeleteTeacher.Enabled = false;

        }

        private void DeleteTeacher()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                for (int i = 0; i < dgvTeacher.SelectedRows.Count; i++)
                {
                    int teacherId = (int)dgvTeacher.SelectedRows[i].Cells[0].Value;
                    Teacher teacher = db.Teachers.FirstOrDefault(u => u.Id == teacherId);
                    teacher.Status = false;
                }
                db.SaveChanges();
            }
            GenerateTeacher();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchTeacher.Text.Trim();
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.Teacher> teacherList = db.Teachers.Where(t =>
                  t.Name.ToLower().Contains(searchText) ||
                  t.Surname.ToLower().Contains(searchText) ||
                  t.Speciality.ToLower().Contains(searchText) ||
                  t.Email.ToLower().Contains(searchText) ||
                  t.Phone.ToString().ToLower().Contains(searchText)).ToList();

                dgvTeacher.Rows.Clear();

                foreach (var item in teacherList)
                {
                    dgvTeacher.Rows.Add(item.Id, item.Name, item.Surname, item.Speciality, item.Email, item.Phone);
                }
            }
        }

       
    }
}
