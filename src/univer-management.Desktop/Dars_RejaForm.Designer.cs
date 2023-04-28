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
            panelContainer11 = new Panel();
            panel1 = new Panel();
            guna2Button33 = new Button();
            guna2Button11 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer11
            // 
            panelContainer11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer11.Location = new Point(0, 44);
            panelContainer11.Name = "panelContainer11";
            panelContainer11.Size = new Size(1061, 500);
            panelContainer11.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(guna2Button33);
            panel1.Controls.Add(guna2Button11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1061, 44);
            panel1.TabIndex = 1;
            // 
            // guna2Button33
            // 
            guna2Button33.Dock = DockStyle.Left;
            guna2Button33.FlatStyle = FlatStyle.Flat;
            guna2Button33.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button33.ForeColor = Color.FromArgb(41, 128, 185);
            guna2Button33.Location = new Point(211, 0);
            guna2Button33.Name = "guna2Button33";
            guna2Button33.Size = new Size(211, 44);
            guna2Button33.TabIndex = 1;
            guna2Button33.Text = "O'qituvchi dars rejasi";
            guna2Button33.UseVisualStyleBackColor = true;
            guna2Button33.Click += guna2Button33_Click_1;
            // 
            // guna2Button11
            // 
            guna2Button11.Dock = DockStyle.Left;
            guna2Button11.FlatStyle = FlatStyle.Flat;
            guna2Button11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button11.ForeColor = Color.FromArgb(41, 128, 185);
            guna2Button11.Location = new Point(0, 0);
            guna2Button11.Name = "guna2Button11";
            guna2Button11.Size = new Size(211, 44);
            guna2Button11.TabIndex = 0;
            guna2Button11.Text = "Dars reja";
            guna2Button11.UseVisualStyleBackColor = true;
            guna2Button11.Click += guna2Button11_Click_1;
            // 
            // Dars_RejaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1061, 544);
            Controls.Add(panel1);
            Controls.Add(panelContainer11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dars_RejaForm";
            Text = "Dars_RejaForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer11;
        private Panel panel1;
        private Button guna2Button33;
        private Button guna2Button11;
    }
}