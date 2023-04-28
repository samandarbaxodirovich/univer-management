namespace univer_management.Desktop.Updates
{
    partial class UpdateKafedra
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
			this.Kafedra1 = new System.Windows.Forms.ComboBox();
			this.guna2TextBox1 = new System.Windows.Forms.TextBox();
			this.kafedraupdate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(23, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mutaxassislik ni tanlang";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(35, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(255, 35);
			this.label2.TabIndex = 15;
			this.label2.Text = "Kafedrani O\'zgartirish";
			// 
			// Kafedra1
			// 
			this.Kafedra1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Kafedra1.FormattingEnabled = true;
			this.Kafedra1.Location = new System.Drawing.Point(23, 156);
			this.Kafedra1.Name = "Kafedra1";
			this.Kafedra1.Size = new System.Drawing.Size(313, 31);
			this.Kafedra1.TabIndex = 29;
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2TextBox1.Location = new System.Drawing.Point(23, 92);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PlaceholderText = "Kafedra nomini kiriting";
			this.guna2TextBox1.Size = new System.Drawing.Size(313, 30);
			this.guna2TextBox1.TabIndex = 30;
			// 
			// kafedraupdate
			// 
			this.kafedraupdate.BackColor = System.Drawing.Color.Blue;
			this.kafedraupdate.ForeColor = System.Drawing.Color.White;
			this.kafedraupdate.Location = new System.Drawing.Point(23, 222);
			this.kafedraupdate.Name = "kafedraupdate";
			this.kafedraupdate.Size = new System.Drawing.Size(313, 45);
			this.kafedraupdate.TabIndex = 31;
			this.kafedraupdate.Text = "Update";
			this.kafedraupdate.UseVisualStyleBackColor = false;
			this.kafedraupdate.Click += new System.EventHandler(this.kafedraupdate_Click_1);
			// 
			// UpdateKafedra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 295);
			this.Controls.Add(this.kafedraupdate);
			this.Controls.Add(this.guna2TextBox1);
			this.Controls.Add(this.Kafedra1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "UpdateKafedra";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UpdateKafedra";
			this.Load += new System.EventHandler(this.UpdateKafedra_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
		private ComboBox Kafedra1;
		private TextBox guna2TextBox1;
		private Button kafedraupdate;
	}
}