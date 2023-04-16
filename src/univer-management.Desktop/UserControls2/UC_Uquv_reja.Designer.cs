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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblTitle = new Label();
            datagrid_Oquv_reja = new Guna.UI2.WinForms.Guna2DataGridView();
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
            lblTitle.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(381, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(271, 34);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "O'quv rejani kiritish";
            // 
            // datagrid_Oquv_reja
            // 
            datagrid_Oquv_reja.AllowUserToAddRows = false;
            datagrid_Oquv_reja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            datagrid_Oquv_reja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagrid_Oquv_reja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagrid_Oquv_reja.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datagrid_Oquv_reja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            datagrid_Oquv_reja.ColumnHeadersHeight = 22;
            datagrid_Oquv_reja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagrid_Oquv_reja.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Column1, Column2, Column5, Column6, Column8, Column7, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datagrid_Oquv_reja.DefaultCellStyle = dataGridViewCellStyle3;
            datagrid_Oquv_reja.GridColor = Color.FromArgb(224, 224, 224);
            datagrid_Oquv_reja.Location = new Point(37, 165);
            datagrid_Oquv_reja.Name = "datagrid_Oquv_reja";
            datagrid_Oquv_reja.ReadOnly = true;
            datagrid_Oquv_reja.RowHeadersVisible = false;
            datagrid_Oquv_reja.RowHeadersWidth = 51;
            datagrid_Oquv_reja.RowTemplate.Height = 29;
            datagrid_Oquv_reja.Size = new Size(966, 257);
            datagrid_Oquv_reja.TabIndex = 7;
            datagrid_Oquv_reja.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            datagrid_Oquv_reja.ThemeStyle.AlternatingRowsStyle.Font = null;
            datagrid_Oquv_reja.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            datagrid_Oquv_reja.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            datagrid_Oquv_reja.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            datagrid_Oquv_reja.ThemeStyle.BackColor = Color.WhiteSmoke;
            datagrid_Oquv_reja.ThemeStyle.GridColor = Color.FromArgb(224, 224, 224);
            datagrid_Oquv_reja.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            datagrid_Oquv_reja.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            datagrid_Oquv_reja.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datagrid_Oquv_reja.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            datagrid_Oquv_reja.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagrid_Oquv_reja.ThemeStyle.HeaderStyle.Height = 22;
            datagrid_Oquv_reja.ThemeStyle.ReadOnly = true;
            datagrid_Oquv_reja.ThemeStyle.RowsStyle.BackColor = Color.White;
            datagrid_Oquv_reja.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagrid_Oquv_reja.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datagrid_Oquv_reja.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            datagrid_Oquv_reja.ThemeStyle.RowsStyle.Height = 29;
            datagrid_Oquv_reja.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            datagrid_Oquv_reja.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            // UC_Uquv_reja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(datagrid_Oquv_reja);
            Controls.Add(panel1);
            Name = "UC_Uquv_reja";
            Size = new Size(1040, 481);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_Oquv_reja).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView datagrid_Oquv_reja;
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
    }
}
