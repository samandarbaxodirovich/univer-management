namespace univer_management.Desktop.UserControls2
{
    partial class UC_Guruh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Guruh));
            panel1 = new Panel();
            lblTitle = new Label();
            guna2Button1 = new Button();
            guna2TextBox1 = new TextBox();
            datagridview1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            guna2Button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview1).BeginInit();
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
            panel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(330, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(418, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Guruhlar ro'yxatini shakllantirish";
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = SystemColors.Control;
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.Location = new Point(330, 127);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(43, 32);
            guna2Button1.TabIndex = 60;
            guna2Button1.UseVisualStyleBackColor = false;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.Location = new Point(30, 128);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "Qidirish uchun so'z kiriting";
            guna2TextBox1.Size = new Size(283, 30);
            guna2TextBox1.TabIndex = 59;
            // 
            // datagridview1
            // 
            datagridview1.AllowUserToAddRows = false;
            datagridview1.AllowUserToDeleteRows = false;
            datagridview1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridview1.BackgroundColor = SystemColors.Control;
            datagridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            datagridview1.Location = new Point(30, 177);
            datagridview1.Name = "datagridview1";
            datagridview1.ReadOnly = true;
            datagridview1.RowHeadersVisible = false;
            datagridview1.RowHeadersWidth = 51;
            datagridview1.RowTemplate.Height = 29;
            datagridview1.Size = new Size(981, 266);
            datagridview1.TabIndex = 58;
            datagridview1.CellContentClick += datagridview1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Guruh nomi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Talabalar soni";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Mutaxassisli";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Auditoriya";
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
            Column6.UseColumnTextForButtonValue = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "O'chirish";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "X";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 125;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BackColor = Color.Blue;
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(815, 128);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(196, 43);
            guna2Button2.TabIndex = 56;
            guna2Button2.Text = "Guruh qo'shish";
            guna2Button2.UseVisualStyleBackColor = false;
            guna2Button2.Click += button1_Click;
            // 
            // UC_Guruh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(guna2Button1);
            Controls.Add(guna2TextBox1);
            Controls.Add(datagridview1);
            Controls.Add(guna2Button2);
            Controls.Add(panel1);
            Name = "UC_Guruh";
            Size = new Size(1040, 481);
            Load += UC_Guruh_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridview1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button guna2Button1;
        private TextBox guna2TextBox1;
        private DataGridView datagridview1;
        private Button guna2Button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
    }
}
