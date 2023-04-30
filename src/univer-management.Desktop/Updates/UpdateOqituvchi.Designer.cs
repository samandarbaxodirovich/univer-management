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
            label2 = new Label();
            label1 = new Label();
            guna2Combo = new ComboBox();
            oqituvchi = new TextBox();
            auditoriyaRaqami11 = new TextBox();
            guna2But = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 189);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 33;
            label2.Text = "Kafedrani kiriting";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(35, 47);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(251, 29);
            label1.TabIndex = 28;
            label1.Text = "O'qituvchinio'zgartirish";
            // 
            // guna2Combo
            // 
            guna2Combo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Combo.FormattingEnabled = true;
            guna2Combo.Location = new Point(32, 207);
            guna2Combo.Name = "guna2Combo";
            guna2Combo.Size = new Size(283, 31);
            guna2Combo.TabIndex = 34;
            // 
            // oqituvchi
            // 
            oqituvchi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            oqituvchi.Location = new Point(32, 144);
            oqituvchi.Name = "oqituvchi";
            oqituvchi.PlaceholderText = "O'qituvchi darjasi(raqam)";
            oqituvchi.Size = new Size(283, 30);
            oqituvchi.TabIndex = 35;
            // 
            // auditoriyaRaqami11
            // 
            auditoriyaRaqami11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            auditoriyaRaqami11.Location = new Point(32, 92);
            auditoriyaRaqami11.Name = "auditoriyaRaqami11";
            auditoriyaRaqami11.PlaceholderText = "O'qituvchi";
            auditoriyaRaqami11.Size = new Size(283, 30);
            auditoriyaRaqami11.TabIndex = 36;
            auditoriyaRaqami11.TextChanged += auditoriyaRaqami11_TextChanged;
            // 
            // guna2But
            // 
            guna2But.BackColor = Color.Blue;
            guna2But.ForeColor = Color.White;
            guna2But.Location = new Point(32, 261);
            guna2But.Name = "guna2But";
            guna2But.Size = new Size(283, 38);
            guna2But.TabIndex = 37;
            guna2But.Text = "Create";
            guna2But.UseVisualStyleBackColor = false;
            guna2But.Click += guna2But_Click_1;
            // 
            // UpdateOqituvchi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 335);
            Controls.Add(guna2But);
            Controls.Add(auditoriyaRaqami11);
            Controls.Add(oqituvchi);
            Controls.Add(guna2Combo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "UpdateOqituvchi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateOqituvchi";
            Load += UpdateOqituvchi_Load;
            ResumeLayout(false);
            PerformLayout();
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