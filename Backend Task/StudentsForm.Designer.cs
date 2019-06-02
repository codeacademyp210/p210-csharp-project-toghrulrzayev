namespace Backend_Task
{
    partial class StudentsForm
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
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbGroupStudent = new System.Windows.Forms.ComboBox();
            this.btnResetStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.txtFeeStudent = new System.Windows.Forms.TextBox();
            this.txtPhoneStudent = new System.Windows.Forms.TextBox();
            this.txtEmailStudent = new System.Windows.Forms.TextBox();
            this.txtSurnameStudent = new System.Windows.Forms.TextBox();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.IdStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupIdStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStudent.Location = new System.Drawing.Point(529, 68);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(219, 29);
            this.txtSearchStudent.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(763, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cmbGroupStudent);
            this.panel1.Controls.Add(this.btnResetStudent);
            this.panel1.Controls.Add(this.btnDeleteStudent);
            this.panel1.Controls.Add(this.btnSaveStudent);
            this.panel1.Controls.Add(this.txtFeeStudent);
            this.panel1.Controls.Add(this.txtPhoneStudent);
            this.panel1.Controls.Add(this.txtEmailStudent);
            this.panel1.Controls.Add(this.txtSurnameStudent);
            this.panel1.Controls.Add(this.txtNameStudent);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 499);
            this.panel1.TabIndex = 3;
            // 
            // cmbGroupStudent
            // 
            this.cmbGroupStudent.FormattingEnabled = true;
            this.cmbGroupStudent.Location = new System.Drawing.Point(80, 268);
            this.cmbGroupStudent.Name = "cmbGroupStudent";
            this.cmbGroupStudent.Size = new System.Drawing.Size(119, 21);
            this.cmbGroupStudent.TabIndex = 19;
            // 
            // btnResetStudent
            // 
            this.btnResetStudent.BackColor = System.Drawing.Color.Maroon;
            this.btnResetStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetStudent.Location = new System.Drawing.Point(113, 416);
            this.btnResetStudent.Name = "btnResetStudent";
            this.btnResetStudent.Size = new System.Drawing.Size(86, 36);
            this.btnResetStudent.TabIndex = 18;
            this.btnResetStudent.Text = "Reset";
            this.btnResetStudent.UseVisualStyleBackColor = false;
            this.btnResetStudent.Click += new System.EventHandler(this.BtnResetStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStudent.Enabled = false;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteStudent.Location = new System.Drawing.Point(15, 416);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(80, 36);
            this.btnDeleteStudent.TabIndex = 17;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.BtnDeleteStudent_Click);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.BackColor = System.Drawing.Color.Green;
            this.btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStudent.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveStudent.Location = new System.Drawing.Point(13, 359);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(186, 38);
            this.btnSaveStudent.TabIndex = 16;
            this.btnSaveStudent.Text = "Save";
            this.btnSaveStudent.UseVisualStyleBackColor = false;
            this.btnSaveStudent.Click += new System.EventHandler(this.BtnSaveStudent_Click);
            // 
            // txtFeeStudent
            // 
            this.txtFeeStudent.Location = new System.Drawing.Point(80, 227);
            this.txtFeeStudent.Name = "txtFeeStudent";
            this.txtFeeStudent.Size = new System.Drawing.Size(119, 20);
            this.txtFeeStudent.TabIndex = 12;
            this.txtFeeStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFeeStudent_KeyPress);
            // 
            // txtPhoneStudent
            // 
            this.txtPhoneStudent.Location = new System.Drawing.Point(80, 189);
            this.txtPhoneStudent.Name = "txtPhoneStudent";
            this.txtPhoneStudent.Size = new System.Drawing.Size(119, 20);
            this.txtPhoneStudent.TabIndex = 11;
            this.txtPhoneStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneStudent_KeyPress);
            // 
            // txtEmailStudent
            // 
            this.txtEmailStudent.Location = new System.Drawing.Point(80, 143);
            this.txtEmailStudent.Name = "txtEmailStudent";
            this.txtEmailStudent.Size = new System.Drawing.Size(119, 20);
            this.txtEmailStudent.TabIndex = 10;
            // 
            // txtSurnameStudent
            // 
            this.txtSurnameStudent.Location = new System.Drawing.Point(80, 101);
            this.txtSurnameStudent.Name = "txtSurnameStudent";
            this.txtSurnameStudent.Size = new System.Drawing.Size(119, 20);
            this.txtSurnameStudent.TabIndex = 9;
            this.txtSurnameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSurnameStudent_KeyPress);
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Location = new System.Drawing.Point(80, 57);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(119, 20);
            this.txtNameStudent.TabIndex = 8;
            this.txtNameStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNameStudent_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdStudent,
            this.NameStudent,
            this.SurnameStudent,
            this.EmailStudent,
            this.PhoneStudent,
            this.FeeStudent,
            this.GroupIdStudent});
            this.dgvStudents.Location = new System.Drawing.Point(229, 116);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(628, 371);
            this.dgvStudents.TabIndex = 4;
            this.dgvStudents.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvStudents_RowHeaderMouseDoubleClick);
            // 
            // IdStudent
            // 
            this.IdStudent.HeaderText = "Id";
            this.IdStudent.Name = "IdStudent";
            this.IdStudent.ReadOnly = true;
            this.IdStudent.Visible = false;
            // 
            // NameStudent
            // 
            this.NameStudent.HeaderText = "Name";
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.ReadOnly = true;
            // 
            // SurnameStudent
            // 
            this.SurnameStudent.HeaderText = "Surname";
            this.SurnameStudent.Name = "SurnameStudent";
            this.SurnameStudent.ReadOnly = true;
            // 
            // EmailStudent
            // 
            this.EmailStudent.HeaderText = "Email";
            this.EmailStudent.Name = "EmailStudent";
            this.EmailStudent.ReadOnly = true;
            // 
            // PhoneStudent
            // 
            this.PhoneStudent.HeaderText = "Phone";
            this.PhoneStudent.Name = "PhoneStudent";
            this.PhoneStudent.ReadOnly = true;
            // 
            // FeeStudent
            // 
            this.FeeStudent.HeaderText = "Fee";
            this.FeeStudent.Name = "FeeStudent";
            this.FeeStudent.ReadOnly = true;
            // 
            // GroupIdStudent
            // 
            this.GroupIdStudent.HeaderText = "GroupId";
            this.GroupIdStudent.Name = "GroupIdStudent";
            this.GroupIdStudent.ReadOnly = true;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 499);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.label1);
            this.Name = "StudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudentsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFeeStudent;
        private System.Windows.Forms.TextBox txtPhoneStudent;
        private System.Windows.Forms.TextBox txtEmailStudent;
        private System.Windows.Forms.TextBox txtSurnameStudent;
        private System.Windows.Forms.TextBox txtNameStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResetStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ComboBox cmbGroupStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupIdStudent;
    }
}