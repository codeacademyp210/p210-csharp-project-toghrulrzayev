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
    public partial class PositionsForm : Form
    {
        Position posGlobal = new Position();
        public PositionsForm()
        {
            InitializeComponent();
            GeneratePosition();
        }

        private void TxtNamePosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }
        private void GeneratePosition()
        {
            dgvPosition.Rows.Clear();

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Position> positions = db.Positions.Where(g => g.Status == true).ToList();

                foreach (var position in positions)
                {
                    dgvPosition.Rows.Add(position.Id,
                                         position.Name
                                         );

                    if (!position.Status)
                    {
                        dgvPosition.Rows[dgvPosition.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    }
                }

            }
        }
        private bool CreatePosition()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                Position position = new Position
                {
                    Name = txtNamePosition.Text,
                    Status = true

                };

                db.Positions.Add(position);

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
        private bool UpdatePosition()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                Position newpos = db.Positions.Where(s => s.Id == posGlobal.Id).FirstOrDefault();

                newpos.Name = txtNamePosition.Text;


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

        private void DgvPosition_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int positionId = (int)dgvPosition.Rows[e.RowIndex].Cells[0].Value;

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                posGlobal = db.Positions.Where(s => s.Id == positionId).FirstOrDefault();
                if (posGlobal != null)
                {
                    txtNamePosition.Text = posGlobal.Name;


                }
            }

            btnSavePos.Text = "Update";
            btnDeletePosition.Enabled = true;
        }

        private void ResetPositionForm()
        {
            txtNamePosition.Clear();


            btnSavePos.Text = "Save";
            btnDeletePosition.Enabled = false;

        }

        private void BtnResetPosition_Click(object sender, EventArgs e)
        {
            ResetPositionForm();
        }

        private void BtnDeletePosition_Click(object sender, EventArgs e)
        {
            DeletePosition();
            ResetPositionForm();
        }

        private void DeletePosition()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                for (int i = 0; i < dgvPosition.SelectedRows.Count; i++)
                {
                    int posId = (int)dgvPosition.SelectedRows[i].Cells[0].Value;
                    Position position = db.Positions.FirstOrDefault(u => u.Id == posId);
                    position.Status = false;
                }
                db.SaveChanges();
            }
            GeneratePosition();

        }

        private void BtnSearchPosition_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchPosition.Text.Trim();
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.Position> positionList = db.Positions.Where(g =>
                  g.Name.ToLower().Contains(searchText)).ToList();

                dgvPosition.Rows.Clear();


                foreach (var item in positionList)
                {
                    dgvPosition.Rows.Add(item.Id, item.Name);
                }
            }
        }

        private void BtnSavePos_Click(object sender, EventArgs e)
        {
            if (txtNamePosition.Text == "")
            {
                MessageBox.Show("Zehmet olmasa,Xanalari bos buraxmayin");
            }
            if (btnDeletePosition.Enabled)
            {
                if (!UpdatePosition())
                {
                    MessageBox.Show("Position yenilənmədi.");
                    return;
                }

                MessageBox.Show("Position yeniləndi");
            }
            else
            {
                if (!CreatePosition())
                {
                    MessageBox.Show("Position yaradılmadı.");
                    return;
                }

                MessageBox.Show("Position yaradıldı");
            }
            GeneratePosition();
            ResetPositionForm();
        }
    }
}
