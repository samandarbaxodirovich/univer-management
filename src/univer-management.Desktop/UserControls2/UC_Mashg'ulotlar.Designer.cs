namespace univer_management.Desktop.UserControls2
{
    partial class UC_Mashg_ulotlar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Mashg_ulotlar));
            panel1 = new Panel();
            lblTitle = new Label();
            button3 = new Button();
            textBox4 = new TextBox();
            DataGridVIew_Oqituvchi = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            Column4 = new DataGridViewButtonColumn();
            guna2Button3 = new Button();
            guna2Button2 = new Button();
            guna2CheckBox1 = new CheckBox();
            gunatextBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridVIew_Oqituvchi).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 80);
            panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(366, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Mashg'ulotlarni shakllantirish";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(335, 117);
            button3.Name = "button3";
            button3.Size = new Size(43, 32);
            button3.TabIndex = 60;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(35, 118);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Qidirish uchun so'z kiriting";
            textBox4.Size = new Size(283, 30);
            textBox4.TabIndex = 59;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // DataGridVIew_Oqituvchi
            // 
            DataGridVIew_Oqituvchi.AllowUserToAddRows = false;
            DataGridVIew_Oqituvchi.AllowUserToDeleteRows = false;
            DataGridVIew_Oqituvchi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridVIew_Oqituvchi.BackgroundColor = SystemColors.Control;
            DataGridVIew_Oqituvchi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridVIew_Oqituvchi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            DataGridVIew_Oqituvchi.Location = new Point(35, 167);
            DataGridVIew_Oqituvchi.Name = "DataGridVIew_Oqituvchi";
            DataGridVIew_Oqituvchi.ReadOnly = true;
            DataGridVIew_Oqituvchi.RowHeadersVisible = false;
            DataGridVIew_Oqituvchi.RowHeadersWidth = 51;
            DataGridVIew_Oqituvchi.RowTemplate.Height = 29;
            DataGridVIew_Oqituvchi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridVIew_Oqituvchi.Size = new Size(638, 266);
            DataGridVIew_Oqituvchi.TabIndex = 58;
            DataGridVIew_Oqituvchi.CellContentClick += DataGridVIew_Oqituvchi_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Mashg'ulot nomi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "O'zgartirish";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Text = "✏️";
            Column3.UseColumnTextForButtonValue = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "O'chirish";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Text = "X";
            Column4.UseColumnTextForButtonValue = true;
            Column4.Width = 125;
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button3.BackColor = Color.FromArgb(255, 128, 128);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(861, 404);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Size = new Size(129, 29);
            guna2Button3.TabIndex = 57;
            guna2Button3.Text = "tozalash";
            guna2Button3.UseVisualStyleBackColor = false;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BackColor = Color.Blue;
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(711, 404);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(129, 29);
            guna2Button2.TabIndex = 56;
            guna2Button2.Text = "qo'shish";
            guna2Button2.UseVisualStyleBackColor = false;
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.ForeColor = Color.Tomato;
            guna2CheckBox1.Location = new Point(711, 254);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(236, 24);
            guna2CheckBox1.TabIndex = 55;
            guna2CheckBox1.Text = "Mashg'ulotqo'shishga rozi man";
            guna2CheckBox1.UseVisualStyleBackColor = true;
            // 
            // gunatextBox
            // 
            gunatextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gunatextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gunatextBox.Location = new Point(711, 218);
            gunatextBox.Name = "gunatextBox";
            gunatextBox.PlaceholderText = "Mashg'ulotni kiriting";
            gunatextBox.Size = new Size(283, 30);
            gunatextBox.TabIndex = 53;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(740, 167);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(203, 29);
            label1.TabIndex = 61;
            label1.Text = "Mashg'ulot kiritish";
            // 
            // UC_Mashg_ulotlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(DataGridVIew_Oqituvchi);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(guna2CheckBox1);
            Controls.Add(gunatextBox);
            Controls.Add(panel1);
            Name = "UC_Mashg_ulotlar";
            Size = new Size(1040, 481);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridVIew_Oqituvchi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button button3;
        private TextBox textBox4;
        private DataGridView DataGridVIew_Oqituvchi;
        private Button guna2Button3;
        private Button guna2Button2;
        private CheckBox guna2CheckBox1;
        private TextBox gunatextBox;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
        private DataGridViewButtonColumn Column4;
    }
}
