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

   
    public partial class ClassroomsForm : Form
    {
        Classroom globalPos = new Classroom();
        public ClassroomsForm()
        {
            InitializeComponent();
            GenerateClassroom();
        }

        private void TxtNameClassroom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void GenerateClassroom()
        {
            dgvClassrooms.Rows.Clear();

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Classroom> classrooms = db.Classrooms.Where(g => g.Status == true).ToList();

                foreach (var classroom in classrooms)
                {
                    dgvClassrooms.Rows.Add(classroom.Id,
                                         classroom.Name
                                         );

                    if (!classroom.Status)
                    {
                        dgvClassrooms.Rows[dgvClassrooms.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    }
                }

            }
        }

        private bool CreateClassroom()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                Classroom classroom = new Classroom
                {
                    Name = txtNameClassroom.Text,
                    Status = true

                };

                db.Classrooms.Add(classroom);

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
        private bool UpdateClassroom()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                Classroom newclassroom = db.Classrooms.Where(s => s.Id == globalPos.Id).FirstOrDefault();

                newclassroom.Name = txtNameClassroom.Text;


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

        private void DgvClassrooms_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ClassroomId = (int)dgvClassrooms.Rows[e.RowIndex].Cells[0].Value;

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                globalPos = db.Classrooms.Where(s => s.Id == ClassroomId).FirstOrDefault();
                if (globalPos != null)
                {
                    txtNameClassroom.Text = globalPos.Name;


                }
            }

            btnSaveClassroom.Text = "Update";
            btnDeleteClassroom.Enabled = true;
        }

        private void ResetClassRoomForm()
        {
            txtNameClassroom.Clear();


            btnSaveClassroom.Text = "Save";
            btnDeleteClassroom.Enabled = false;

        }

        private void BtnResetClassroom_Click(object sender, EventArgs e)
        {
            ResetClassRoomForm();
        }

        private void BtnDeleteClassroom_Click(object sender, EventArgs e)
        {
            DeleteClassRoom();
            ResetClassRoomForm();
        }

        private void DeleteClassRoom()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                for (int i = 0; i < dgvClassrooms.SelectedRows.Count; i++)
                {
                    int clroomId = (int)dgvClassrooms.SelectedRows[i].Cells[0].Value;
                    Classroom classroom = db.Classrooms.FirstOrDefault(u => u.Id == clroomId);
                    classroom.Status = false;
                }
                db.SaveChanges();
            }
            GenerateClassroom();

        }

        private void BtnSearchClassroom_Click(object sender, EventArgs e)
        {
            string searchText = txtNameClassroom.Text.Trim();
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.Classroom> positionList = db.Classrooms.Where(g =>
                  g.Name.ToLower().Contains(searchText)).ToList();

                dgvClassrooms.Rows.Clear();


                foreach (var item in positionList)
                {
                    dgvClassrooms.Rows.Add(item.Id, item.Name);
                }
            }
        }

        private void BtnSaveClassroom_Click(object sender, EventArgs e)
        {
            if (txtNameClassroom.Text == "")
            {
                MessageBox.Show("Zehmet olmasa,Xanalari bos buraxmayin");
            }
            if (btnDeleteClassroom.Enabled)
            {
                if (!UpdateClassroom())
                {
                    MessageBox.Show("Sinif yenilənmədi.");
                    return;
                }

                MessageBox.Show("Sinif yeniləndi");
            }
            else
            {
                if (!CreateClassroom())
                {
                    MessageBox.Show("Sinif yaradılmadı.");
                    return;
                }

                MessageBox.Show("Sinif yaradıldı");
            }
            GenerateClassroom();
            ResetClassRoomForm();
        }
    }
}
