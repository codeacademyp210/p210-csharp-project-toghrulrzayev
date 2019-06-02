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
    public partial class EmployeesForm : Form
    {
        Employee empGlobal = new Employee();
        public EmployeesForm()
        {
            InitializeComponent();
            GenerateEmployee();
            FillEmployee();
        }

        private void TxtNameEmploye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtSurnameEmploye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtPhoneEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa reqem daxil edin:)");
            }
        }

        private void TxtMentoEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtSaalaryEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa reqem daxil edin:)");
            }
        }

        private void BtnSaveEmp_Click(object sender, EventArgs e)
        {
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (txtNameEmploye.Text == "" || txtSurnameEmploye.Text == "" || txtEmailEmployee.Text == "" || txtPhoneEmployee.Text == "" || txtSaalaryEmp.Text == "" || txtStartTimeEmp.Text == "")
            {
                MessageBox.Show("Zehmet olmasa Xanalari bos buraxmayin!");
            }
            else if (!Regex.IsMatch(txtEmailEmployee.Text, pattern))
            {
                MessageBox.Show("Email-i Sehv daxil etdiniz.Meselen: ToghrulRr@code.edu.az bu sekilde daxil edin");
            }
            else if (btnDeleteEmp.Enabled)
            {
                if (!UpdateEmployee())
                {
                    MessageBox.Show("Ishci yenilənmədi.");
                    return;
                }

                MessageBox.Show("Ishci yeniləndi");
            }
            else
            {
                if (!CreateEmployee())
                {
                    MessageBox.Show("Ishci yaradılmadı.");
                    return;
                }

                MessageBox.Show("Ishci yaradıldı");
            }
            GenerateEmployee();
            ResetEmployeForm();
        }

        private void BtnDeleteEmp_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
            ResetEmployeForm();
        }

        private void BtnResetEmp_Click(object sender, EventArgs e)
        {
            ResetEmployeForm();
        }

        private void GenerateEmployee()
        {
            dgvEmployee.Rows.Clear();

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Employee> employees = db.Employees.Where(g => g.Status == true).ToList();

                foreach (var employee in employees)
                {
                    dgvEmployee.Rows.Add(employee.Id,
                                         employee.Name,
                                         employee.Surname,
                                         employee.Email,
                                         employee.Phone,
                                         employee.Mentor,
                                         employee.Position.Name,
                                         employee.StartTime,
                                         employee.Salary);

                    if (!employee.Status)
                    {
                        dgvEmployee.Rows[dgvEmployee.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    }
                }

            }
        }
        private void FillEmployee()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                cmbPosition.DataSource = db.Positions.Select(g => g.Name).ToList();
            }
        }
        private bool CreateEmployee()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                int positionId = (db.Positions.Where(g => g.Name == cmbPosition.SelectedItem.ToString()).FirstOrDefault()).Id;

                Employee employee = new Employee
                {
                    Name = txtNameEmploye.Text,
                    Surname = txtSurnameEmploye.Text,
                    Email = txtEmailEmployee.Text,
                    Phone = txtPhoneEmployee.Text,
                    PositionId = positionId,
                    StartTime=Convert.ToDateTime(txtStartTimeEmp.Text),
                    Salary=Convert.ToDouble(txtSaalaryEmp.Text),
                    Status = true
                };

                db.Employees.Add(employee);

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
        private bool UpdateEmployee()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                int positionId = (db.Positions.Where(g => g.Name == cmbPosition.SelectedItem.ToString()).FirstOrDefault()).Id;

                Employee newemp = db.Employees.Where(s => s.Id == empGlobal.Id).FirstOrDefault();

                newemp.Name = txtNameEmploye.Text;
                newemp.Surname = txtSurnameEmploye.Text;
                newemp.Email = txtEmailEmployee.Text;
                newemp.PositionId = positionId;
                newemp.StartTime =Convert.ToDateTime(txtStartTimeEmp.Text);
                newemp.Salary=Convert.ToDouble(txtSaalaryEmp.Text);

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

        private void DgvEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int empId = (int)dgvEmployee.Rows[e.RowIndex].Cells[0].Value;

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                empGlobal = db.Employees.Where(s => s.Id == empId).FirstOrDefault();
                if (empGlobal != null)
                {
                    txtNameEmploye.Text = empGlobal.Name;
                    txtSurnameEmploye.Text = empGlobal.Surname;
                    txtEmailEmployee.Text = empGlobal.Email;
                    txtPhoneEmployee.Text = empGlobal.Phone;
                    cmbPosition.SelectedItem = empGlobal.Position.Name;
                    txtStartTimeEmp.Text = empGlobal.StartTime.ToString();
                    txtSaalaryEmp.Text = empGlobal.Salary.ToString();

                }
            }

            btnSaveEmp.Text = "Update";
            btnDeleteEmp.Enabled = true;

        }
        private void ResetEmployeForm()
        {
            txtNameEmploye.Clear();
            txtSurnameEmploye.Clear();
            txtEmailEmployee.Clear();
            txtPhoneEmployee.Clear();
            txtStartTimeEmp.Clear();
            txtSaalaryEmp.Clear();

            cmbPosition.SelectedIndex = -1;
           

            btnSaveEmp.Text = "Save";
            btnDeleteEmp.Enabled = false;

        }

        private void DeleteEmployee()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                for (int i = 0; i < dgvEmployee.SelectedRows.Count; i++)
                {
                    int empId = (int)dgvEmployee.SelectedRows[i].Cells[0].Value;
                    Employee employee = db.Employees.FirstOrDefault(u => u.Id == empId);
                    employee.Status = false;
                }
                db.SaveChanges();
            }
            GenerateEmployee();

        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchEmploye.Text.Trim();
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.Employee> groupList = db.Employees.Where(g =>
                  g.Name.ToLower().Contains(searchText) ||
                  g.Surname.ToLower().Contains(searchText) ||
                  g.Email.ToLower().Contains(searchText) ||
                  g.Phone.ToLower().Contains(searchText) ||
                  g.Mentor.ToLower().Contains(searchText) ||
                  g.Position.Name.ToLower().Contains(searchText)).ToList();

                dgvEmployee.Rows.Clear();

                foreach (var item in groupList)
                {
                    dgvEmployee.Rows.Add(item.Id, item.Name, item.Surname, item.Email, item.Phone, item.Mentor, item.Position.Name,item.StartTime,item.Salary);
                }
            }
        }
    }
}
