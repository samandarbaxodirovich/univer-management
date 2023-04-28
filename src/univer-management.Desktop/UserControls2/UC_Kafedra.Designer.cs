namespace univer_management.Desktop.UserControls2
{
    partial class UC_Kafedra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Kafedra));
            panel1 = new Panel();
            lblTitle = new Label();
            label1 = new Label();
            guna2Button1 = new Button();
            guna2TextBox1 = new TextBox();
            datagridView_kafedra = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            Column5 = new DataGridViewButtonColumn();
            guna2Button3 = new Button();
            guna2Button2 = new Button();
            guna2CheckBox1 = new CheckBox();
            label2 = new Label();
            kafedratxt_box = new TextBox();
            mutaxasislikCmb = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridView_kafedra).BeginInit();
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
            lblTitle.Location = new Point(377, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Kafedrani shakllantirish";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(735, 152);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 11;
            label1.Text = "Kafedra qo'shish";
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = SystemColors.Control;
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.Location = new Point(338, 117);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(43, 32);
            guna2Button1.TabIndex = 60;
            guna2Button1.UseVisualStyleBackColor = false;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.Location = new Point(38, 118);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "Qidirish uchun so'z kiriting";
            guna2TextBox1.Size = new Size(283, 30);
            guna2TextBox1.TabIndex = 59;
            // 
            // datagridView_kafedra
            // 
            datagridView_kafedra.AllowUserToAddRows = false;
            datagridView_kafedra.AllowUserToDeleteRows = false;
            datagridView_kafedra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridView_kafedra.BackgroundColor = SystemColors.Control;
            datagridView_kafedra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridView_kafedra.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            datagridView_kafedra.Location = new Point(38, 167);
            datagridView_kafedra.Name = "datagridView_kafedra";
            datagridView_kafedra.ReadOnly = true;
            datagridView_kafedra.RowHeadersVisible = false;
            datagridView_kafedra.RowHeadersWidth = 51;
            datagridView_kafedra.RowTemplate.Height = 29;
            datagridView_kafedra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridView_kafedra.Size = new Size(638, 266);
            datagridView_kafedra.TabIndex = 58;
            datagridView_kafedra.CellContentClick += datagridView_kafedra_CellContentClick_1;
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
            Column2.HeaderText = "Kafedra nomi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Mutaxasislik nomi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "O'zgartirish";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Text = "✏️";
            Column4.UseColumnTextForButtonValue = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "O'chirish";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Text = "X";
            Column5.UseColumnTextForButtonValue = true;
            Column5.Width = 125;
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button3.BackColor = Color.FromArgb(255, 128, 128);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(864, 404);
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
            guna2Button2.Location = new Point(714, 404);
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
            guna2CheckBox1.Location = new Point(714, 326);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(219, 24);
            guna2CheckBox1.TabIndex = 55;
            guna2CheckBox1.Text = "Kafedra qo'shishga rozi man";
            guna2CheckBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(714, 253);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 54;
            label2.Text = "Mutaxassislik nomini kiriting";
            // 
            // kafedratxt_box
            // 
            kafedratxt_box.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kafedratxt_box.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kafedratxt_box.Location = new Point(714, 206);
            kafedratxt_box.Name = "kafedratxt_box";
            kafedratxt_box.PlaceholderText = "Kafedra nomini kiriting";
            kafedratxt_box.Size = new Size(283, 30);
            kafedratxt_box.TabIndex = 52;
            // 
            // mutaxasislikCmb
            // 
            mutaxasislikCmb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mutaxasislikCmb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mutaxasislikCmb.FormattingEnabled = true;
            mutaxasislikCmb.Location = new Point(714, 271);
            mutaxasislikCmb.Name = "mutaxasislikCmb";
            mutaxasislikCmb.Size = new Size(283, 31);
            mutaxasislikCmb.TabIndex = 50;
            // 
            // UC_Kafedra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Button1);
            Controls.Add(guna2TextBox1);
            Controls.Add(datagridView_kafedra);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(guna2CheckBox1);
            Controls.Add(label2);
            Controls.Add(kafedratxt_box);
            Controls.Add(mutaxasislikCmb);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UC_Kafedra";
            Size = new Size(1040, 481);
            Tag = "kafedra";
            Load += UC_Kafedra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridView_kafedra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label label1;
        private Button guna2Button1;
        private TextBox guna2TextBox1;
        private DataGridView datagridView_kafedra;
        private Button guna2Button3;
        private Button guna2Button2;
        private CheckBox guna2CheckBox1;
        private Label label2;
        private TextBox kafedratxt_box;
        private ComboBox mutaxasislikCmb;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn Column4;
        private DataGridViewButtonColumn Column5;
    }
}
