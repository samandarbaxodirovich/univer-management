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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.guna2Button1 = new System.Windows.Forms.Button();
			this.guna2TextBox1 = new System.Windows.Forms.TextBox();
			this.datagridview1 = new System.Windows.Forms.DataGridView();
			this.guna2Button2 = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
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
			// guna2Button1
			// 
			this.guna2Button1.BackColor = System.Drawing.SystemColors.Control;
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
			this.guna2Button1.Location = new System.Drawing.Point(330, 127);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(43, 32);
			this.guna2Button1.TabIndex = 60;
			this.guna2Button1.UseVisualStyleBackColor = false;
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2TextBox1.Location = new System.Drawing.Point(30, 128);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PlaceholderText = "Qidirish uchun so\'z kiriting";
			this.guna2TextBox1.Size = new System.Drawing.Size(283, 30);
			this.guna2TextBox1.TabIndex = 59;
			// 
			// datagridview1
			// 
			this.datagridview1.AllowUserToAddRows = false;
			this.datagridview1.AllowUserToDeleteRows = false;
			this.datagridview1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			this.datagridview1.Location = new System.Drawing.Point(30, 177);
			this.datagridview1.Name = "datagridview1";
			this.datagridview1.ReadOnly = true;
			this.datagridview1.RowHeadersVisible = false;
			this.datagridview1.RowHeadersWidth = 51;
			this.datagridview1.RowTemplate.Height = 29;
			this.datagridview1.Size = new System.Drawing.Size(981, 266);
			this.datagridview1.TabIndex = 58;
			this.datagridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview1_CellContentClick_1);
			// 
			// guna2Button2
			// 
			this.guna2Button2.BackColor = System.Drawing.Color.Blue;
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Location = new System.Drawing.Point(815, 128);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(196, 43);
			this.guna2Button2.TabIndex = 56;
			this.guna2Button2.Text = "Guruh qo\'shish";
			this.guna2Button2.UseVisualStyleBackColor = false;
			this.guna2Button2.Click += new System.EventHandler(this.button1_Click);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "ID";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Guruh nomi";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "Talabalar soni";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Mutaxassisli";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 125;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Auditoriya";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 125;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Update";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Text = "✏️";
			this.Column6.UseColumnTextForButtonValue = true;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Delete";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Text = "X";
			this.Column7.UseColumnTextForButtonValue = true;
			// 
			// UC_Guruh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(this.guna2TextBox1);
			this.Controls.Add(this.datagridview1);
			this.Controls.Add(this.guna2Button2);
			this.Controls.Add(this.panel1);
			this.Name = "UC_Guruh";
			this.Size = new System.Drawing.Size(1040, 481);
			this.Load += new System.EventHandler(this.UC_Guruh_Load_1);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
