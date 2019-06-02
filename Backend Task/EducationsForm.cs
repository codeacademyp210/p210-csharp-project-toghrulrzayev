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
    public partial class EducationsForm : Form
    {

        Education edGlobal = new Education();
        
        public EducationsForm()
        {
            InitializeComponent();
            GenerateEducation();
        }

        private void TxtNameEducation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtPriceEducation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa reqem daxil edin:)");
            }
        }

        private void GenerateEducation()
        {
            dgvEducation.Rows.Clear();

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Education> educations = db.Educations.Where(g => g.Status == true).ToList();


                foreach (var education in educations)
                {
                    dgvEducation.Rows.Add(education.Id,
                                         education.Name,
                                         education.Price
                                         );
                   
                    if (!education.Status)
                    {
                        dgvEducation.Rows[dgvEducation.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    }
                }

            }
        }
        private bool CreateEducation()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                Education education = new Education
                {
                    Name = txtNameEducation.Text,
                    Price=Convert.ToDouble(txtPriceEducation.Text),
                    Status = true

                };

                db.Educations.Add(education);

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
        private bool UpdateEducation()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                Education newedu = db.Educations.Where(s => s.Id == edGlobal.Id).FirstOrDefault();

                newedu.Name = txtNameEducation.Text;
                newedu.Price = Convert.ToDouble(txtPriceEducation.Text);


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

        private void DgvEducation_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int educationId = (int)dgvEducation.Rows[e.RowIndex].Cells[0].Value;

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                edGlobal = db.Educations.Where(s => s.Id == educationId).FirstOrDefault();
                if (edGlobal != null)
                {
                    txtNameEducation.Text = edGlobal.Name;
                    txtPriceEducation.Text = edGlobal.Price.ToString();


                }
            }

            btnSave.Text = "Update";
            btnDeleteEducation.Enabled = true;
        }

        private void ResetEducationForm()
        {
            txtNameEducation.Clear();
            txtPriceEducation.Clear();


            btnSave.Text = "Save";
            btnDeleteEducation.Enabled = false;

        }

        private void BtnResetEducation_Click(object sender, EventArgs e)
        {
            ResetEducationForm();
        }

        private void BtnDeleteEducation_Click(object sender, EventArgs e)
        {
            DeleteEducation();
            ResetEducationForm();
        }
        private void DeleteEducation()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                for (int i = 0; i < dgvEducation.SelectedRows.Count; i++)
                {
                    int eduId = (int)dgvEducation.SelectedRows[i].Cells[0].Value;
                    Education education = db.Educations.FirstOrDefault(u => u.Id == eduId);
                    education.Status = false;
                }
                db.SaveChanges();
            }
            GenerateEducation();

        }

        private void BtnSearchEducation_Click(object sender, EventArgs e)
        {
            string searchText = txtSeachEducation.Text.Trim();
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.Education> educationList = db.Educations.Where(g =>
                  g.Name.ToLower().Contains(searchText)).ToList();

                dgvEducation.Rows.Clear();


                foreach (var item in educationList)
                {
                    dgvEducation.Rows.Add(item.Id, item.Name,item.Price);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtNameEducation.Text == "" || txtPriceEducation.Text=="")
            {
                MessageBox.Show("Zehmet olmasa,Xanalari bos buraxmayin");
            }
            if (btnDeleteEducation.Enabled)
            {
                if (!UpdateEducation())
                {
                    MessageBox.Show("Educations yenilənmədi.");
                    return;
                }

                MessageBox.Show("Educations yeniləndi");
            }
            else
            {
                if (!CreateEducation())
                {
                    MessageBox.Show("Educations yaradılmadı.");
                    return;
                }

                MessageBox.Show("Educations yaradıldı");
            }
            GenerateEducation();
            ResetEducationForm();
        }
    }
}
