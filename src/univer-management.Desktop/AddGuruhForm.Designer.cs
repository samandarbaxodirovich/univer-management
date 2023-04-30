namespace univer_management.Desktop
{
    partial class AddGuruhForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numberofSTb = new TextBox();
            semestrTb = new TextBox();
            mutaxasislikCombobox = new ComboBox();
            auditorycombobox = new ComboBox();
            guna2Button2 = new Button();
            nameTb = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 147);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 6;
            label1.Text = "Mutaxassislik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(66, 199);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "Auditoriya";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 9);
            label3.Name = "label3";
            label3.Size = new Size(243, 46);
            label3.TabIndex = 8;
            label3.Text = "Guruh qo'shish";
            // 
            // numberofSTb
            // 
            numberofSTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            numberofSTb.Location = new Point(55, 114);
            numberofSTb.Name = "numberofSTb";
            numberofSTb.PlaceholderText = "Smestir raqami";
            numberofSTb.Size = new Size(299, 30);
            numberofSTb.TabIndex = 10;
            // 
            // semestrTb
            // 
            semestrTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            semestrTb.Location = new Point(55, 261);
            semestrTb.Name = "semestrTb";
            semestrTb.PlaceholderText = "Guruh nomi/raqami";
            semestrTb.Size = new Size(299, 30);
            semestrTb.TabIndex = 11;
            // 
            // mutaxasislikCombobox
            // 
            mutaxasislikCombobox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mutaxasislikCombobox.FormattingEnabled = true;
            mutaxasislikCombobox.Location = new Point(55, 164);
            mutaxasislikCombobox.Name = "mutaxasislikCombobox";
            mutaxasislikCombobox.Size = new Size(299, 31);
            mutaxasislikCombobox.TabIndex = 12;
            // 
            // auditorycombobox
            // 
            auditorycombobox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            auditorycombobox.FormattingEnabled = true;
            auditorycombobox.Location = new Point(55, 217);
            auditorycombobox.Name = "auditorycombobox";
            auditorycombobox.Size = new Size(299, 31);
            auditorycombobox.TabIndex = 13;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Blue;
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(56, 335);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(294, 56);
            guna2Button2.TabIndex = 14;
            guna2Button2.Text = "Add";
            guna2Button2.UseVisualStyleBackColor = false;
            guna2Button2.Click += guna2Button2_Click;
            // 
            // nameTb
            // 
            nameTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nameTb.Location = new Point(55, 73);
            nameTb.Name = "nameTb";
            nameTb.PlaceholderText = "Guruh nomi/raqami";
            nameTb.Size = new Size(299, 30);
            nameTb.TabIndex = 9;
            nameTb.TextChanged += nameTb_TextChanged;
            // 
            // AddGuruhForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(404, 443);
            Controls.Add(guna2Button2);
            Controls.Add(auditorycombobox);
            Controls.Add(mutaxasislikCombobox);
            Controls.Add(semestrTb);
            Controls.Add(numberofSTb);
            Controls.Add(nameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddGuruhForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddGuruhForm";
            Load += AddGuruhForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox numberofSTb;
        private TextBox semestrTb;
        private ComboBox mutaxasislikCombobox;
        private ComboBox auditorycombobox;
        private Button guna2Button2;
        private TextBox nameTb;
    }
}