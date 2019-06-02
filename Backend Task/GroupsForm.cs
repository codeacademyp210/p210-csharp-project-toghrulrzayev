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


    public partial class GroupsForm : Form
    {

        Group groupGlobal = new Group();
        public GroupsForm()
        {
            InitializeComponent();
            GenerateGroups();
            FillGroups();

        }


        private void TxtCapacityGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa reqem daxil edin:)");
            }
        }

        private void GenerateGroups()
        {
            dgvGroup.Rows.Clear();

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Group> groups = db.Groups.Where(g=>g.Status==true).ToList();

                foreach (var group in groups)   
                {
                    dgvGroup.Rows.Add(group.Id,
                                         group.Name,
                                         group.Classroom.Name,
                                         group.Teacher.Name+" "+group.Teacher.Surname,
                                         group.Employee.Mentor,
                                         group.Capacity,
                                         group.Education.Name);

                    if (!group.Status)
                    {
                        dgvGroup.Rows[dgvGroup.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    }
                }

            }
        }
        private bool CreateGroup()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                int classroomId = (db.Classrooms.Where(g => g.Name == cmbClassroom.SelectedItem.ToString()).FirstOrDefault()).Id;
                int educationID = (db.Educations.Where(g => g.Name == cmbEducation.SelectedItem.ToString()).FirstOrDefault()).Id;
                int teacherID = (db.Teachers.Where(g => g.Name+" "+g.Surname == cmbTeacher.SelectedItem.ToString()).FirstOrDefault()).Id;
                int mentorID = (db.Employees.Where(g => g.Mentor == cmbMentor.SelectedItem.ToString()).FirstOrDefault()).Id;

                Group group = new Group
                {
                    Name = txtNameGroup.Text,
                    ClassroomId = classroomId,
                    TeacherId = teacherID,
                    MentorId = mentorID,
                    Capacity = Convert.ToInt32(txtCapacityGroup.Text),
                    EducationProgramId = educationID,
                    Status = true

                };

                db.Groups.Add(group);

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

        private bool UpdateGroup()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                int classroomId = (db.Classrooms.Where(g => g.Name == cmbClassroom.SelectedItem.ToString()).FirstOrDefault()).Id;
                int educationID = (db.Educations.Where(g => g.Name == cmbEducation.SelectedItem.ToString()).FirstOrDefault()).Id;
                int teacherID = (db.Teachers.Where(g => g.Name+" "+g.Surname == cmbTeacher.SelectedItem.ToString()).FirstOrDefault()).Id;
                int mentorID = (db.Employees.Where(g => g.Mentor == cmbMentor.SelectedItem.ToString()).FirstOrDefault()).Id;

                Group newgru = db.Groups.Where(s => s.Id == groupGlobal.Id).FirstOrDefault();

                newgru.Name = txtNameGroup.Text;
                newgru.ClassroomId = classroomId;
                newgru.TeacherId = teacherID;
                newgru.MentorId = mentorID;
                newgru.Capacity =Convert.ToInt32(txtCapacityGroup.Text);
                newgru.ClassroomId = classroomId;

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
        private void FillGroups()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                cmbClassroom.DataSource = db.Classrooms.Select(g => g.Name).ToList();
                cmbEducation.DataSource = db.Educations.Select(g => g.Name).ToList();
                cmbMentor.DataSource = db.Employees.Select(e => e.Mentor).ToList();
                cmbTeacher.DataSource = db.Teachers.Select(g => g.Name+" "+g.Surname).ToList();

            }
        }



        private void BtnSaveGroup_Click(object sender, EventArgs e)
        {
            if (txtNameGroup.Text ==""||txtCapacityGroup.Text=="")
            {
                MessageBox.Show("Zehmet olmasa,Xanalari bos buraxmayin");
            }
            if (btnDeleteGroup.Enabled)
            {
                if (!UpdateGroup())
                {
                    MessageBox.Show("Group yenilənmədi.");
                    return;
                }

                MessageBox.Show("Group yeniləndi");
            }
            else
            {
                if (!CreateGroup())
                {
                    MessageBox.Show("Group yaradılmadı.");
                    return;
                }

                MessageBox.Show("Group yaradıldı");
            }
            GenerateGroups();
            ResetGroupForm();

        }

        private void DgvGroup_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int groupId = (int)dgvGroup.Rows[e.RowIndex].Cells[0].Value;

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                groupGlobal = db.Groups.Where(s => s.Id == groupId).FirstOrDefault();
                if (groupGlobal != null)
                {
                    txtNameGroup.Text = groupGlobal.Name;
                    cmbClassroom.SelectedItem = groupGlobal.Classroom.Name;
                    cmbTeacher.SelectedItem = groupGlobal.Teacher.Name+" "+groupGlobal.Teacher.Surname;
                    cmbMentor.SelectedItem = groupGlobal.Employee.Mentor;
                    txtCapacityGroup.Text = groupGlobal.Capacity.ToString();
                    cmbEducation.SelectedItem = groupGlobal.Education.Name;

                }
            }

            btnSaveGroup.Text = "Update";
            btnDeleteGroup.Enabled = true;

        }


        private void ResetGroupForm()
        {
            txtNameGroup.Clear();
            txtCapacityGroup.Clear();

            cmbClassroom.SelectedIndex = -1;
            cmbEducation.SelectedIndex = -1;
            cmbMentor.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;

            btnSaveGroup.Text = "Save";
            btnDeleteGroup.Enabled = false;

        }

        private void BtnResetGroup_Click(object sender, EventArgs e)
        {
            ResetGroupForm();
        }

        private void BtnDeleteGroup_Click(object sender, EventArgs e)
        {
            DeleteGroup();
            ResetGroupForm();
        }

        private void DeleteGroup()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                for (int i = 0; i < dgvGroup.SelectedRows.Count; i++)
                {
                    int groupId = (int)dgvGroup.SelectedRows[i].Cells[0].Value;
                    Group group = db.Groups.FirstOrDefault(u => u.Id == groupId);
                    group.Status = false;
                }
                db.SaveChanges();
            }
            GenerateGroups();

        }


        private void BtnSearchGroup_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchGroup.Text.Trim();
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.Group> groupList = db.Groups.Where(g =>
                  g.Name.ToLower().Contains(searchText) ||
                  g.Classroom.Name.ToLower().Contains(searchText) ||
                  (g.Teacher.Name+g.Teacher.Surname).ToLower().Contains(searchText) ||
                  g.Employee.Mentor.ToLower().Contains(searchText) ||
                  g.Education.Name.ToLower().Contains(searchText)).ToList();

                dgvGroup.Rows.Clear();

                foreach (var item in groupList)
                {
                    dgvGroup.Rows.Add(item.Id, item.Name, item.Classroom.Name, item.Teacher.Name+" "+item.Teacher.Surname, item.Employee.Name, item.Capacity, item.Education.Name);
                }
            }
        }

    }
        
    
}
