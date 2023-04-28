namespace univer_management.Desktop.UserControls2
{
    partial class UC_O_qituvchilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_O_qituvchilar));
            panel1 = new Panel();
            lblTitle = new Label();
            DataGridVIew_Oqituvchi = new DataGridView();
            kafedraId = new ComboBox();
            gunatextBox = new TextBox();
            gunatextbox2 = new TextBox();
            label2 = new Label();
            guna2Button2 = new CheckBox();
            button1 = new Button();
            guna2Button3 = new Button();
            guna2Button1 = new Button();
            guna2TextBox1 = new TextBox();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            Column6 = new DataGridViewButtonColumn();
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
            lblTitle.Location = new Point(320, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(498, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "O'qituvchilar malumotini shakillantirish";
            // 
            // DataGridVIew_Oqituvchi
            // 
            DataGridVIew_Oqituvchi.AllowUserToAddRows = false;
            DataGridVIew_Oqituvchi.AllowUserToDeleteRows = false;
            DataGridVIew_Oqituvchi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridVIew_Oqituvchi.BackgroundColor = SystemColors.Control;
            DataGridVIew_Oqituvchi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridVIew_Oqituvchi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            DataGridVIew_Oqituvchi.Location = new Point(34, 179);
            DataGridVIew_Oqituvchi.Name = "DataGridVIew_Oqituvchi";
            DataGridVIew_Oqituvchi.ReadOnly = true;
            DataGridVIew_Oqituvchi.RowHeadersVisible = false;
            DataGridVIew_Oqituvchi.RowHeadersWidth = 51;
            DataGridVIew_Oqituvchi.RowTemplate.Height = 29;
            DataGridVIew_Oqituvchi.Size = new Size(638, 266);
            DataGridVIew_Oqituvchi.TabIndex = 58;
            DataGridVIew_Oqituvchi.CellContentClick += dataGridView1_CellContentClick;
            // 
            // kafedraId
            // 
            kafedraId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kafedraId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kafedraId.FormattingEnabled = true;
            kafedraId.Location = new Point(710, 308);
            kafedraId.Name = "kafedraId";
            kafedraId.Size = new Size(283, 31);
            kafedraId.TabIndex = 50;
            // 
            // gunatextBox
            // 
            gunatextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gunatextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gunatextBox.Location = new Point(710, 198);
            gunatextBox.Name = "gunatextBox";
            gunatextBox.PlaceholderText = "To'liq ism sharifini kiriting";
            gunatextBox.Size = new Size(283, 30);
            gunatextBox.TabIndex = 51;
            // 
            // gunatextbox2
            // 
            gunatextbox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gunatextbox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gunatextbox2.Location = new Point(710, 250);
            gunatextbox2.Name = "gunatextbox2";
            gunatextbox2.PlaceholderText = "O'qituvchi darajasi (raqam)";
            gunatextbox2.Size = new Size(283, 30);
            gunatextbox2.TabIndex = 53;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(710, 290);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 54;
            label2.Text = "Kafedrani tanlang";
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.AutoSize = true;
            guna2Button2.ForeColor = Color.Tomato;
            guna2Button2.Location = new Point(706, 382);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(230, 24);
            guna2Button2.TabIndex = 55;
            guna2Button2.Text = "Oqituvchi qo'shishga rozi man";
            guna2Button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(710, 416);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 56;
            button1.Text = "qo'shish";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button3.BackColor = Color.FromArgb(255, 128, 128);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(860, 416);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Size = new Size(129, 29);
            guna2Button3.TabIndex = 57;
            guna2Button3.Text = "tozalash";
            guna2Button3.UseVisualStyleBackColor = false;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = SystemColors.Control;
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.Location = new Point(334, 129);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(43, 32);
            guna2Button1.TabIndex = 60;
            guna2Button1.UseVisualStyleBackColor = false;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.Location = new Point(34, 130);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "Qidirish uchun so'z kiriting";
            guna2TextBox1.Size = new Size(283, 30);
            guna2TextBox1.TabIndex = 59;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(744, 144);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(211, 29);
            label1.TabIndex = 61;
            label1.Text = "O'qituvchi qo'shish";
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Full Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "O'qituvchi darajasi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 170;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kafedra";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "O'zgartirish";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Text = "✏️";
            Column5.UseColumnTextForButtonValue = true;
            Column5.Width = 80;
            // 
            // Column6
            // 
            Column6.HeaderText = "O'chirish";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Text = "X";
            Column6.UseColumnTextForButtonValue = true;
            Column6.Width = 80;
            // 
            // UC_O_qituvchilar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(guna2TextBox1);
            Controls.Add(DataGridVIew_Oqituvchi);
            Controls.Add(guna2Button3);
            Controls.Add(button1);
            Controls.Add(guna2Button2);
            Controls.Add(label2);
            Controls.Add(gunatextbox2);
            Controls.Add(gunatextBox);
            Controls.Add(kafedraId);
            Controls.Add(panel1);
            Name = "UC_O_qituvchilar";
            Size = new Size(1040, 481);
            Load += UC_O_qituvchilar_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridVIew_Oqituvchi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private DataGridView DataGridVIew_Oqituvchi;
        private ComboBox kafedraId;
        private TextBox gunatextBox;
        private TextBox gunatextbox2;
        private Label label2;
        private CheckBox guna2Button2;
        private Button button1;
        private Button guna2Button3;
        private Button guna2Button1;
        private TextBox guna2TextBox1;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Column5;
        private DataGridViewButtonColumn Column6;
    }
}
