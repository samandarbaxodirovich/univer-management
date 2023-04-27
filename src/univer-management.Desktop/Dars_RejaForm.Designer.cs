namespace univer_management.Desktop
{
    partial class Dars_RejaForm
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
			this.panelContainer11 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelContainer11
			// 
			this.panelContainer11.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelContainer11.Location = new System.Drawing.Point(0, 44);
			this.panelContainer11.Name = "panelContainer11";
			this.panelContainer11.Size = new System.Drawing.Size(1061, 500);
			this.panelContainer11.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1061, 44);
			this.panel1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Left;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(211, 44);
			this.button1.TabIndex = 0;
			this.button1.Text = "Dars reja";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Left;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.button2.Location = new System.Drawing.Point(211, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(211, 44);
			this.button2.TabIndex = 1;
			this.button2.Text = "O\'qituvchi dars rejasi";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Dars_RejaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1061, 544);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelContainer11);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Dars_RejaForm";
			this.Text = "Dars_RejaForm";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContainer11;
        private Panel panel1;
		private Button button2;
		private Button button1;
	}
}