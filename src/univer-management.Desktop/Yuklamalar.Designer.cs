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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panelContainer2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(guna2Button2);
            panel1.Controls.Add(guna2Button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 44);
            panel1.TabIndex = 0;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.FromArgb(41, 128, 185);
            guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button2.CheckedState.CustomBorderColor = Color.FromArgb(41, 128, 185);
            guna2Button2.CheckedState.FillColor = Color.White;
            guna2Button2.CustomBorderColor = Color.White;
            guna2Button2.CustomBorderThickness = new Padding(0, 0, 0, 3);
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.White;
            guna2Button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.FromArgb(41, 128, 185);
            guna2Button2.HoverState.CustomBorderColor = Color.FromArgb(192, 0, 0);
            guna2Button2.Location = new Point(186, 5);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(179, 38);
            guna2Button2.TabIndex = 2;
            guna2Button2.Text = "Yuklama";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.White;
            guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            guna2Button1.Checked = true;
            guna2Button1.CheckedState.CustomBorderColor = Color.FromArgb(41, 128, 185);
            guna2Button1.CheckedState.FillColor = Color.White;
            guna2Button1.CustomBorderThickness = new Padding(0, 0, 0, 3);
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.FromArgb(41, 128, 185);
            guna2Button1.HoverState.CustomBorderColor = Color.FromArgb(192, 0, 0);
            guna2Button1.Location = new Point(4, 5);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(179, 38);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "O'quv reja";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // panelContainer2
            // 
            panelContainer2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer2.Location = new Point(0, 44);
            panelContainer2.Name = "panelContainer2";
            panelContainer2.Size = new Size(1060, 500);
            panelContainer2.TabIndex = 1;
            panelContainer2.Paint += panelContainer2_Paint;
            // 
            // Yuklamalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 544);
            Controls.Add(panelContainer2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Yuklamalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yuklamalar";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelContainer2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}