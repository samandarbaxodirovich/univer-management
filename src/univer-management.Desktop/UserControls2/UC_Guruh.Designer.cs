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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.datagridview1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.panel1.Controls.Add(this.lblTitle);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1053, 80);
			this.panel1.TabIndex = 4;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(330, 23);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(418, 32);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Guruhlar ro\'yxatini shakllantirish";
			// 
			// datagridview1
			// 
			this.datagridview1.AllowUserToAddRows = false;
			this.datagridview1.AllowUserToDeleteRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.datagridview1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.datagridview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.datagridview1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.datagridview1.ColumnHeadersHeight = 22;
			this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.datagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column4});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagridview1.DefaultCellStyle = dataGridViewCellStyle6;
			this.datagridview1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.datagridview1.Location = new System.Drawing.Point(64, 202);
			this.datagridview1.Name = "datagridview1";
			this.datagridview1.ReadOnly = true;
			this.datagridview1.RowHeadersVisible = false;
			this.datagridview1.RowHeadersWidth = 51;
			this.datagridview1.RowTemplate.Height = 29;
			this.datagridview1.Size = new System.Drawing.Size(752, 257);
			this.datagridview1.TabIndex = 5;
			this.datagridview1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.datagridview1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.datagridview1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.datagridview1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.datagridview1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.datagridview1.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.datagridview1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.datagridview1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.datagridview1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.datagridview1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.datagridview1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.datagridview1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.datagridview1.ThemeStyle.HeaderStyle.Height = 22;
			this.datagridview1.ThemeStyle.ReadOnly = true;
			this.datagridview1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.datagridview1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.datagridview1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.datagridview1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.datagridview1.ThemeStyle.RowsStyle.Height = 29;
			this.datagridview1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.datagridview1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// Id
			// 
			this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Id.DividerWidth = 1;
			this.Id.FillWeight = 8F;
			this.Id.HeaderText = "ID";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Width = 52;
			// 
			// Name
			// 
			this.Name.DividerWidth = 1;
			this.Name.FillWeight = 8F;
			this.Name.HeaderText = "Guruh nomi(raqami)";
			this.Name.MinimumWidth = 6;
			this.Name.Name = "Name";
			this.Name.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.DividerWidth = 1;
			this.Column1.FillWeight = 8F;
			this.Column1.HeaderText = "Smena";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DividerWidth = 1;
			this.Column2.FillWeight = 8F;
			this.Column2.HeaderText = "Talaba Soni";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DividerWidth = 1;
			this.Column5.FillWeight = 8F;
			this.Column5.HeaderText = "Smestr raqami";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.DividerWidth = 1;
			this.Column6.FillWeight = 8F;
			this.Column6.HeaderText = "Muttaxasislik";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.DividerWidth = 1;
			this.Column7.FillWeight = 8F;
			this.Column7.HeaderText = "Auditoriya";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DividerWidth = 1;
			this.Column3.FillWeight = 6F;
			this.Column3.HeaderText = "Update";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column3.Text = "✏️";
			this.Column3.UseColumnTextForButtonValue = true;
			// 
			// Column4
			// 
			this.Column4.DividerWidth = 1;
			this.Column4.FillWeight = 6F;
			this.Column4.HeaderText = "Delete";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Text = "X";
			this.Column4.UseColumnTextForButtonValue = true;
			// 
			// guna2Button1
			// 
			this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.guna2Button1.BorderRadius = 20;
			this.guna2Button1.CustomizableEdges = customizableEdges7;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Location = new System.Drawing.Point(683, 118);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
			this.guna2Button1.Size = new System.Drawing.Size(74, 38);
			this.guna2Button1.TabIndex = 7;
			this.guna2Button1.Text = "search";
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.guna2TextBox1.BackColor = System.Drawing.Color.White;
			this.guna2TextBox1.BorderColor = System.Drawing.Color.White;
			this.guna2TextBox1.BorderRadius = 20;
			this.guna2TextBox1.BorderThickness = 0;
			this.guna2TextBox1.CustomizableEdges = customizableEdges9;
			this.guna2TextBox1.DefaultText = "";
			this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.FillColor = System.Drawing.SystemColors.ActiveCaption;
			this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
			this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.Location = new System.Drawing.Point(330, 117);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
			this.guna2TextBox1.PlaceholderText = "Enter keyword";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
			this.guna2TextBox1.Size = new System.Drawing.Size(332, 39);
			this.guna2TextBox1.TabIndex = 6;
			// 
			// guna2Button2
			// 
			this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2Button2.BorderRadius = 20;
			this.guna2Button2.CustomizableEdges = customizableEdges11;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button2.FillColor = System.Drawing.Color.Blue;
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Location = new System.Drawing.Point(861, 390);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges12;
			this.guna2Button2.Size = new System.Drawing.Size(139, 50);
			this.guna2Button2.TabIndex = 10;
			this.guna2Button2.Text = "Guruh qo\'shish";
			this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
			// 
			// UC_Guruh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.guna2Button2);
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(this.guna2TextBox1);
			this.Controls.Add(this.datagridview1);
			this.Controls.Add(this.panel1);
			this.Size = new System.Drawing.Size(1040, 481);
			this.Load += new System.EventHandler(this.UC_Guruh_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewButtonColumn Column3;
        private DataGridViewButtonColumn Column4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
