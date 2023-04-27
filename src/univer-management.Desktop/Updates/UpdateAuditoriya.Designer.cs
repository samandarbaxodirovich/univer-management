namespace univer_management.Desktop.Updates
{
    partial class UpdateAuditoriya
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(36, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 15);
			this.label2.TabIndex = 27;
			this.label2.Text = "Auditoriya turini kiriting";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.label1.Location = new System.Drawing.Point(36, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 29);
			this.label1.TabIndex = 21;
			this.label1.Text = "Auditoriyani o\'zgartirish";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(35, 132);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(283, 31);
			this.comboBox1.TabIndex = 28;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(35, 78);
			this.textBox1.Name = "textBox1";
			this.textBox1.PlaceholderText = "Auditoriya raqami";
			this.textBox1.Size = new System.Drawing.Size(283, 30);
			this.textBox1.TabIndex = 29;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox2.Location = new System.Drawing.Point(36, 178);
			this.textBox2.Name = "textBox2";
			this.textBox2.PlaceholderText = "Joylar soni";
			this.textBox2.Size = new System.Drawing.Size(283, 30);
			this.textBox2.TabIndex = 30;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox3.Location = new System.Drawing.Point(36, 225);
			this.textBox3.Name = "textBox3";
			this.textBox3.PlaceholderText = "Bino raqami";
			this.textBox3.Size = new System.Drawing.Size(283, 30);
			this.textBox3.TabIndex = 31;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(36, 292);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(282, 43);
			this.button1.TabIndex = 32;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// UpdateAuditoriya
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 375);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "UpdateAuditoriya";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UpdateAuditoriya";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
		private ComboBox comboBox1;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Button button1;
	}
}