﻿namespace FinalProject.UserControls2
{
    partial class UC_Yuklama
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            lblTitle = new Label();
            datagrid_Yuklama = new Guna.UI2.WinForms.Guna2DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            Column4 = new DataGridViewButtonColumn();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            YuklamaGuruhR = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_Yuklama).BeginInit();
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
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(395, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 34);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Yuklamalarni kiritish";
            lblTitle.Click += lblTitle_Click;
            // 
            // datagrid_Yuklama
            // 
            datagrid_Yuklama.AllowUserToAddRows = false;
            datagrid_Yuklama.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            datagrid_Yuklama.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagrid_Yuklama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagrid_Yuklama.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datagrid_Yuklama.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            datagrid_Yuklama.ColumnHeadersHeight = 22;
            datagrid_Yuklama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagrid_Yuklama.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Column1, Column2, Column5, Column6, Column8, Column7, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datagrid_Yuklama.DefaultCellStyle = dataGridViewCellStyle3;
            datagrid_Yuklama.GridColor = Color.FromArgb(224, 224, 224);
            datagrid_Yuklama.Location = new Point(45, 186);
            datagrid_Yuklama.Name = "datagrid_Yuklama";
            datagrid_Yuklama.ReadOnly = true;
            datagrid_Yuklama.RowHeadersVisible = false;
            datagrid_Yuklama.RowHeadersWidth = 51;
            datagrid_Yuklama.RowTemplate.Height = 29;
            datagrid_Yuklama.Size = new Size(984, 257);
            datagrid_Yuklama.TabIndex = 6;
            datagrid_Yuklama.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            datagrid_Yuklama.ThemeStyle.AlternatingRowsStyle.Font = null;
            datagrid_Yuklama.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            datagrid_Yuklama.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            datagrid_Yuklama.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            datagrid_Yuklama.ThemeStyle.BackColor = Color.WhiteSmoke;
            datagrid_Yuklama.ThemeStyle.GridColor = Color.FromArgb(224, 224, 224);
            datagrid_Yuklama.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            datagrid_Yuklama.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid_Yuklama.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datagrid_Yuklama.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            datagrid_Yuklama.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagrid_Yuklama.ThemeStyle.HeaderStyle.Height = 22;
            datagrid_Yuklama.ThemeStyle.ReadOnly = true;
            datagrid_Yuklama.ThemeStyle.RowsStyle.BackColor = Color.White;
            datagrid_Yuklama.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagrid_Yuklama.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datagrid_Yuklama.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            datagrid_Yuklama.ThemeStyle.RowsStyle.Height = 29;
            datagrid_Yuklama.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            datagrid_Yuklama.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagrid_Yuklama.CellContentClick += datagrid_Yuklama_CellContentClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DividerWidth = 1;
            Id.FillWeight = 8F;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 52;
            // 
            // Name
            // 
            Name.DividerWidth = 1;
            Name.FillWeight = 8F;
            Name.HeaderText = "Guruh raqami";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DividerWidth = 1;
            Column1.FillWeight = 8F;
            Column1.HeaderText = "Fan nomi";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DividerWidth = 1;
            Column2.FillWeight = 8F;
            Column2.HeaderText = "O'qituvchi nomi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DividerWidth = 1;
            Column5.FillWeight = 8F;
            Column5.HeaderText = "Mashg'ulot ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DividerWidth = 1;
            Column6.FillWeight = 8F;
            Column6.HeaderText = "Dars soati(1-s)";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.DividerWidth = 1;
            Column8.FillWeight = 8F;
            Column8.HeaderText = "Hafta/dars/s";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DividerWidth = 1;
            Column7.FillWeight = 8F;
            Column7.HeaderText = "Auditoriya";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DividerWidth = 1;
            Column3.FillWeight = 6F;
            Column3.HeaderText = "Update";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            Column3.Text = "✏️";
            Column3.UseColumnTextForButtonValue = true;
            // 
            // Column4
            // 
            Column4.DividerWidth = 1;
            Column4.FillWeight = 6F;
            Column4.HeaderText = "Delete";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Text = "X";
            Column4.UseColumnTextForButtonValue = true;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top;
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(128, 128, 255);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(626, 117);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(74, 38);
            guna2Button1.TabIndex = 9;
            guna2Button1.Text = "search";
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BorderRadius = 5;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Blue;
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(860, 115);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(152, 38);
            guna2Button2.TabIndex = 10;
            guna2Button2.Text = "Yuklama qo'shish";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // YuklamaGuruhR
            // 
            YuklamaGuruhR.Anchor = AnchorStyles.Top;
            YuklamaGuruhR.BackColor = Color.Transparent;
            YuklamaGuruhR.BorderRadius = 8;
            YuklamaGuruhR.CustomizableEdges = customizableEdges5;
            YuklamaGuruhR.DrawMode = DrawMode.OwnerDrawFixed;
            YuklamaGuruhR.DropDownStyle = ComboBoxStyle.DropDownList;
            YuklamaGuruhR.FocusedColor = Color.FromArgb(94, 148, 255);
            YuklamaGuruhR.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            YuklamaGuruhR.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            YuklamaGuruhR.ForeColor = Color.Black;
            YuklamaGuruhR.ItemHeight = 30;
            YuklamaGuruhR.Location = new Point(379, 117);
            YuklamaGuruhR.Name = "YuklamaGuruhR";
            YuklamaGuruhR.ShadowDecoration.CustomizableEdges = customizableEdges6;
            YuklamaGuruhR.Size = new Size(225, 36);
            YuklamaGuruhR.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 94);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 12;
            label1.Text = "Guruh raqamini kiriting";
            // 
            // UC_Yuklama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(YuklamaGuruhR);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(datagrid_Yuklama);
            Controls.Add(panel1);
            Size = new Size(1053, 481);
            Load += UC_Yuklama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_Yuklama).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView datagrid_Yuklama;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column3;
        private DataGridViewButtonColumn Column4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ComboBox YuklamaGuruhR;
        private Label label1;
    }
}
