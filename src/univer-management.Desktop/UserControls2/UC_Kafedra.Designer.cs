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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            lblTitle = new Label();
            datagridView_kafedra = new Guna.UI2.WinForms.Guna2DataGridView();
            Id = new DataGridViewTextBoxColumn();
            kafedra = new DataGridViewTextBoxColumn();
            muttaxasislik = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            Column4 = new DataGridViewButtonColumn();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            kafedratxt_box = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            mutaxasislikCmb = new Guna.UI2.WinForms.Guna2ComboBox();
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
            lblTitle.Size = new Size(343, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Kafedralarni shakllantirish";
            // 
            // datagridView_kafedra
            // 
            datagridView_kafedra.AllowUserToAddRows = false;
            datagridView_kafedra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            datagridView_kafedra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            datagridView_kafedra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            datagridView_kafedra.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            datagridView_kafedra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            datagridView_kafedra.ColumnHeadersHeight = 22;
            datagridView_kafedra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagridView_kafedra.Columns.AddRange(new DataGridViewColumn[] { Id, kafedra, muttaxasislik, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datagridView_kafedra.DefaultCellStyle = dataGridViewCellStyle3;
            datagridView_kafedra.GridColor = Color.LightGray;
            datagridView_kafedra.Location = new Point(31, 204);
            datagridView_kafedra.Name = "datagridView_kafedra";
            datagridView_kafedra.ReadOnly = true;
            datagridView_kafedra.RowHeadersVisible = false;
            datagridView_kafedra.RowHeadersWidth = 51;
            datagridView_kafedra.RowTemplate.Height = 29;
            datagridView_kafedra.Size = new Size(607, 257);
            datagridView_kafedra.TabIndex = 5;
            datagridView_kafedra.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            datagridView_kafedra.ThemeStyle.AlternatingRowsStyle.Font = null;
            datagridView_kafedra.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            datagridView_kafedra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            datagridView_kafedra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            datagridView_kafedra.ThemeStyle.BackColor = Color.WhiteSmoke;
            datagridView_kafedra.ThemeStyle.GridColor = Color.LightGray;
            datagridView_kafedra.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            datagridView_kafedra.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridView_kafedra.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datagridView_kafedra.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            datagridView_kafedra.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            datagridView_kafedra.ThemeStyle.HeaderStyle.Height = 22;
            datagridView_kafedra.ThemeStyle.ReadOnly = true;
            datagridView_kafedra.ThemeStyle.RowsStyle.BackColor = Color.White;
            datagridView_kafedra.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridView_kafedra.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            datagridView_kafedra.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            datagridView_kafedra.ThemeStyle.RowsStyle.Height = 29;
            datagridView_kafedra.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            datagridView_kafedra.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            datagridView_kafedra.CellContentClick += datagridView_kafedra_CellContentClick_1;
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
            // kafedra
            // 
            kafedra.DividerWidth = 1;
            kafedra.FillWeight = 20F;
            kafedra.HeaderText = "Kafedra nomi";
            kafedra.MinimumWidth = 6;
            kafedra.Name = "kafedra";
            kafedra.ReadOnly = true;
            // 
            // muttaxasislik
            // 
            muttaxasislik.DividerWidth = 1;
            muttaxasislik.FillWeight = 15F;
            muttaxasislik.HeaderText = "Muttaxasislik nomi";
            muttaxasislik.MinimumWidth = 6;
            muttaxasislik.Name = "muttaxasislik";
            muttaxasislik.ReadOnly = true;
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
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top;
            guna2TextBox1.BackColor = Color.White;
            guna2TextBox1.BorderColor = Color.White;
            guna2TextBox1.BorderRadius = 20;
            guna2TextBox1.BorderThickness = 0;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = SystemColors.ActiveCaption;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(334, 115);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderForeColor = Color.Black;
            guna2TextBox1.PlaceholderText = "Enter keyword";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(304, 39);
            guna2TextBox1.TabIndex = 6;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top;
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(646, 115);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(74, 39);
            guna2Button1.TabIndex = 7;
            guna2Button1.Text = "search";
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button3.BorderRadius = 20;
            guna2Button3.CustomizableEdges = customizableEdges5;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.FromArgb(255, 128, 0);
            guna2Button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(861, 394);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button3.Size = new Size(122, 39);
            guna2Button3.TabIndex = 16;
            guna2Button3.Text = "Cancel";
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BorderRadius = 20;
            guna2Button2.CustomizableEdges = customizableEdges7;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Blue;
            guna2Button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(703, 394);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button2.Size = new Size(124, 39);
            guna2Button2.TabIndex = 15;
            guna2Button2.Text = "Create";
            guna2Button2.Click += guna2Button2_Click_1;
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.CheckedState.BorderRadius = 0;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.ForeColor = Color.Red;
            guna2CheckBox1.Location = new Point(684, 347);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(215, 24);
            guna2CheckBox1.TabIndex = 14;
            guna2CheckBox1.Text = "Kafedra qo'shishga roziman";
            guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UncheckedState.BorderRadius = 0;
            guna2CheckBox1.UncheckedState.BorderThickness = 0;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // kafedratxt_box
            // 
            kafedratxt_box.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kafedratxt_box.BorderRadius = 10;
            kafedratxt_box.CustomizableEdges = customizableEdges9;
            kafedratxt_box.DefaultText = "";
            kafedratxt_box.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            kafedratxt_box.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            kafedratxt_box.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            kafedratxt_box.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            kafedratxt_box.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            kafedratxt_box.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kafedratxt_box.ForeColor = Color.Black;
            kafedratxt_box.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            kafedratxt_box.Location = new Point(681, 247);
            kafedratxt_box.Name = "kafedratxt_box";
            kafedratxt_box.PasswordChar = '\0';
            kafedratxt_box.PlaceholderForeColor = Color.Gray;
            kafedratxt_box.PlaceholderText = "Kafedra nomini kiriting";
            kafedratxt_box.SelectedText = "";
            kafedratxt_box.ShadowDecoration.CustomizableEdges = customizableEdges10;
            kafedratxt_box.Size = new Size(322, 39);
            kafedratxt_box.TabIndex = 12;
            kafedratxt_box.TextChanged += kafedratxt_box_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(732, 199);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 11;
            label1.Text = "Kafedra yaratish";
            // 
            // mutaxasislikCmb
            // 
            mutaxasislikCmb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mutaxasislikCmb.BackColor = Color.Transparent;
            mutaxasislikCmb.BorderRadius = 10;
            mutaxasislikCmb.CustomizableEdges = customizableEdges11;
            mutaxasislikCmb.DrawMode = DrawMode.OwnerDrawFixed;
            mutaxasislikCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            mutaxasislikCmb.FocusedColor = Color.FromArgb(94, 148, 255);
            mutaxasislikCmb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            mutaxasislikCmb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mutaxasislikCmb.ForeColor = Color.FromArgb(68, 88, 112);
            mutaxasislikCmb.ItemHeight = 30;
            mutaxasislikCmb.Location = new Point(681, 305);
            mutaxasislikCmb.Name = "mutaxasislikCmb";
            mutaxasislikCmb.ShadowDecoration.CustomizableEdges = customizableEdges12;
            mutaxasislikCmb.Size = new Size(322, 36);
            mutaxasislikCmb.TabIndex = 17;
            mutaxasislikCmb.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            mutaxasislikCmb.SelectedIndexChanged += mutaxasislikCmb_SelectedIndexChanged;
            // 
            // UC_Kafedra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(mutaxasislikCmb);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(guna2CheckBox1);
            Controls.Add(kafedratxt_box);
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(guna2TextBox1);
            Controls.Add(datagridView_kafedra);
            Controls.Add(panel1);
            Name = "UC_Kafedra";
            Size = new Size(1040, 481);
            Tag = "kafedra";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridView_kafedra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView datagridView_kafedra;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2TextBox kafedratxt_box;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox mutaxasislikCmb;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn kafedra;
        private DataGridViewTextBoxColumn muttaxasislik;
        private DataGridViewButtonColumn Column3;
        private DataGridViewButtonColumn Column4;
    }
}
