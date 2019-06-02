namespace Backend_Task
{
    partial class EmployeesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.btnResetEmp = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.btnSaveEmp = new System.Windows.Forms.Button();
            this.txtSaalaryEmp = new System.Windows.Forms.TextBox();
            this.txtStartTimeEmp = new System.Windows.Forms.TextBox();
            this.txtPhoneEmployee = new System.Windows.Forms.TextBox();
            this.txtEmailEmployee = new System.Windows.Forms.TextBox();
            this.txtSurnameEmploye = new System.Windows.Forms.TextBox();
            this.txtNameEmploye = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.IdEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MentorEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionIdEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchEmploye = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbPosition);
            this.panel1.Controls.Add(this.btnResetEmp);
            this.panel1.Controls.Add(this.btnDeleteEmp);
            this.panel1.Controls.Add(this.btnSaveEmp);
            this.panel1.Controls.Add(this.txtSaalaryEmp);
            this.panel1.Controls.Add(this.txtStartTimeEmp);
            this.panel1.Controls.Add(this.txtPhoneEmployee);
            this.panel1.Controls.Add(this.txtEmailEmployee);
            this.panel1.Controls.Add(this.txtSurnameEmploye);
            this.panel1.Controls.Add(this.txtNameEmploye);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 502);
            this.panel1.TabIndex = 1;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(90, 183);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(152, 21);
            this.cmbPosition.TabIndex = 21;
            // 
            // btnResetEmp
            // 
            this.btnResetEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetEmp.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetEmp.Location = new System.Drawing.Point(136, 417);
            this.btnResetEmp.Name = "btnResetEmp";
            this.btnResetEmp.Size = new System.Drawing.Size(107, 41);
            this.btnResetEmp.TabIndex = 20;
            this.btnResetEmp.Text = "Reset";
            this.btnResetEmp.UseVisualStyleBackColor = false;
            this.btnResetEmp.Click += new System.EventHandler(this.BtnResetEmp_Click);
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.BackColor = System.Drawing.Color.Red;
            this.btnDeleteEmp.Enabled = false;
            this.btnDeleteEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmp.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteEmp.Location = new System.Drawing.Point(19, 417);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(100, 41);
            this.btnDeleteEmp.TabIndex = 19;
            this.btnDeleteEmp.Text = "Delete";
            this.btnDeleteEmp.UseVisualStyleBackColor = false;
            this.btnDeleteEmp.Click += new System.EventHandler(this.BtnDeleteEmp_Click);
            // 
            // btnSaveEmp
            // 
            this.btnSaveEmp.BackColor = System.Drawing.Color.Green;
            this.btnSaveEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEmp.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveEmp.Location = new System.Drawing.Point(19, 355);
            this.btnSaveEmp.Name = "btnSaveEmp";
            this.btnSaveEmp.Size = new System.Drawing.Size(224, 44);
            this.btnSaveEmp.TabIndex = 18;
            this.btnSaveEmp.Text = "Save";
            this.btnSaveEmp.UseVisualStyleBackColor = false;
            this.btnSaveEmp.Click += new System.EventHandler(this.BtnSaveEmp_Click);
            // 
            // txtSaalaryEmp
            // 
            this.txtSaalaryEmp.Location = new System.Drawing.Point(89, 260);
            this.txtSaalaryEmp.Name = "txtSaalaryEmp";
            this.txtSaalaryEmp.Size = new System.Drawing.Size(153, 20);
            this.txtSaalaryEmp.TabIndex = 16;
            this.txtSaalaryEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaalaryEmp_KeyPress);
            // 
            // txtStartTimeEmp
            // 
            this.txtStartTimeEmp.Location = new System.Drawing.Point(89, 222);
            this.txtStartTimeEmp.Name = "txtStartTimeEmp";
            this.txtStartTimeEmp.Size = new System.Drawing.Size(153, 20);
            this.txtStartTimeEmp.TabIndex = 15;
            // 
            // txtPhoneEmployee
            // 
            this.txtPhoneEmployee.Location = new System.Drawing.Point(90, 142);
            this.txtPhoneEmployee.Name = "txtPhoneEmployee";
            this.txtPhoneEmployee.Size = new System.Drawing.Size(153, 20);
            this.txtPhoneEmployee.TabIndex = 12;
            this.txtPhoneEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneEmployee_KeyPress);
            // 
            // txtEmailEmployee
            // 
            this.txtEmailEmployee.Location = new System.Drawing.Point(90, 103);
            this.txtEmailEmployee.Name = "txtEmailEmployee";
            this.txtEmailEmployee.Size = new System.Drawing.Size(153, 20);
            this.txtEmailEmployee.TabIndex = 11;
            // 
            // txtSurnameEmploye
            // 
            this.txtSurnameEmploye.Location = new System.Drawing.Point(90, 67);
            this.txtSurnameEmploye.Name = "txtSurnameEmploye";
            this.txtSurnameEmploye.Size = new System.Drawing.Size(153, 20);
            this.txtSurnameEmploye.TabIndex = 10;
            this.txtSurnameEmploye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSurnameEmploye_KeyPress);
            // 
            // txtNameEmploye
            // 
            this.txtNameEmploye.Location = new System.Drawing.Point(90, 32);
            this.txtNameEmploye.Name = "txtNameEmploye";
            this.txtNameEmploye.Size = new System.Drawing.Size(153, 20);
            this.txtNameEmploye.TabIndex = 9;
            this.txtNameEmploye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNameEmploye_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Start Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "PositionId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmp,
            this.NameEmp,
            this.SurnameEmp,
            this.EmailEmp,
            this.PhoneEmp,
            this.MentorEmp,
            this.PositionIdEmp,
            this.StartTimeEmp,
            this.SalaryEmp});
            this.dgvEmployee.Location = new System.Drawing.Point(275, 114);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(592, 388);
            this.dgvEmployee.TabIndex = 2;
            this.dgvEmployee.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEmployee_RowHeaderMouseDoubleClick);
            // 
            // IdEmp
            // 
            this.IdEmp.HeaderText = "Id";
            this.IdEmp.Name = "IdEmp";
            this.IdEmp.ReadOnly = true;
            this.IdEmp.Visible = false;
            // 
            // NameEmp
            // 
            this.NameEmp.HeaderText = "Name";
            this.NameEmp.Name = "NameEmp";
            this.NameEmp.ReadOnly = true;
            // 
            // SurnameEmp
            // 
            this.SurnameEmp.HeaderText = "Surname";
            this.SurnameEmp.Name = "SurnameEmp";
            this.SurnameEmp.ReadOnly = true;
            // 
            // EmailEmp
            // 
            this.EmailEmp.HeaderText = "Email";
            this.EmailEmp.Name = "EmailEmp";
            this.EmailEmp.ReadOnly = true;
            // 
            // PhoneEmp
            // 
            this.PhoneEmp.HeaderText = "Phone";
            this.PhoneEmp.Name = "PhoneEmp";
            this.PhoneEmp.ReadOnly = true;
            // 
            // MentorEmp
            // 
            this.MentorEmp.HeaderText = "Mentor";
            this.MentorEmp.Name = "MentorEmp";
            this.MentorEmp.ReadOnly = true;
            // 
            // PositionIdEmp
            // 
            this.PositionIdEmp.HeaderText = "PositionId";
            this.PositionIdEmp.Name = "PositionIdEmp";
            this.PositionIdEmp.ReadOnly = true;
            // 
            // StartTimeEmp
            // 
            this.StartTimeEmp.HeaderText = "StartTime";
            this.StartTimeEmp.Name = "StartTimeEmp";
            this.StartTimeEmp.ReadOnly = true;
            // 
            // SalaryEmp
            // 
            this.SalaryEmp.HeaderText = "Salary";
            this.SalaryEmp.Name = "SalaryEmp";
            this.SalaryEmp.ReadOnly = true;
            // 
            // txtSearchEmploye
            // 
            this.txtSearchEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmploye.Location = new System.Drawing.Point(582, 66);
            this.txtSearchEmploye.Name = "txtSearchEmploye";
            this.txtSearchEmploye.Size = new System.Drawing.Size(189, 26);
            this.txtSearchEmploye.TabIndex = 3;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployee.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(777, 63);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(78, 29);
            this.btnSearchEmployee.TabIndex = 4;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.BtnSearchEmployee_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 502);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.txtSearchEmploye);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetEmp;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Button btnSaveEmp;
        private System.Windows.Forms.TextBox txtSaalaryEmp;
        private System.Windows.Forms.TextBox txtStartTimeEmp;
        private System.Windows.Forms.TextBox txtPhoneEmployee;
        private System.Windows.Forms.TextBox txtEmailEmployee;
        private System.Windows.Forms.TextBox txtSurnameEmploye;
        private System.Windows.Forms.TextBox txtNameEmploye;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox txtSearchEmploye;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MentorEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionIdEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryEmp;
        private System.Windows.Forms.ComboBox cmbPosition;
    }
}