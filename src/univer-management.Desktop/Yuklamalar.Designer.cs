namespace FinalProject.Forms
{
    partial class Yuklamalar
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2Button2 = new System.Windows.Forms.Button();
			this.guna2Button1 = new System.Windows.Forms.Button();
			this.panelContainer2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.guna2Button2);
			this.panel1.Controls.Add(this.guna2Button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1061, 44);
			this.panel1.TabIndex = 0;
			// 
			// guna2Button2
			// 
			this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.guna2Button2.Location = new System.Drawing.Point(184, 0);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(184, 44);
			this.guna2Button2.TabIndex = 5;
			this.guna2Button2.Text = "Yuklama";
			this.guna2Button2.UseVisualStyleBackColor = true;
			this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
			// 
			// guna2Button1
			// 
			this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.guna2Button1.Location = new System.Drawing.Point(0, 0);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(184, 44);
			this.guna2Button1.TabIndex = 4;
			this.guna2Button1.Text = "O\'quv reja";
			this.guna2Button1.UseVisualStyleBackColor = true;
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
			// 
			// panelContainer2
			// 
			this.panelContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContainer2.Location = new System.Drawing.Point(0, 44);
			this.panelContainer2.Name = "panelContainer2";
			this.panelContainer2.Size = new System.Drawing.Size(1061, 500);
			this.panelContainer2.TabIndex = 1;
			// 
			// Yuklamalar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1061, 544);
			this.Controls.Add(this.panelContainer2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Yuklamalar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Yuklamalar";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panelContainer2;
		private Button guna2Button2;
		private Button guna2Button1;
	}
}