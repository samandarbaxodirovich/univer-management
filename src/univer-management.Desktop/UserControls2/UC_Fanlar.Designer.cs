namespace univer_management.Desktop.UserControls2
{
    partial class UC_Fanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Fanlar));
            panel1 = new Panel();
            lblTitle = new Label();
            label2 = new Label();
            guna2Button1 = new Button();
            guna2TextBox1 = new TextBox();
            guna2DataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            Column4 = new DataGridViewButtonColumn();
            guna2Button3 = new Button();
            guna2Button2 = new Button();
            guna2CheckBox1 = new CheckBox();
            label1 = new Label();
            guna2TextBox2 = new TextBox();
            guna2ComboBox2 = new ComboBox();
            label3 = new Label();
            guna2ComboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
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
            lblTitle.Location = new Point(365, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(292, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Fanlarni shakllantirish";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(761, 132);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 18;
            label2.Text = "Fan qo'shish";
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = SystemColors.Control;
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.Location = new Point(343, 131);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(43, 32);
            guna2Button1.TabIndex = 60;
            guna2Button1.UseVisualStyleBackColor = false;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.Location = new Point(43, 132);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "Qidirish uchun so'z kiriting";
            guna2TextBox1.Size = new Size(283, 30);
            guna2TextBox1.TabIndex = 59;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView1.BackgroundColor = SystemColors.Control;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, name, Column1, Column2, Column3, Column4 });
            guna2DataGridView1.Location = new Point(43, 181);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 29;
            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guna2DataGridView1.Size = new Size(638, 266);
            guna2DataGridView1.TabIndex = 58;
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick_1;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // name
            // 
            name.HeaderText = "Fan ";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Fan qiyinchiligi";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 140;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Kafedra nomi";
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
            Column3.Width = 80;
            // 
            // Column4
            // 
            Column4.HeaderText = "O'chirish";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Text = "X";
            Column4.UseColumnTextForButtonValue = true;
            Column4.Width = 80;
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button3.BackColor = Color.FromArgb(255, 128, 128);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(869, 418);
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
            guna2Button2.Location = new Point(719, 418);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(129, 29);
            guna2Button2.TabIndex = 56;
            guna2Button2.Text = "qo'shish";
            guna2Button2.UseVisualStyleBackColor = false;
            guna2Button2.Click += guna2Button2_Click_1;
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.ForeColor = Color.Tomato;
            guna2CheckBox1.Location = new Point(715, 360);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(185, 24);
            guna2CheckBox1.TabIndex = 55;
            guna2CheckBox1.Text = "Fan qo'shishga roziman";
            guna2CheckBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(715, 228);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 54;
            label1.Text = "Fan qiyinchiligini kiriting ";
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox2.Location = new Point(715, 181);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "Fan nomi";
            guna2TextBox2.Size = new Size(283, 30);
            guna2TextBox2.TabIndex = 52;
            // 
            // guna2ComboBox2
            // 
            guna2ComboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ComboBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox2.FormattingEnabled = true;
            guna2ComboBox2.Location = new Point(715, 246);
            guna2ComboBox2.Name = "guna2ComboBox2";
            guna2ComboBox2.Size = new Size(283, 31);
            guna2ComboBox2.TabIndex = 50;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(715, 291);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 62;
            label3.Text = "Kafedrani kiriting";
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox1.FormattingEnabled = true;
            guna2ComboBox1.Location = new Point(715, 309);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.Size = new Size(283, 31);
            guna2ComboBox1.TabIndex = 61;
            // 
            // UC_Fanlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(label3);
            Controls.Add(guna2ComboBox1);
            Controls.Add(guna2Button1);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2DataGridView1);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(guna2CheckBox1);
            Controls.Add(label1);
            Controls.Add(guna2TextBox2);
            Controls.Add(guna2ComboBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "UC_Fanlar";
            Size = new Size(1040, 481);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label label2;
        private Button guna2Button1;
        private TextBox guna2TextBox1;
        private DataGridView guna2DataGridView1;
        private Button guna2Button3;
        private Button guna2Button2;
        private CheckBox guna2CheckBox1;
        private Label label1;
        private TextBox guna2TextBox2;
        private ComboBox guna2ComboBox2;
        private Label label3;
        private ComboBox guna2ComboBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
        private DataGridViewButtonColumn Column4;
    }
}
