namespace univer_management.Desktop.Updates
{
    partial class UpdateOqituvchi
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Combo = new System.Windows.Forms.ComboBox();
			this.oqituvchi = new System.Windows.Forms.TextBox();
			this.auditoriyaRaqami11 = new System.Windows.Forms.TextBox();
			this.guna2But = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(35, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 15);
			this.label2.TabIndex = 33;
			this.label2.Text = "Kafedrani kiriting";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.label1.Location = new System.Drawing.Point(35, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(251, 29);
			this.label1.TabIndex = 28;
			this.label1.Text = "O\'qituvchinio\'zgartirish";
			// 
			// guna2Combo
			// 
			this.guna2Combo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2Combo.FormattingEnabled = true;
			this.guna2Combo.Location = new System.Drawing.Point(32, 207);
			this.guna2Combo.Name = "guna2Combo";
			this.guna2Combo.Size = new System.Drawing.Size(283, 31);
			this.guna2Combo.TabIndex = 34;
			// 
			// oqituvchi
			// 
			this.oqituvchi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.oqituvchi.Location = new System.Drawing.Point(32, 144);
			this.oqituvchi.Name = "oqituvchi";
			this.oqituvchi.PlaceholderText = "O\'qituvchi darjasi(raqam)";
			this.oqituvchi.Size = new System.Drawing.Size(283, 30);
			this.oqituvchi.TabIndex = 35;
			// 
			// auditoriyaRaqami11
			// 
			this.auditoriyaRaqami11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.auditoriyaRaqami11.Location = new System.Drawing.Point(32, 92);
			this.auditoriyaRaqami11.Name = "auditoriyaRaqami11";
			this.auditoriyaRaqami11.PlaceholderText = "O\'qituvchi";
			this.auditoriyaRaqami11.Size = new System.Drawing.Size(283, 30);
			this.auditoriyaRaqami11.TabIndex = 36;
			// 
			// guna2But
			// 
			this.guna2But.BackColor = System.Drawing.Color.Blue;
			this.guna2But.ForeColor = System.Drawing.Color.White;
			this.guna2But.Location = new System.Drawing.Point(32, 261);
			this.guna2But.Name = "guna2But";
			this.guna2But.Size = new System.Drawing.Size(283, 38);
			this.guna2But.TabIndex = 37;
			this.guna2But.Text = "Create";
			this.guna2But.UseVisualStyleBackColor = false;
			this.guna2But.Click += new System.EventHandler(this.guna2But_Click_1);
			// 
			// UpdateOqituvchi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 335);
			this.Controls.Add(this.guna2But);
			this.Controls.Add(this.auditoriyaRaqami11);
			this.Controls.Add(this.oqituvchi);
			this.Controls.Add(this.guna2Combo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "UpdateOqituvchi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UpdateOqituvchi";
			this.Load += new System.EventHandler(this.UpdateOqituvchi_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
		private ComboBox guna2Combo;
		private TextBox oqituvchi;
		private TextBox auditoriyaRaqami11;
		private Button guna2But;
	}
}