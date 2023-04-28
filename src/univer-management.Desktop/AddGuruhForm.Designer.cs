namespace univer_management.Desktop
{
    partial class AddGuruhForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nameTb = new System.Windows.Forms.TextBox();
			this.numberofSTb = new System.Windows.Forms.TextBox();
			this.semestrTb = new System.Windows.Forms.TextBox();
			this.mutaxasislikCombobox = new System.Windows.Forms.ComboBox();
			this.auditorycombobox = new System.Windows.Forms.ComboBox();
			this.guna2Button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(64, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "Mutaxassislik";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(66, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Auditoriya";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(82, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(243, 46);
			this.label3.TabIndex = 8;
			this.label3.Text = "Guruh qo\'shish";
			// 
			// nameTb
			// 
			this.nameTb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nameTb.Location = new System.Drawing.Point(55, 73);
			this.nameTb.Name = "nameTb";
			this.nameTb.PlaceholderText = "Guruh nomi/raqami";
			this.nameTb.Size = new System.Drawing.Size(299, 30);
			this.nameTb.TabIndex = 9;
			// 
			// numberofSTb
			// 
			this.numberofSTb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numberofSTb.Location = new System.Drawing.Point(55, 114);
			this.numberofSTb.Name = "numberofSTb";
			this.numberofSTb.PlaceholderText = "Guruh nomi/raqami";
			this.numberofSTb.Size = new System.Drawing.Size(299, 30);
			this.numberofSTb.TabIndex = 10;
			// 
			// semestrTb
			// 
			this.semestrTb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.semestrTb.Location = new System.Drawing.Point(55, 261);
			this.semestrTb.Name = "semestrTb";
			this.semestrTb.PlaceholderText = "Guruh nomi/raqami";
			this.semestrTb.Size = new System.Drawing.Size(299, 30);
			this.semestrTb.TabIndex = 11;
			// 
			// mutaxasislikCombobox
			// 
			this.mutaxasislikCombobox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mutaxasislikCombobox.FormattingEnabled = true;
			this.mutaxasislikCombobox.Location = new System.Drawing.Point(55, 164);
			this.mutaxasislikCombobox.Name = "mutaxasislikCombobox";
			this.mutaxasislikCombobox.Size = new System.Drawing.Size(299, 31);
			this.mutaxasislikCombobox.TabIndex = 12;
			// 
			// auditorycombobox
			// 
			this.auditorycombobox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.auditorycombobox.FormattingEnabled = true;
			this.auditorycombobox.Location = new System.Drawing.Point(55, 217);
			this.auditorycombobox.Name = "auditorycombobox";
			this.auditorycombobox.Size = new System.Drawing.Size(299, 31);
			this.auditorycombobox.TabIndex = 13;
			// 
			// guna2Button2
			// 
			this.guna2Button2.BackColor = System.Drawing.Color.Blue;
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Location = new System.Drawing.Point(56, 335);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(294, 56);
			this.guna2Button2.TabIndex = 14;
			this.guna2Button2.Text = "Add";
			this.guna2Button2.UseVisualStyleBackColor = false;
			this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
			// 
			// AddGuruhForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(404, 443);
			this.Controls.Add(this.guna2Button2);
			this.Controls.Add(this.auditorycombobox);
			this.Controls.Add(this.mutaxasislikCombobox);
			this.Controls.Add(this.semestrTb);
			this.Controls.Add(this.numberofSTb);
			this.Controls.Add(this.nameTb);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddGuruhForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddGuruhForm";
			this.Load += new System.EventHandler(this.AddGuruhForm_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
		private TextBox nameTb;
		private TextBox numberofSTb;
		private TextBox semestrTb;
		private ComboBox mutaxasislikCombobox;
		private ComboBox auditorycombobox;
		private Button guna2Button2;
	}
}