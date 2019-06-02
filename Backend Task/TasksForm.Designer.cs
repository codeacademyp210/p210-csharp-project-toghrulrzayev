namespace Backend_Task
{
    partial class TasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchTasks = new System.Windows.Forms.TextBox();
            this.btnSearchTasks = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGroupTask = new System.Windows.Forms.ComboBox();
            this.btnResetTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.txtNameTask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.IdTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeadlineTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupIdTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearchTasks
            // 
            this.txtSearchTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTasks.Location = new System.Drawing.Point(400, 70);
            this.txtSearchTasks.Name = "txtSearchTasks";
            this.txtSearchTasks.Size = new System.Drawing.Size(223, 26);
            this.txtSearchTasks.TabIndex = 1;
            // 
            // btnSearchTasks
            // 
            this.btnSearchTasks.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTasks.Location = new System.Drawing.Point(644, 65);
            this.btnSearchTasks.Name = "btnSearchTasks";
            this.btnSearchTasks.Size = new System.Drawing.Size(91, 31);
            this.btnSearchTasks.TabIndex = 2;
            this.btnSearchTasks.Text = "Search";
            this.btnSearchTasks.UseVisualStyleBackColor = true;
            this.btnSearchTasks.Click += new System.EventHandler(this.BtnSearchTasks_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.dtpDeadline);
            this.panel1.Controls.Add(this.cmbGroupTask);
            this.panel1.Controls.Add(this.btnResetTask);
            this.panel1.Controls.Add(this.btnDeleteTask);
            this.panel1.Controls.Add(this.btnSaveTask);
            this.panel1.Controls.Add(this.txtNameTask);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 3;
            // 
            // cmbGroupTask
            // 
            this.cmbGroupTask.FormattingEnabled = true;
            this.cmbGroupTask.Location = new System.Drawing.Point(86, 161);
            this.cmbGroupTask.Name = "cmbGroupTask";
            this.cmbGroupTask.Size = new System.Drawing.Size(100, 21);
            this.cmbGroupTask.TabIndex = 11;
            // 
            // btnResetTask
            // 
            this.btnResetTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetTask.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTask.ForeColor = System.Drawing.Color.White;
            this.btnResetTask.Location = new System.Drawing.Point(119, 296);
            this.btnResetTask.Name = "btnResetTask";
            this.btnResetTask.Size = new System.Drawing.Size(67, 32);
            this.btnResetTask.TabIndex = 10;
            this.btnResetTask.Text = "Reset";
            this.btnResetTask.UseVisualStyleBackColor = false;
            this.btnResetTask.Click += new System.EventHandler(this.BtnResetTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTask.Enabled = false;
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTask.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteTask.Location = new System.Drawing.Point(18, 296);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteTask.TabIndex = 9;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.BtnDeleteTask_Click);
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.BackColor = System.Drawing.Color.Green;
            this.btnSaveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTask.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTask.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveTask.Location = new System.Drawing.Point(18, 240);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(168, 38);
            this.btnSaveTask.TabIndex = 8;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.UseVisualStyleBackColor = false;
            this.btnSaveTask.Click += new System.EventHandler(this.BtnSaveTask_Click);
            // 
            // txtNameTask
            // 
            this.txtNameTask.Location = new System.Drawing.Point(86, 58);
            this.txtNameTask.Name = "txtNameTask";
            this.txtNameTask.Size = new System.Drawing.Size(100, 20);
            this.txtNameTask.TabIndex = 4;
            this.txtNameTask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNameTask_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "GroupId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Deadline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTask,
            this.NameTask,
            this.DeadlineTask,
            this.GroupIdTask});
            this.dgvTasks.Location = new System.Drawing.Point(241, 118);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(547, 320);
            this.dgvTasks.TabIndex = 4;
            this.dgvTasks.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTasks_RowHeaderMouseDoubleClick);
            // 
            // IdTask
            // 
            this.IdTask.HeaderText = "Id";
            this.IdTask.Name = "IdTask";
            this.IdTask.ReadOnly = true;
            this.IdTask.Visible = false;
            // 
            // NameTask
            // 
            this.NameTask.HeaderText = "Name";
            this.NameTask.Name = "NameTask";
            this.NameTask.ReadOnly = true;
            // 
            // DeadlineTask
            // 
            this.DeadlineTask.HeaderText = "Deadline";
            this.DeadlineTask.Name = "DeadlineTask";
            this.DeadlineTask.ReadOnly = true;
            // 
            // GroupIdTask
            // 
            this.GroupIdTask.HeaderText = "GroupId";
            this.GroupIdTask.Name = "GroupIdTask";
            this.GroupIdTask.ReadOnly = true;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.CustomFormat = "DD-MM-YYYY";
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeadline.Location = new System.Drawing.Point(86, 108);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(100, 20);
            this.dtpDeadline.TabIndex = 12;
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchTasks);
            this.Controls.Add(this.txtSearchTasks);
            this.Controls.Add(this.label1);
            this.Name = "TasksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TasksForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchTasks;
        private System.Windows.Forms.Button btnSearchTasks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.TextBox txtNameTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeadlineTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupIdTask;
        private System.Windows.Forms.ComboBox cmbGroupTask;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
    }
}