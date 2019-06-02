namespace Backend_Task
{
    partial class GroupsForm
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
            this.txtSearchGroup = new System.Windows.Forms.TextBox();
            this.btnSearchGroup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMentor = new System.Windows.Forms.ComboBox();
            this.cmbEducation = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.cmbClassroom = new System.Windows.Forms.ComboBox();
            this.btnResetGroup = new System.Windows.Forms.Button();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnSaveGroup = new System.Windows.Forms.Button();
            this.txtCapacityGroup = new System.Windows.Forms.TextBox();
            this.txtNameGroup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.IdGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassroomIdGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherIdGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MentorIdGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacityGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EducationProgramIdGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Groups";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearchGroup
            // 
            this.txtSearchGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchGroup.Location = new System.Drawing.Point(458, 61);
            this.txtSearchGroup.Name = "txtSearchGroup";
            this.txtSearchGroup.Size = new System.Drawing.Size(249, 29);
            this.txtSearchGroup.TabIndex = 1;
            // 
            // btnSearchGroup
            // 
            this.btnSearchGroup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchGroup.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGroup.Location = new System.Drawing.Point(726, 60);
            this.btnSearchGroup.Name = "btnSearchGroup";
            this.btnSearchGroup.Size = new System.Drawing.Size(89, 30);
            this.btnSearchGroup.TabIndex = 2;
            this.btnSearchGroup.Text = "Search";
            this.btnSearchGroup.UseVisualStyleBackColor = false;
            this.btnSearchGroup.Click += new System.EventHandler(this.BtnSearchGroup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.cmbMentor);
            this.panel1.Controls.Add(this.cmbEducation);
            this.panel1.Controls.Add(this.cmbTeacher);
            this.panel1.Controls.Add(this.cmbClassroom);
            this.panel1.Controls.Add(this.btnResetGroup);
            this.panel1.Controls.Add(this.btnDeleteGroup);
            this.panel1.Controls.Add(this.btnSaveGroup);
            this.panel1.Controls.Add(this.txtCapacityGroup);
            this.panel1.Controls.Add(this.txtNameGroup);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 508);
            this.panel1.TabIndex = 3;
            // 
            // cmbMentor
            // 
            this.cmbMentor.FormattingEnabled = true;
            this.cmbMentor.Location = new System.Drawing.Point(145, 136);
            this.cmbMentor.Name = "cmbMentor";
            this.cmbMentor.Size = new System.Drawing.Size(117, 21);
            this.cmbMentor.TabIndex = 20;
            // 
            // cmbEducation
            // 
            this.cmbEducation.FormattingEnabled = true;
            this.cmbEducation.Location = new System.Drawing.Point(145, 226);
            this.cmbEducation.Name = "cmbEducation";
            this.cmbEducation.Size = new System.Drawing.Size(117, 21);
            this.cmbEducation.TabIndex = 19;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(145, 94);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(117, 21);
            this.cmbTeacher.TabIndex = 18;
            // 
            // cmbClassroom
            // 
            this.cmbClassroom.FormattingEnabled = true;
            this.cmbClassroom.Location = new System.Drawing.Point(145, 50);
            this.cmbClassroom.Name = "cmbClassroom";
            this.cmbClassroom.Size = new System.Drawing.Size(117, 21);
            this.cmbClassroom.TabIndex = 17;
            // 
            // btnResetGroup
            // 
            this.btnResetGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGroup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetGroup.Location = new System.Drawing.Point(154, 361);
            this.btnResetGroup.Name = "btnResetGroup";
            this.btnResetGroup.Size = new System.Drawing.Size(108, 45);
            this.btnResetGroup.TabIndex = 16;
            this.btnResetGroup.Text = "Reset";
            this.btnResetGroup.UseVisualStyleBackColor = false;
            this.btnResetGroup.Click += new System.EventHandler(this.BtnResetGroup_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.BackColor = System.Drawing.Color.Red;
            this.btnDeleteGroup.Enabled = false;
            this.btnDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGroup.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteGroup.Location = new System.Drawing.Point(12, 361);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(116, 45);
            this.btnDeleteGroup.TabIndex = 15;
            this.btnDeleteGroup.Text = "Delete";
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            this.btnDeleteGroup.Click += new System.EventHandler(this.BtnDeleteGroup_Click);
            // 
            // btnSaveGroup
            // 
            this.btnSaveGroup.BackColor = System.Drawing.Color.Green;
            this.btnSaveGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGroup.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveGroup.Location = new System.Drawing.Point(12, 298);
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(250, 46);
            this.btnSaveGroup.TabIndex = 14;
            this.btnSaveGroup.Text = "Save";
            this.btnSaveGroup.UseVisualStyleBackColor = false;
            this.btnSaveGroup.Click += new System.EventHandler(this.BtnSaveGroup_Click);
            // 
            // txtCapacityGroup
            // 
            this.txtCapacityGroup.Location = new System.Drawing.Point(145, 179);
            this.txtCapacityGroup.Name = "txtCapacityGroup";
            this.txtCapacityGroup.Size = new System.Drawing.Size(117, 20);
            this.txtCapacityGroup.TabIndex = 11;
            this.txtCapacityGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCapacityGroup_KeyPress);
            // 
            // txtNameGroup
            // 
            this.txtNameGroup.Location = new System.Drawing.Point(145, 12);
            this.txtNameGroup.Name = "txtNameGroup";
            this.txtNameGroup.Size = new System.Drawing.Size(117, 20);
            this.txtNameGroup.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Education ProgramId\r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "MentorId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "TeacherId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "ClassroomId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // dgvGroup
            // 
            this.dgvGroup.AllowUserToAddRows = false;
            this.dgvGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGroup,
            this.NameGroup,
            this.ClassroomIdGroup,
            this.TeacherIdGroup,
            this.MentorIdGroup,
            this.CapacityGroup,
            this.EducationProgramIdGroup});
            this.dgvGroup.Location = new System.Drawing.Point(271, 114);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.Size = new System.Drawing.Size(588, 382);
            this.dgvGroup.TabIndex = 4;
            this.dgvGroup.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvGroup_RowHeaderMouseDoubleClick);
            // 
            // IdGroup
            // 
            this.IdGroup.HeaderText = "Id";
            this.IdGroup.Name = "IdGroup";
            this.IdGroup.ReadOnly = true;
            this.IdGroup.Visible = false;
            // 
            // NameGroup
            // 
            this.NameGroup.HeaderText = "Name";
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.ReadOnly = true;
            // 
            // ClassroomIdGroup
            // 
            this.ClassroomIdGroup.HeaderText = "ClassroomId";
            this.ClassroomIdGroup.Name = "ClassroomIdGroup";
            this.ClassroomIdGroup.ReadOnly = true;
            // 
            // TeacherIdGroup
            // 
            this.TeacherIdGroup.HeaderText = "TeacherId";
            this.TeacherIdGroup.Name = "TeacherIdGroup";
            this.TeacherIdGroup.ReadOnly = true;
            // 
            // MentorIdGroup
            // 
            this.MentorIdGroup.HeaderText = "MentorId";
            this.MentorIdGroup.Name = "MentorIdGroup";
            this.MentorIdGroup.ReadOnly = true;
            // 
            // CapacityGroup
            // 
            this.CapacityGroup.HeaderText = "Capacity";
            this.CapacityGroup.Name = "CapacityGroup";
            this.CapacityGroup.ReadOnly = true;
            // 
            // EducationProgramIdGroup
            // 
            this.EducationProgramIdGroup.HeaderText = "EducationProgramId";
            this.EducationProgramIdGroup.Name = "EducationProgramIdGroup";
            this.EducationProgramIdGroup.ReadOnly = true;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 508);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchGroup);
            this.Controls.Add(this.txtSearchGroup);
            this.Controls.Add(this.label1);
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GroupsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchGroup;
        private System.Windows.Forms.Button btnSearchGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnSaveGroup;
        private System.Windows.Forms.TextBox txtCapacityGroup;
        private System.Windows.Forms.TextBox txtNameGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.ComboBox cmbMentor;
        private System.Windows.Forms.ComboBox cmbEducation;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.ComboBox cmbClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassroomIdGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherIdGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn MentorIdGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacityGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationProgramIdGroup;
    }
}