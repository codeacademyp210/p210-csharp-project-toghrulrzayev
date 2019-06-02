namespace Backend_Task
{
    partial class StudentsMarkForm
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
            this.txtSearchStudentMark = new System.Windows.Forms.TextBox();
            this.btnSearchStudentMarks = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.btnResetStudentMark = new System.Windows.Forms.Button();
            this.btnDeleteStudentMark = new System.Windows.Forms.Button();
            this.btnSaveStudenMark = new System.Windows.Forms.Button();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStudentMarks = new System.Windows.Forms.DataGridView();
            this.IdStudentMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskIdMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkStudentsMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGroupStudent = new System.Windows.Forms.ComboBox();
            this.btnGroupFill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students Marks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearchStudentMark
            // 
            this.txtSearchStudentMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStudentMark.Location = new System.Drawing.Point(435, 84);
            this.txtSearchStudentMark.Name = "txtSearchStudentMark";
            this.txtSearchStudentMark.Size = new System.Drawing.Size(267, 31);
            this.txtSearchStudentMark.TabIndex = 1;
            // 
            // btnSearchStudentMarks
            // 
            this.btnSearchStudentMarks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchStudentMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudentMarks.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudentMarks.Location = new System.Drawing.Point(715, 84);
            this.btnSearchStudentMarks.Name = "btnSearchStudentMarks";
            this.btnSearchStudentMarks.Size = new System.Drawing.Size(97, 31);
            this.btnSearchStudentMarks.TabIndex = 2;
            this.btnSearchStudentMarks.Text = "Search";
            this.btnSearchStudentMarks.UseVisualStyleBackColor = false;
            this.btnSearchStudentMarks.Click += new System.EventHandler(this.BtnSearchStudentMarks_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTask);
            this.panel1.Controls.Add(this.cmbStudent);
            this.panel1.Controls.Add(this.btnResetStudentMark);
            this.panel1.Controls.Add(this.btnDeleteStudentMark);
            this.panel1.Controls.Add(this.btnSaveStudenMark);
            this.panel1.Controls.Add(this.txtMark);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(424, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 307);
            this.panel1.TabIndex = 3;
            // 
            // cmbTask
            // 
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Location = new System.Drawing.Point(112, 81);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(191, 21);
            this.cmbTask.TabIndex = 10;
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(112, 29);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(191, 21);
            this.cmbStudent.TabIndex = 9;
            // 
            // btnResetStudentMark
            // 
            this.btnResetStudentMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetStudentMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetStudentMark.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetStudentMark.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetStudentMark.Location = new System.Drawing.Point(197, 249);
            this.btnResetStudentMark.Name = "btnResetStudentMark";
            this.btnResetStudentMark.Size = new System.Drawing.Size(106, 40);
            this.btnResetStudentMark.TabIndex = 8;
            this.btnResetStudentMark.Text = "Reset";
            this.btnResetStudentMark.UseVisualStyleBackColor = false;
            this.btnResetStudentMark.Click += new System.EventHandler(this.BtnResetStudentMark_Click);
            // 
            // btnDeleteStudentMark
            // 
            this.btnDeleteStudentMark.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStudentMark.Enabled = false;
            this.btnDeleteStudentMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudentMark.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudentMark.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteStudentMark.Location = new System.Drawing.Point(38, 249);
            this.btnDeleteStudentMark.Name = "btnDeleteStudentMark";
            this.btnDeleteStudentMark.Size = new System.Drawing.Size(124, 40);
            this.btnDeleteStudentMark.TabIndex = 7;
            this.btnDeleteStudentMark.Text = "Delete";
            this.btnDeleteStudentMark.UseVisualStyleBackColor = false;
            this.btnDeleteStudentMark.Click += new System.EventHandler(this.BtnDeleteStudentMark_Click);
            // 
            // btnSaveStudenMark
            // 
            this.btnSaveStudenMark.BackColor = System.Drawing.Color.Green;
            this.btnSaveStudenMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStudenMark.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStudenMark.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveStudenMark.Location = new System.Drawing.Point(38, 188);
            this.btnSaveStudenMark.Name = "btnSaveStudenMark";
            this.btnSaveStudenMark.Size = new System.Drawing.Size(265, 45);
            this.btnSaveStudenMark.TabIndex = 6;
            this.btnSaveStudenMark.Text = "Save";
            this.btnSaveStudenMark.UseVisualStyleBackColor = false;
            this.btnSaveStudenMark.Click += new System.EventHandler(this.BtnSaveStudenMark_Click);
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(112, 137);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(191, 20);
            this.txtMark.TabIndex = 5;
            this.txtMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMark_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "TaskId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "StudentId";
            // 
            // dgvStudentMarks
            // 
            this.dgvStudentMarks.AllowUserToAddRows = false;
            this.dgvStudentMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdStudentMark,
            this.StudentIdMarks,
            this.TaskIdMark,
            this.MarkStudentsMarks});
            this.dgvStudentMarks.Location = new System.Drawing.Point(1, 140);
            this.dgvStudentMarks.Name = "dgvStudentMarks";
            this.dgvStudentMarks.Size = new System.Drawing.Size(394, 369);
            this.dgvStudentMarks.TabIndex = 4;
            this.dgvStudentMarks.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvStudentMarks_RowHeaderMouseDoubleClick);
            // 
            // IdStudentMark
            // 
            this.IdStudentMark.HeaderText = "Id";
            this.IdStudentMark.Name = "IdStudentMark";
            this.IdStudentMark.ReadOnly = true;
            this.IdStudentMark.Visible = false;
            // 
            // StudentIdMarks
            // 
            this.StudentIdMarks.HeaderText = "StudentId";
            this.StudentIdMarks.Name = "StudentIdMarks";
            this.StudentIdMarks.ReadOnly = true;
            // 
            // TaskIdMark
            // 
            this.TaskIdMark.HeaderText = "TaskId";
            this.TaskIdMark.Name = "TaskIdMark";
            this.TaskIdMark.ReadOnly = true;
            // 
            // MarkStudentsMarks
            // 
            this.MarkStudentsMarks.HeaderText = "Mark";
            this.MarkStudentsMarks.Name = "MarkStudentsMarks";
            this.MarkStudentsMarks.ReadOnly = true;
            // 
            // cmbGroupStudent
            // 
            this.cmbGroupStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupStudent.FormattingEnabled = true;
            this.cmbGroupStudent.Location = new System.Drawing.Point(31, 83);
            this.cmbGroupStudent.Name = "cmbGroupStudent";
            this.cmbGroupStudent.Size = new System.Drawing.Size(210, 28);
            this.cmbGroupStudent.TabIndex = 5;
            // 
            // btnGroupFill
            // 
            this.btnGroupFill.BackColor = System.Drawing.Color.Brown;
            this.btnGroupFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupFill.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupFill.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGroupFill.Location = new System.Drawing.Point(266, 78);
            this.btnGroupFill.Name = "btnGroupFill";
            this.btnGroupFill.Size = new System.Drawing.Size(114, 37);
            this.btnGroupFill.TabIndex = 6;
            this.btnGroupFill.Text = "Fill Groups";
            this.btnGroupFill.UseVisualStyleBackColor = false;
            this.btnGroupFill.Click += new System.EventHandler(this.BtnGroupFill_Click);
            // 
            // StudentsMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 550);
            this.Controls.Add(this.btnGroupFill);
            this.Controls.Add(this.cmbGroupStudent);
            this.Controls.Add(this.dgvStudentMarks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchStudentMarks);
            this.Controls.Add(this.txtSearchStudentMark);
            this.Controls.Add(this.label1);
            this.Name = "StudentsMarkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudentsMarkForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchStudentMark;
        private System.Windows.Forms.Button btnSearchStudentMarks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetStudentMark;
        private System.Windows.Forms.Button btnDeleteStudentMark;
        private System.Windows.Forms.Button btnSaveStudenMark;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStudentMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStudentMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskIdMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkStudentsMarks;
        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbGroupStudent;
        private System.Windows.Forms.Button btnGroupFill;
    }
}