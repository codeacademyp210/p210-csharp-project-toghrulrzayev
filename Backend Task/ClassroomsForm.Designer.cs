namespace Backend_Task
{
    partial class ClassroomsForm
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
            this.btnSearchClassroom = new System.Windows.Forms.Button();
            this.txtSeachClassroom = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetClassroom = new System.Windows.Forms.Button();
            this.btnDeleteClassroom = new System.Windows.Forms.Button();
            this.btnSaveClassroom = new System.Windows.Forms.Button();
            this.txtNameClassroom = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.dgvClassrooms = new System.Windows.Forms.DataGridView();
            this.IdClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassrooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classrooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSearchClassroom
            // 
            this.btnSearchClassroom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClassroom.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClassroom.Location = new System.Drawing.Point(672, 79);
            this.btnSearchClassroom.Name = "btnSearchClassroom";
            this.btnSearchClassroom.Size = new System.Drawing.Size(80, 29);
            this.btnSearchClassroom.TabIndex = 1;
            this.btnSearchClassroom.Text = "Search";
            this.btnSearchClassroom.UseVisualStyleBackColor = false;
            this.btnSearchClassroom.Click += new System.EventHandler(this.BtnSearchClassroom_Click);
            // 
            // txtSeachClassroom
            // 
            this.txtSeachClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachClassroom.Location = new System.Drawing.Point(458, 82);
            this.txtSeachClassroom.Name = "txtSeachClassroom";
            this.txtSeachClassroom.Size = new System.Drawing.Size(191, 26);
            this.txtSeachClassroom.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetClassroom);
            this.panel1.Controls.Add(this.btnDeleteClassroom);
            this.panel1.Controls.Add(this.btnSaveClassroom);
            this.panel1.Controls.Add(this.txtNameClassroom);
            this.panel1.Controls.Add(this.labelname);
            this.panel1.Location = new System.Drawing.Point(458, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 290);
            this.panel1.TabIndex = 3;
            // 
            // btnResetClassroom
            // 
            this.btnResetClassroom.BackColor = System.Drawing.Color.Maroon;
            this.btnResetClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetClassroom.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetClassroom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetClassroom.Location = new System.Drawing.Point(164, 220);
            this.btnResetClassroom.Name = "btnResetClassroom";
            this.btnResetClassroom.Size = new System.Drawing.Size(92, 36);
            this.btnResetClassroom.TabIndex = 6;
            this.btnResetClassroom.Text = "Reset";
            this.btnResetClassroom.UseVisualStyleBackColor = false;
            this.btnResetClassroom.Click += new System.EventHandler(this.BtnResetClassroom_Click);
            // 
            // btnDeleteClassroom
            // 
            this.btnDeleteClassroom.BackColor = System.Drawing.Color.Red;
            this.btnDeleteClassroom.Enabled = false;
            this.btnDeleteClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClassroom.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClassroom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteClassroom.Location = new System.Drawing.Point(32, 220);
            this.btnDeleteClassroom.Name = "btnDeleteClassroom";
            this.btnDeleteClassroom.Size = new System.Drawing.Size(107, 36);
            this.btnDeleteClassroom.TabIndex = 5;
            this.btnDeleteClassroom.Text = "Delete";
            this.btnDeleteClassroom.UseVisualStyleBackColor = false;
            this.btnDeleteClassroom.Click += new System.EventHandler(this.BtnDeleteClassroom_Click);
            // 
            // btnSaveClassroom
            // 
            this.btnSaveClassroom.BackColor = System.Drawing.Color.Green;
            this.btnSaveClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClassroom.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveClassroom.Location = new System.Drawing.Point(32, 157);
            this.btnSaveClassroom.Name = "btnSaveClassroom";
            this.btnSaveClassroom.Size = new System.Drawing.Size(224, 42);
            this.btnSaveClassroom.TabIndex = 4;
            this.btnSaveClassroom.Text = "Save";
            this.btnSaveClassroom.UseVisualStyleBackColor = false;
            this.btnSaveClassroom.Click += new System.EventHandler(this.BtnSaveClassroom_Click);
            // 
            // txtNameClassroom
            // 
            this.txtNameClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameClassroom.Location = new System.Drawing.Point(107, 55);
            this.txtNameClassroom.Name = "txtNameClassroom";
            this.txtNameClassroom.Size = new System.Drawing.Size(149, 26);
            this.txtNameClassroom.TabIndex = 2;
            this.txtNameClassroom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNameClassroom_KeyPress);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(26, 55);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(59, 21);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Name";
            // 
            // dgvClassrooms
            // 
            this.dgvClassrooms.AllowUserToAddRows = false;
            this.dgvClassrooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClassrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassrooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClassroom,
            this.NameClassroom});
            this.dgvClassrooms.Location = new System.Drawing.Point(12, 82);
            this.dgvClassrooms.Name = "dgvClassrooms";
            this.dgvClassrooms.Size = new System.Drawing.Size(408, 356);
            this.dgvClassrooms.TabIndex = 4;
            this.dgvClassrooms.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvClassrooms_RowHeaderMouseDoubleClick);
            // 
            // IdClassroom
            // 
            this.IdClassroom.HeaderText = "Id";
            this.IdClassroom.Name = "IdClassroom";
            this.IdClassroom.ReadOnly = true;
            this.IdClassroom.Visible = false;
            // 
            // NameClassroom
            // 
            this.NameClassroom.HeaderText = "Name";
            this.NameClassroom.Name = "NameClassroom";
            this.NameClassroom.ReadOnly = true;
            // 
            // ClassroomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClassrooms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSeachClassroom);
            this.Controls.Add(this.btnSearchClassroom);
            this.Controls.Add(this.label1);
            this.Name = "ClassroomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClassroomsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassrooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchClassroom;
        private System.Windows.Forms.TextBox txtSeachClassroom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetClassroom;
        private System.Windows.Forms.Button btnDeleteClassroom;
        private System.Windows.Forms.Button btnSaveClassroom;
        private System.Windows.Forms.TextBox txtNameClassroom;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.DataGridView dgvClassrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClassroom;
    }
}