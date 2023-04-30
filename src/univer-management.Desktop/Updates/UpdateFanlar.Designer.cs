namespace univer_management.Desktop.Updates
{
    partial class UpdateFanlar
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
            label3 = new Label();
            guna2ComboBox1 = new ComboBox();
            guna2Button2 = new Button();
            label1 = new Label();
            guna2TextBox2 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 227);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 69;
            label3.Text = "Kafedrani kiriting";
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox1.FormattingEnabled = true;
            guna2ComboBox1.Location = new Point(41, 245);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.Size = new Size(283, 31);
            guna2ComboBox1.TabIndex = 68;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BackColor = Color.Blue;
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(41, 311);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(279, 43);
            guna2Button2.TabIndex = 67;
            guna2Button2.Text = "o'zgartirish";
            guna2Button2.UseVisualStyleBackColor = false;
            guna2Button2.Click += guna2Button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 164);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 66;
            label1.Text = "Fan qiyinchiligini kiriting ";
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox2.Location = new Point(41, 117);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "Fan nomi";
            guna2TextBox2.Size = new Size(283, 30);
            guna2TextBox2.TabIndex = 65;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(67, 59);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(230, 32);
            label2.TabIndex = 63;
            label2.Text = "Fanni o'zgartirish";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 31);
            comboBox1.TabIndex = 70;
            // 
            // UpdateFanlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 398);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(guna2ComboBox1);
            Controls.Add(guna2Button2);
            Controls.Add(label1);
            Controls.Add(guna2TextBox2);
            Controls.Add(label2);
            Name = "UpdateFanlar";
            Text = "UpdateFanlar";
            Load += UpdateFanlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox guna2ComboBox1;
        private Button guna2Button2;
        private Label label1;
        private TextBox guna2TextBox2;
        private Label label2;
        private ComboBox comboBox1;
    }
}