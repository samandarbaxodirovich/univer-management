namespace FinalProject.UserControls2
{
    partial class UC_Uquv_reja
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Uquv_reja));
            panel1 = new Panel();
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            datagrid_Oquv_reja = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            Column8 = new DataGridViewButtonColumn();
            guna2ComboBox1 = new ComboBox();
            guna2ComboBox2 = new ComboBox();
            guna2Button1 = new Button();
            guna2Button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_Oquv_reja).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 80);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(381, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(254, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "O'quv rejani kiritish";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 113);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 14;
            label1.Text = "Mutaxasislikni tanlang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 113);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 15;
            label2.Text = "Semestrni tanlang";
            // 
            // datagrid_Oquv_reja
            // 
            datagrid_Oquv_reja.AllowUserToAddRows = false;
            datagrid_Oquv_reja.AllowUserToDeleteRows = false;
            datagrid_Oquv_reja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagrid_Oquv_reja.BackgroundColor = SystemColors.Control;
            datagrid_Oquv_reja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_Oquv_reja.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            datagrid_Oquv_reja.Location = new Point(28, 185);
            datagrid_Oquv_reja.Name = "datagrid_Oquv_reja";
            datagrid_Oquv_reja.ReadOnly = true;
            datagrid_Oquv_reja.RowHeadersVisible = false;
            datagrid_Oquv_reja.RowHeadersWidth = 51;
            datagrid_Oquv_reja.RowTemplate.Height = 29;
            datagrid_Oquv_reja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid_Oquv_reja.Size = new Size(973, 266);
            datagrid_Oquv_reja.TabIndex = 59;
            datagrid_Oquv_reja.CellContentClick += datagrid_Oquv_reja_CellContentClick_1;
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
            Column2.HeaderText = "Fan nomi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ma'ruza";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Amaliy";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Oraliq imtixon";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Mustaqil ta'lim";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "O'zgartirish";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "✏️";
            Column7.UseColumnTextForButtonValue = true;
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.HeaderText = "O'chirish";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Text = "X";
            Column8.UseColumnTextForButtonValue = true;
            Column8.Width = 80;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox1.FormattingEnabled = true;
            guna2ComboBox1.Location = new Point(28, 136);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.Size = new Size(283, 31);
            guna2ComboBox1.TabIndex = 60;
            // 
            // guna2ComboBox2
            // 
            guna2ComboBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox2.FormattingEnabled = true;
            guna2ComboBox2.Location = new Point(335, 136);
            guna2ComboBox2.Name = "guna2ComboBox2";
            guna2ComboBox2.Size = new Size(283, 31);
            guna2ComboBox2.TabIndex = 61;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = SystemColors.Control;
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.Location = new Point(642, 135);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(43, 32);
            guna2Button1.TabIndex = 62;
            guna2Button1.UseVisualStyleBackColor = false;
            guna2Button1.Click += guna2Button1_Click_1;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BackColor = Color.Blue;
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(805, 136);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(196, 32);
            guna2Button2.TabIndex = 63;
            guna2Button2.Text = "O'quv reja qo'shish";
            guna2Button2.UseVisualStyleBackColor = false;
            guna2Button2.Click += button1_Click;
            // 
            // UC_Uquv_reja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(guna2ComboBox2);
            Controls.Add(guna2ComboBox1);
            Controls.Add(datagrid_Oquv_reja);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UC_Uquv_reja";
            Size = new Size(1040, 481);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_Oquv_reja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label label1;
        private Label label2;
        private DataGridView datagrid_Oquv_reja;
        private ComboBox guna2ComboBox1;
        private ComboBox guna2ComboBox2;
        private Button guna2Button1;
        private Button guna2Button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewButtonColumn Column7;
        private DataGridViewButtonColumn Column8;
    }
}
