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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
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
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(23, 156);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(313, 31);
			this.comboBox1.TabIndex = 29;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox1.Location = new System.Drawing.Point(23, 92);
			this.textBox1.Name = "textBox1";
			this.textBox1.PlaceholderText = "Kafedra nomini kiriting";
			this.textBox1.Size = new System.Drawing.Size(313, 30);
			this.textBox1.TabIndex = 30;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(23, 222);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(313, 45);
			this.button1.TabIndex = 31;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// UpdateKafedra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 295);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "UpdateKafedra";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UpdateKafedra";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
		private ComboBox comboBox1;
		private TextBox textBox1;
		private Button button1;
	}
}