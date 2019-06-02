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
    public partial class StudentsForm : Form
    {

        Student studentGlobal = new Student();
        public StudentsForm()
        {
            InitializeComponent();
            GenerateStudent();
            FillStudent();
        }


        private void TxtNameStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtSurnameStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtPhoneStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtFeeStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }

        }

        private void BtnSaveStudent_Click(object sender, EventArgs e)
        {
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (txtNameStudent.Text == "" || txtSurnameStudent.Text == "" || txtEmailStudent.Text == "" || txtPhoneStudent.Text == "" || txtFeeStudent.Text == "")
            {
                MessageBox.Show("Zehmet olmasa Xanalari bos buraxmayin!");
            }
            else if (!Regex.IsMatch(txtEmailStudent.Text, pattern))
            {
                MessageBox.Show("Email-i Sehv daxil etdiniz.Meselen: ToghrulRr@code.edu.az bu sekilde daxil edin");
            }
            else if (btnDeleteStudent.Enabled)
            {
                if (!UpdateStudent())
                {
                    MessageBox.Show("Telebe yenilənmədi.");
                    return;
                }

                MessageBox.Show("Telebe yeniləndi");
            }
            else
            {
                if (!CreateStudent())
                {
                    MessageBox.Show("Telebe yaradılmadı.");
                    return;
                }

                MessageBox.Show("Telebe yaradıldı");
            }
            GenerateStudent();
            ResetStudentForm();
        }

        private void BtnDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent();
            ResetStudentForm();
        }

        private void BtnResetStudent_Click(object sender, EventArgs e)
        {
            ResetStudentForm();
        }

        private void GenerateStudent()
        {
            dgvStudents.Rows.Clear();

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                db.Groups.ToList();
                List<Student> students = db.Students.Where(g => g.Status == true).ToList();
               
                foreach (var student in students)
                {
                    
                    dgvStudents.Rows.Add(student.Id,
                                         student.Name,
                                         student.Surname,
                                         student.Email,
                                         student.Phone,
                                         student.Fee,
                                         student.Group.Name
                                         );

                    if (!student.Status)
                    {
                        dgvStudents.Rows[dgvStudents.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    }
                }

            }
        }
        private void FillStudent()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                cmbGroupStudent.DataSource = db.Groups.Select(g => g.Name).ToList();
               

            }
        }
        private bool CreateStudent()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {

                Student student = new Student
                {
                    Name = txtNameStudent.Text,
                    Surname = txtSurnameStudent.Text,
                    Email = txtEmailStudent.Text,
                    Phone = txtPhoneStudent.Text,
                    Fee = txtFeeStudent.Text,
                    Status = true


                };

                db.Students.Add(student);

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
        private bool UpdateStudent()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
              

                Student nwstu = db.Students.Where(s => s.Id == studentGlobal.Id).FirstOrDefault();

                nwstu.Name = txtNameStudent.Text;
                nwstu.Surname = txtSurnameStudent.Text;
                nwstu.Email = txtEmailStudent.Text;
                nwstu.Phone = txtPhoneStudent.Text;
                nwstu.Fee = txtFeeStudent.Text;
               

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

        private void DgvStudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int studentId = (int)dgvStudents.Rows[e.RowIndex].Cells[0].Value;

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                studentGlobal = db.Students.Where(s => s.Id == studentId).FirstOrDefault();
                if (studentGlobal != null)
                {
                    txtNameStudent.Text = studentGlobal.Name;
                    txtSurnameStudent.Text = studentGlobal.Surname;
                    txtEmailStudent.Text = studentGlobal.Email;
                    txtPhoneStudent.Text = studentGlobal.Phone;
                    txtFeeStudent.Text = studentGlobal.Fee;
                    cmbGroupStudent.SelectedItem = studentGlobal.GroupId;
                }
            }

            btnSaveStudent.Text = "Update";
            btnDeleteStudent.Enabled = true;

        }

        private void ResetStudentForm()
        {
            txtNameStudent.Clear();
            txtSurnameStudent.Clear();
            txtEmailStudent.Clear();
            txtPhoneStudent.Clear();
            txtFeeStudent.Clear();

            cmbGroupStudent.SelectedIndex = -1;
            

            btnSaveStudent.Text = "Save";
            btnDeleteStudent.Enabled = false;

        }
        private void DeleteStudent()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                for (int i = 0; i < dgvStudents.SelectedRows.Count; i++)
                {
                    int studentId = (int)dgvStudents.SelectedRows[i].Cells[0].Value;
                    Student student = db.Students.FirstOrDefault(u => u.Id == studentId);
                    student.Status = false;
                }
                db.SaveChanges();
            }
            GenerateStudent();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchStudent.Text.Trim();
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.Student> studentList = db.Students.Where(g =>
                  g.Name.ToLower().Contains(searchText) ||
                  g.Surname.ToLower().Contains(searchText) ||
                  g.Email.ToLower().Contains(searchText) ||
                  g.Phone.ToLower().Contains(searchText) ||
                  g.Fee.ToLower().Contains(searchText)).ToList();

                dgvStudents.Rows.Clear();

                foreach (var item in studentList)
                {
                    dgvStudents.Rows.Add(item.Id, item.Name, item.Surname, item.Email, item.Phone, item.Fee);
                }
            }
        }
    }
}
