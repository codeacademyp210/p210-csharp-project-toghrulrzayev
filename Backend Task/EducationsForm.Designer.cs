namespace Backend_Task
{
    partial class EducationsForm
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
            this.txtSeachEducation = new System.Windows.Forms.TextBox();
            this.btnSearchEducation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetEducation = new System.Windows.Forms.Button();
            this.btnDeleteEducation = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPriceEducation = new System.Windows.Forms.TextBox();
            this.txtNameEducation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEducation = new System.Windows.Forms.DataGridView();
            this.IdEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Educations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSeachEducation
            // 
            this.txtSeachEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeachEducation.Location = new System.Drawing.Point(455, 70);
            this.txtSeachEducation.Name = "txtSeachEducation";
            this.txtSeachEducation.Size = new System.Drawing.Size(195, 26);
            this.txtSeachEducation.TabIndex = 1;
            // 
            // btnSearchEducation
            // 
            this.btnSearchEducation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEducation.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEducation.Location = new System.Drawing.Point(673, 70);
            this.btnSearchEducation.Name = "btnSearchEducation";
            this.btnSearchEducation.Size = new System.Drawing.Size(90, 26);
            this.btnSearchEducation.TabIndex = 2;
            this.btnSearchEducation.Text = "Search";
            this.btnSearchEducation.UseVisualStyleBackColor = false;
            this.btnSearchEducation.Click += new System.EventHandler(this.BtnSearchEducation_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnResetEducation);
            this.panel1.Controls.Add(this.btnDeleteEducation);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtPriceEducation);
            this.panel1.Controls.Add(this.txtNameEducation);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 374);
            this.panel1.TabIndex = 3;
            // 
            // btnResetEducation
            // 
            this.btnResetEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetEducation.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetEducation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetEducation.Location = new System.Drawing.Point(115, 285);
            this.btnResetEducation.Name = "btnResetEducation";
            this.btnResetEducation.Size = new System.Drawing.Size(75, 33);
            this.btnResetEducation.TabIndex = 8;
            this.btnResetEducation.Text = "Reset";
            this.btnResetEducation.UseVisualStyleBackColor = false;
            this.btnResetEducation.Click += new System.EventHandler(this.BtnResetEducation_Click);
            // 
            // btnDeleteEducation
            // 
            this.btnDeleteEducation.BackColor = System.Drawing.Color.Red;
            this.btnDeleteEducation.Enabled = false;
            this.btnDeleteEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEducation.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEducation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteEducation.Location = new System.Drawing.Point(13, 285);
            this.btnDeleteEducation.Name = "btnDeleteEducation";
            this.btnDeleteEducation.Size = new System.Drawing.Size(84, 33);
            this.btnDeleteEducation.TabIndex = 7;
            this.btnDeleteEducation.Text = "Delete";
            this.btnDeleteEducation.UseVisualStyleBackColor = false;
            this.btnDeleteEducation.Click += new System.EventHandler(this.BtnDeleteEducation_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(13, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 49);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtPriceEducation
            // 
            this.txtPriceEducation.Location = new System.Drawing.Point(69, 112);
            this.txtPriceEducation.Name = "txtPriceEducation";
            this.txtPriceEducation.Size = new System.Drawing.Size(139, 20);
            this.txtPriceEducation.TabIndex = 4;
            this.txtPriceEducation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPriceEducation_KeyPress);
            // 
            // txtNameEducation
            // 
            this.txtNameEducation.Location = new System.Drawing.Point(69, 64);
            this.txtNameEducation.Name = "txtNameEducation";
            this.txtNameEducation.Size = new System.Drawing.Size(139, 20);
            this.txtNameEducation.TabIndex = 3;
            this.txtNameEducation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNameEducation_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // dgvEducation
            // 
            this.dgvEducation.AllowUserToAddRows = false;
            this.dgvEducation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEducation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEducation,
            this.NameEducation,
            this.PriceEducation});
            this.dgvEducation.Location = new System.Drawing.Point(246, 128);
            this.dgvEducation.Name = "dgvEducation";
            this.dgvEducation.Size = new System.Drawing.Size(542, 310);
            this.dgvEducation.TabIndex = 4;
            this.dgvEducation.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEducation_RowHeaderMouseDoubleClick);
            // 
            // IdEducation
            // 
            this.IdEducation.HeaderText = "Id";
            this.IdEducation.Name = "IdEducation";
            this.IdEducation.ReadOnly = true;
            this.IdEducation.Visible = false;
            // 
            // NameEducation
            // 
            this.NameEducation.HeaderText = "Name";
            this.NameEducation.Name = "NameEducation";
            this.NameEducation.ReadOnly = true;
            // 
            // PriceEducation
            // 
            this.PriceEducation.HeaderText = "Price";
            this.PriceEducation.Name = "PriceEducation";
            this.PriceEducation.ReadOnly = true;
            // 
            // EducationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEducation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearchEducation);
            this.Controls.Add(this.txtSeachEducation);
            this.Controls.Add(this.label1);
            this.Name = "EducationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EducationsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeachEducation;
        private System.Windows.Forms.Button btnSearchEducation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEducation;
        private System.Windows.Forms.Button btnResetEducation;
        private System.Windows.Forms.Button btnDeleteEducation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPriceEducation;
        private System.Windows.Forms.TextBox txtNameEducation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceEducation;
    }
}