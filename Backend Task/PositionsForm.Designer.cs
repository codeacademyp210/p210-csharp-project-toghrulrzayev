namespace Backend_Task
{
    partial class PositionsForm
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
            this.txtNamePosition = new System.Windows.Forms.TextBox();
            this.btnResetPosition = new System.Windows.Forms.Button();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.btnSavePos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.IdPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchPosition = new System.Windows.Forms.TextBox();
            this.btnSearchPosition = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Positions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.txtNamePosition);
            this.panel1.Controls.Add(this.btnResetPosition);
            this.panel1.Controls.Add(this.btnDeletePosition);
            this.panel1.Controls.Add(this.btnSavePos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(415, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 279);
            this.panel1.TabIndex = 1;
            // 
            // txtNamePosition
            // 
            this.txtNamePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePosition.Location = new System.Drawing.Point(139, 47);
            this.txtNamePosition.Name = "txtNamePosition";
            this.txtNamePosition.Size = new System.Drawing.Size(140, 26);
            this.txtNamePosition.TabIndex = 5;
            this.txtNamePosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNamePosition_KeyPress);
            // 
            // btnResetPosition
            // 
            this.btnResetPosition.BackColor = System.Drawing.Color.Maroon;
            this.btnResetPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPosition.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResetPosition.Location = new System.Drawing.Point(179, 203);
            this.btnResetPosition.Name = "btnResetPosition";
            this.btnResetPosition.Size = new System.Drawing.Size(100, 36);
            this.btnResetPosition.TabIndex = 4;
            this.btnResetPosition.Text = "Reset";
            this.btnResetPosition.UseVisualStyleBackColor = false;
            this.btnResetPosition.Click += new System.EventHandler(this.BtnResetPosition_Click);
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.BackColor = System.Drawing.Color.Red;
            this.btnDeletePosition.Enabled = false;
            this.btnDeletePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePosition.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePosition.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeletePosition.Location = new System.Drawing.Point(53, 203);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(95, 36);
            this.btnDeletePosition.TabIndex = 3;
            this.btnDeletePosition.Text = "Delete";
            this.btnDeletePosition.UseVisualStyleBackColor = false;
            this.btnDeletePosition.Click += new System.EventHandler(this.BtnDeletePosition_Click);
            // 
            // btnSavePos
            // 
            this.btnSavePos.BackColor = System.Drawing.Color.Green;
            this.btnSavePos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSavePos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePos.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSavePos.Location = new System.Drawing.Point(53, 139);
            this.btnSavePos.Name = "btnSavePos";
            this.btnSavePos.Size = new System.Drawing.Size(226, 42);
            this.btnSavePos.TabIndex = 2;
            this.btnSavePos.Text = "Save";
            this.btnSavePos.UseVisualStyleBackColor = false;
            this.btnSavePos.Click += new System.EventHandler(this.BtnSavePos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToAddRows = false;
            this.dgvPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPosition,
            this.NamePosition});
            this.dgvPosition.Location = new System.Drawing.Point(2, 76);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.Size = new System.Drawing.Size(380, 362);
            this.dgvPosition.TabIndex = 2;
            this.dgvPosition.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPosition_RowHeaderMouseDoubleClick);
            // 
            // IdPosition
            // 
            this.IdPosition.HeaderText = "Id";
            this.IdPosition.Name = "IdPosition";
            this.IdPosition.ReadOnly = true;
            this.IdPosition.Visible = false;
            // 
            // NamePosition
            // 
            this.NamePosition.HeaderText = "Name";
            this.NamePosition.Name = "NamePosition";
            this.NamePosition.ReadOnly = true;
            // 
            // txtSearchPosition
            // 
            this.txtSearchPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPosition.Location = new System.Drawing.Point(422, 78);
            this.txtSearchPosition.Name = "txtSearchPosition";
            this.txtSearchPosition.Size = new System.Drawing.Size(237, 26);
            this.txtSearchPosition.TabIndex = 3;
            // 
            // btnSearchPosition
            // 
            this.btnSearchPosition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPosition.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPosition.Location = new System.Drawing.Point(677, 74);
            this.btnSearchPosition.Name = "btnSearchPosition";
            this.btnSearchPosition.Size = new System.Drawing.Size(75, 30);
            this.btnSearchPosition.TabIndex = 4;
            this.btnSearchPosition.Text = "Search";
            this.btnSearchPosition.UseVisualStyleBackColor = false;
            this.btnSearchPosition.Click += new System.EventHandler(this.BtnSearchPosition_Click);
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchPosition);
            this.Controls.Add(this.txtSearchPosition);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "PositionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PositionsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.TextBox txtNamePosition;
        private System.Windows.Forms.Button btnResetPosition;
        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.Button btnSavePos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchPosition;
        private System.Windows.Forms.Button btnSearchPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePosition;
    }
}