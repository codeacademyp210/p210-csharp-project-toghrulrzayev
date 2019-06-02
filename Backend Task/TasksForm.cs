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
    public partial class TasksForm : Form
    {
        Models.Task taskGlobal = new Models.Task();
        public TasksForm()
        {
            InitializeComponent();
            GenerateTasks();
            FillTasks();
        }

        private void TxtNameTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtDeadlineTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa tarix daxil edin:)");
            }
        }
        private void GenerateTasks()
        {
            dgvTasks.Rows.Clear();

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.Task> tasks = db.Tasks.Where(g => g.Status == true).ToList();

                foreach (var task in tasks)
                {
                    dgvTasks.Rows.Add(task.Id,
                                      task.Name,
                                      task.Deadline,
                                      task.Group.Name
                                         );

                    //if (!task.Status)
                    //{
                    //    dgvTasks.Rows[dgvTasks.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    //}
                    //if (task.Deadline > DateTime.Now.Date)
                    //{
                    //    dgvTasks.Rows[dgvTasks.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    //}
                    //if ((dgvTasks.Rows[2].Cells[2].Value) > DateTime.Today.Day)
                    //{
                    //    dgvTasks.Rows[2].DefaultCellStyle.BackColor = Color.Red;
                    //}
                    
                }
                
                
            }
        }

        private void FillTasks()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                cmbGroupTask.DataSource = db.Groups.Select(g => g.Name).ToList();
            }
        }
        private bool CreateTask()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                int groupId = (db.Groups.Where(g => g.Name == cmbGroupTask.SelectedItem.ToString()).FirstOrDefault()).Id;

                Models.Task task = new Models.Task
                {
                    Name = txtNameTask.Text,
                    Deadline = Convert.ToDateTime(dtpDeadline.Text),
                    GroupId = groupId,
                    Status = true

                };
              
                

                db.Tasks.Add(task);

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

        private bool UpdateTask()
        {
            int affectedRows = 0;
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                int groupId = (db.Groups.Where(g => g.Name == cmbGroupTask.SelectedItem.ToString()).FirstOrDefault()).Id;


                Models.Task newtask = db.Tasks.Where(s => s.Id == taskGlobal.Id).FirstOrDefault();

                newtask.Name = txtNameTask.Text;
                newtask.Deadline = Convert.ToDateTime(dtpDeadline.Text);
               

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

        private void DgvTasks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int taskId = (int)dgvTasks.Rows[e.RowIndex].Cells[0].Value;

            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                taskGlobal = db.Tasks.Where(s => s.Id == taskId).FirstOrDefault();
                if (taskGlobal != null)
                {
                    txtNameTask.Text = taskGlobal.Name;
                    dtpDeadline.Text = taskGlobal.Deadline.ToString();
                    cmbGroupTask.SelectedItem = taskGlobal.Group.Name;
                    

                }
            }

            btnSaveTask.Text = "Update";
            btnDeleteTask.Enabled = true;
        }

        private void ResetTasksForm()
        {
            txtNameTask.Clear();
          

            cmbGroupTask.SelectedIndex = -1;
            

            btnSaveTask.Text = "Save";
            btnDeleteTask.Enabled = false;

        }

        private void BtnResetTask_Click(object sender, EventArgs e)
        {
            ResetTasksForm();
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            DeleteTask();
            ResetTasksForm();
        }
        private void DeleteTask()
        {
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                for (int i = 0; i < dgvTasks.SelectedRows.Count; i++)
                {
                    int taskId = (int)dgvTasks.SelectedRows[i].Cells[0].Value;
                    Models.Task task = db.Tasks.FirstOrDefault(u => u.Id == taskId);
                    task.Status = false;
                }
                db.SaveChanges();
            }
            GenerateTasks();

        }

        private void BtnSearchTasks_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchTasks.Text.Trim();
            using (MyAcademyEntities2 db = new MyAcademyEntities2())
            {
                List<Models.Task> groupList = db.Tasks.Where(g =>
                  g.Name.ToLower().Contains(searchText) ||
                  g.Group.Name.ToLower().Contains(searchText)
                  ).ToList();

                dgvTasks.Rows.Clear();

                foreach (var item in groupList)
                {
                    dgvTasks.Rows.Add(item.Id, item.Name, item.Deadline, item.Group.Name);
                }
            }
        }

        private void BtnSaveTask_Click(object sender, EventArgs e)
        {
            if (txtNameTask.Text == "")
            {
                MessageBox.Show("Zehmet olmasa,Xanalari bos buraxmayin");
            }
            if (btnDeleteTask.Enabled)
            {
                if (!UpdateTask())
                {
                    MessageBox.Show("Task yenilənmədi.");
                    return;
                }

                MessageBox.Show("Task yeniləndi");
            }
            else
            {
                if (!CreateTask())
                {
                    MessageBox.Show("Task yaradılmadı.");
                    return;
                }

                MessageBox.Show("Task    yaradıldı");
            }
            GenerateTasks();
            ResetTasksForm();
        }

    }
}
