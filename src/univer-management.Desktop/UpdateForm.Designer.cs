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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BorderRadius = 20;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(99, 150);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(277, 39);
            guna2Button2.TabIndex = 13;
            guna2Button2.Text = "Update";
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox2.BorderRadius = 5;
            guna2TextBox2.CustomizableEdges = customizableEdges3;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox2.ForeColor = Color.Black;
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(64, 79);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PasswordChar = '\0';
            guna2TextBox2.PlaceholderForeColor = Color.Gray;
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox2.Size = new Size(322, 39);
            guna2TextBox2.TabIndex = 11;
            guna2TextBox2.TextChanged += guna2TextBox2_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 22);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(345, 32);
            label1.TabIndex = 10;
            label1.Text = "Muttaxasislikni o'zgartirish";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 226);
            Controls.Add(guna2Button2);
            Controls.Add(guna2TextBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "UpdateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Label label1;
    }
}