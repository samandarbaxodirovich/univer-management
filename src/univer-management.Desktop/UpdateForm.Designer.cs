namespace univer_management.Desktop
{
    partial class UpdateForm
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
			this.guna2TextBox2 = new System.Windows.Forms.TextBox();
			this.guna2Button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(52, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(351, 32);
			this.label1.TabIndex = 10;
			this.label1.Text = "Mutaxassislikni o\'zgartirish";
			// 
			// guna2TextBox2
			// 
			this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2TextBox2.Location = new System.Drawing.Point(61, 83);
			this.guna2TextBox2.Name = "guna2TextBox2";
			this.guna2TextBox2.PlaceholderText = "Mutaxassislikni kiriting";
			this.guna2TextBox2.Size = new System.Drawing.Size(322, 30);
			this.guna2TextBox2.TabIndex = 11;
			// 
			// guna2Button2
			// 
			this.guna2Button2.BackColor = System.Drawing.Color.Blue;
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Location = new System.Drawing.Point(61, 149);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(322, 40);
			this.guna2Button2.TabIndex = 12;
			this.guna2Button2.Text = "Update";
			this.guna2Button2.UseVisualStyleBackColor = false;
			this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
			// 
			// UpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(454, 226);
			this.Controls.Add(this.guna2Button2);
			this.Controls.Add(this.guna2TextBox2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "UpdateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UpdateForm";
			this.Load += new System.EventHandler(this.UpdateForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Label label1;
		private TextBox guna2TextBox2;
		private Button guna2Button2;
	}
}