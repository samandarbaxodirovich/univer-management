namespace univer_management.Desktop.UserControls2
{
    partial class UC_Auditoriya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Auditoriya));
            panel1 = new Panel();
            lblTitle = new Label();
            label1 = new Label();
            auditoriyaRaqami = new TextBox();
            joylarSoni = new TextBox();
            guna2ComboBox1 = new ComboBox();
            auditoriyaBino = new TextBox();
            label2 = new Label();
            guna2CheckBox1 = new CheckBox();
            guna2Button2 = new Button();
            guna2Button3 = new Button();
            DataGridVIew_Auditor = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            guna2TextBox1 = new TextBox();
            guna2Button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridVIew_Auditor).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(366, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(316, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Auditoriya shakllantirish";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(718, 136);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(213, 29);
            label1.TabIndex = 11;
            label1.Text = "Auditoriya qo'shish";
            // 
            // auditoriyaRaqami
            // 
            auditoriyaRaqami.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            auditoriyaRaqami.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            auditoriyaRaqami.Location = new Point(700, 184);
            auditoriyaRaqami.Name = "auditoriyaRaqami";
            auditoriyaRaqami.PlaceholderText = "O'qituvchi";
            auditoriyaRaqami.Size = new Size(283, 30);
            auditoriyaRaqami.TabIndex = 40;
            // 
            // joylarSoni
            // 
            joylarSoni.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            joylarSoni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            joylarSoni.Location = new Point(700, 299);
            joylarSoni.Name = "joylarSoni";
            joylarSoni.PlaceholderText = "O'qituvchi darjasi(raqam)";
            joylarSoni.Size = new Size(283, 30);
            joylarSoni.TabIndex = 39;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox1.FormattingEnabled = true;
            guna2ComboBox1.Location = new Point(700, 249);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.Size = new Size(283, 31);
            guna2ComboBox1.TabIndex = 38;
            // 
            // auditoriyaBino
            // 
            auditoriyaBino.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            auditoriyaBino.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            auditoriyaBino.Location = new Point(700, 351);
            auditoriyaBino.Name = "auditoriyaBino";
            auditoriyaBino.PlaceholderText = "O'qituvchi darjasi(raqam)";
            auditoriyaBino.Size = new Size(283, 30);
            auditoriyaBino.TabIndex = 41;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(700, 231);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 42;
            label2.Text = "Auditoriya turini kiriting";
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.ForeColor = Color.Tomato;
            guna2CheckBox1.Location = new Point(700, 387);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(236, 24);
            guna2CheckBox1.TabIndex = 43;
            guna2CheckBox1.Text = "Auditoriya qo'shishga rozi man";
            guna2CheckBox1.UseVisualStyleBackColor = true;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BackColor = Color.Blue;
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(704, 421);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(129, 29);
            guna2Button2.TabIndex = 44;
            guna2Button2.Text = "qo'shish";
            guna2Button2.UseVisualStyleBackColor = false;
            guna2Button2.Click += guna2Button2_Click_1;
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button3.BackColor = Color.FromArgb(255, 128, 128);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(854, 421);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Size = new Size(129, 29);
            guna2Button3.TabIndex = 45;
            guna2Button3.Text = "tozalash";
            guna2Button3.UseVisualStyleBackColor = false;
            // 
            // DataGridVIew_Auditor
            // 
            DataGridVIew_Auditor.AllowUserToAddRows = false;
            DataGridVIew_Auditor.AllowUserToDeleteRows = false;
            DataGridVIew_Auditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridVIew_Auditor.BackgroundColor = SystemColors.Control;
            DataGridVIew_Auditor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridVIew_Auditor.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            DataGridVIew_Auditor.Location = new Point(28, 184);
            DataGridVIew_Auditor.Name = "DataGridVIew_Auditor";
            DataGridVIew_Auditor.ReadOnly = true;
            DataGridVIew_Auditor.RowHeadersVisible = false;
            DataGridVIew_Auditor.RowHeadersWidth = 51;
            DataGridVIew_Auditor.RowTemplate.Height = 29;
            DataGridVIew_Auditor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridVIew_Auditor.Size = new Size(638, 266);
            DataGridVIew_Auditor.TabIndex = 46;
            DataGridVIew_Auditor.CellContentClick += DataGridVIew_Auditor_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Auditoruya";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Auditoriya turi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 140;
            // 
            // Column4
            // 
            Column4.HeaderText = "Sig'imi";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Korpus";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "O'zgartirish";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Text = "✏️";
            Column6.ToolTipText = "✏️";
            Column6.Width = 80;
            // 
            // Column7
            // 
            Column7.HeaderText = "O'chirish";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "X";
            Column7.ToolTipText = "X";
            Column7.Width = 80;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.Location = new Point(28, 135);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "Qidirish uchun so'z kiriting";
            guna2TextBox1.Size = new Size(283, 30);
            guna2TextBox1.TabIndex = 47;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = SystemColors.Control;
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.Location = new Point(328, 134);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(43, 32);
            guna2Button1.TabIndex = 48;
            guna2Button1.UseVisualStyleBackColor = false;
            guna2Button1.Click += guna2Button1_Click_1;
            // 
            // UC_Auditoriya
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Button1);
            Controls.Add(guna2TextBox1);
            Controls.Add(DataGridVIew_Auditor);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(guna2CheckBox1);
            Controls.Add(label2);
            Controls.Add(auditoriyaBino);
            Controls.Add(auditoriyaRaqami);
            Controls.Add(joylarSoni);
            Controls.Add(guna2ComboBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UC_Auditoriya";
            Size = new Size(1040, 481);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridVIew_Auditor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label label1;
        private TextBox auditoriyaRaqami;
        private TextBox joylarSoni;
        private ComboBox guna2ComboBox1;
        private TextBox auditoriyaBino;
        private Label label2;
        private CheckBox guna2CheckBox1;
        private Button guna2Button2;
        private Button guna2Button3;
        private DataGridView DataGridVIew_Auditor;
        private TextBox guna2TextBox1;
        private Button guna2Button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
    }
}
