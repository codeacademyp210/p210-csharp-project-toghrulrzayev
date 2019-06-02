namespace Backend_Task
{
    partial class TeachersForm
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
            this.txtSearchTeacher = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSpecStudent = new System.Windows.Forms.TextBox();
            this.btnResetTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnSaveTeacher = new System.Windows.Forms.Button();
            this.txtPhoneTeacher = new System.Windows.Forms.TextBox();
            this.txtEmailTeacher = new System.Windows.Forms.TextBox();
            this.txtSurnameTeacher = new System.Windows.Forms.TextBox();
            this.txtNameTeacher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.IdTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialityTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teachers";
            // 
            // txtSearchTeacher
            // 
            this.txtSearchTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTeacher.Location = new System.Drawing.Point(528, 68);
            this.txtSearchTeacher.Name = "txtSearchTeacher";
            this.txtSearchTeacher.Size = new System.Drawing.Size(212, 29);
            this.txtSearchTeacher.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(763, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtSpecStudent);
            this.panel1.Controls.Add(this.btnResetTeacher);
            this.panel1.Controls.Add(this.btnDeleteTeacher);
            this.panel1.Controls.Add(this.btnSaveTeacher);
            this.panel1.Controls.Add(this.txtPhoneTeacher);
            this.panel1.Controls.Add(this.txtEmailTeacher);
            this.panel1.Controls.Add(this.txtSurnameTeacher);
            this.panel1.Controls.Add(this.txtNameTeacher);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 487);
            this.panel1.TabIndex = 3;
            // 
            // txtSpecStudent
            // 
            this.txtSpecStudent.Location = new System.Drawing.Point(94, 131);
            this.txtSpecStudent.Name = "txtSpecStudent";
            this.txtSpecStudent.Size = new System.Drawing.Size(125, 20);
            this.txtSpecStudent.TabIndex = 15;
            this.txtSpecStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSpecStudent_KeyPress);
            // 
            // btnResetTeacher
            // 
            this.btnResetTeacher.BackColor = System.Drawing.Color.Maroon;
            this.btnResetTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetTeacher.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResetTeacher.Location = new System.Drawing.Point(112, 413);
            this.btnResetTeacher.Name = "btnResetTeacher";
            this.btnResetTeacher.Size = new System.Drawing.Size(96, 40);
            this.btnResetTeacher.TabIndex = 14;
            this.btnResetTeacher.Text = "Reset";
            this.btnResetTeacher.UseVisualStyleBackColor = false;
            this.btnResetTeacher.Click += new System.EventHandler(this.BtnResetTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTeacher.Enabled = false;
            this.btnDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeacher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(12, 413);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(94, 40);
            this.btnDeleteTeacher.TabIndex = 13;
            this.btnDeleteTeacher.Text = "Delete";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.BtnDeleteTeacher_Click);
            // 
            // btnSaveTeacher
            // 
            this.btnSaveTeacher.BackColor = System.Drawing.Color.Green;
            this.btnSaveTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTeacher.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveTeacher.Location = new System.Drawing.Point(12, 347);
            this.btnSaveTeacher.Name = "btnSaveTeacher";
            this.btnSaveTeacher.Size = new System.Drawing.Size(196, 47);
            this.btnSaveTeacher.TabIndex = 12;
            this.btnSaveTeacher.Text = "Save";
            this.btnSaveTeacher.UseVisualStyleBackColor = false;
            this.btnSaveTeacher.Click += new System.EventHandler(this.BtnSaveTeacher_Click);
            // 
            // txtPhoneTeacher
            // 
            this.txtPhoneTeacher.Location = new System.Drawing.Point(94, 229);
            this.txtPhoneTeacher.Name = "txtPhoneTeacher";
            this.txtPhoneTeacher.Size = new System.Drawing.Size(125, 20);
            this.txtPhoneTeacher.TabIndex = 10;
            this.txtPhoneTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneTeacher_KeyPress);
            // 
            // txtEmailTeacher
            // 
            this.txtEmailTeacher.Location = new System.Drawing.Point(94, 179);
            this.txtEmailTeacher.Name = "txtEmailTeacher";
            this.txtEmailTeacher.Size = new System.Drawing.Size(125, 20);
            this.txtEmailTeacher.TabIndex = 9;
            // 
            // txtSurnameTeacher
            // 
            this.txtSurnameTeacher.Location = new System.Drawing.Point(94, 82);
            this.txtSurnameTeacher.Name = "txtSurnameTeacher";
            this.txtSurnameTeacher.Size = new System.Drawing.Size(125, 20);
            this.txtSurnameTeacher.TabIndex = 7;
            this.txtSurnameTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSurnameTeacher_KeyPress);
            // 
            // txtNameTeacher
            // 
            this.txtNameTeacher.Location = new System.Drawing.Point(94, 38);
            this.txtNameTeacher.Name = "txtNameTeacher";
            this.txtNameTeacher.Size = new System.Drawing.Size(125, 20);
            this.txtNameTeacher.TabIndex = 6;
            this.txtNameTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNameTeacher_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Speciality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTeacher,
            this.NameTeacher,
            this.SurnameTeacher,
            this.SpecialityTeacher,
            this.EmailTeacher,
            this.PhoneTeacher});
            this.dgvTeacher.Location = new System.Drawing.Point(238, 113);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.Size = new System.Drawing.Size(635, 362);
            this.dgvTeacher.TabIndex = 4;
            this.dgvTeacher.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTeacher_RowHeaderMouseDoubleClick);
            // 
            // IdTeacher
            // 
            this.IdTeacher.HeaderText = "Id";
            this.IdTeacher.Name = "IdTeacher";
            this.IdTeacher.ReadOnly = true;
            this.IdTeacher.Visible = false;
            // 
            // NameTeacher
            // 
            this.NameTeacher.HeaderText = "Name";
            this.NameTeacher.Name = "NameTeacher";
            this.NameTeacher.ReadOnly = true;
            // 
            // SurnameTeacher
            // 
            this.SurnameTeacher.HeaderText = "Surname";
            this.SurnameTeacher.Name = "SurnameTeacher";
            this.SurnameTeacher.ReadOnly = true;
            // 
            // SpecialityTeacher
            // 
            this.SpecialityTeacher.HeaderText = "Speciality";
            this.SpecialityTeacher.Name = "SpecialityTeacher";
            this.SpecialityTeacher.ReadOnly = true;
            // 
            // EmailTeacher
            // 
            this.EmailTeacher.HeaderText = "Email";
            this.EmailTeacher.Name = "EmailTeacher";
            this.EmailTeacher.ReadOnly = true;
            // 
            // PhoneTeacher
            // 
            this.PhoneTeacher.HeaderText = "Phone";
            this.PhoneTeacher.Name = "PhoneTeacher";
            this.PhoneTeacher.ReadOnly = true;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(876, 487);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchTeacher);
            this.Controls.Add(this.label1);
            this.Name = "TeachersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TeachersForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchTeacher;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnSaveTeacher;
        private System.Windows.Forms.TextBox txtPhoneTeacher;
        private System.Windows.Forms.TextBox txtEmailTeacher;
        private System.Windows.Forms.TextBox txtSurnameTeacher;
        private System.Windows.Forms.TextBox txtNameTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneTeacher;
        private System.Windows.Forms.TextBox txtSpecStudent;
    }
}