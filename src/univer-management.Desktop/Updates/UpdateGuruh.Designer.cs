namespace univer_management.Desktop.Updates
{
    partial class UpdateGuruh
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            guna2Button21 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 69);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "  guruh nomi";
            textBox1.Size = new Size(333, 35);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 125);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "  talabalar soni";
            textBox2.Size = new Size(333, 35);
            textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(332, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(11, 237);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(334, 28);
            comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 166);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 4;
            label1.Text = "mutaxassilik nomi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 219);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 5;
            label2.Text = "auditoriya nomi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 9);
            label3.Name = "label3";
            label3.Size = new Size(319, 46);
            label3.TabIndex = 9;
            label3.Text = "Guruhni O'zgartirish";
            // 
            // guna2Button21
            // 
            guna2Button21.BackColor = Color.Blue;
            guna2Button21.ForeColor = Color.White;
            guna2Button21.Location = new Point(26, 291);
            guna2Button21.Name = "guna2Button21";
            guna2Button21.Size = new Size(282, 43);
            guna2Button21.TabIndex = 33;
            guna2Button21.Text = "Create";
            guna2Button21.UseVisualStyleBackColor = false;
            guna2Button21.Click += guna2Button21_Click;
            // 
            // UpdateGuruh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 400);
            Controls.Add(guna2Button21);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "UpdateGuruh";
            Text = "UpdateGuruh";
            Load += UpdateGuruh_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button guna2Button21;
    }
}