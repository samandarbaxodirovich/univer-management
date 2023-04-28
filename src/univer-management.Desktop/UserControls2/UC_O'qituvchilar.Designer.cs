namespace univer_management.Desktop.UserControls2
{
    partial class UC_O_qituvchilar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_O_qituvchilar));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.DataGridVIew_Oqituvchi = new System.Windows.Forms.DataGridView();
			this.kafedraId = new System.Windows.Forms.ComboBox();
			this.gunatextBox = new System.Windows.Forms.TextBox();
			this.gunatextbox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.guna2Button2 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.guna2Button3 = new System.Windows.Forms.Button();
			this.guna2Button1 = new System.Windows.Forms.Button();
			this.guna2TextBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridVIew_Oqituvchi)).BeginInit();
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
			this.panel1.TabIndex = 3;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(320, 23);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(498, 32);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "O\'qituvchilar malumotini shakillantirish";
			// 
			// DataGridVIew_Oqituvchi
			// 
			this.DataGridVIew_Oqituvchi.AllowUserToAddRows = false;
			this.DataGridVIew_Oqituvchi.AllowUserToDeleteRows = false;
			this.DataGridVIew_Oqituvchi.BackgroundColor = System.Drawing.SystemColors.Control;
			this.DataGridVIew_Oqituvchi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridVIew_Oqituvchi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.DataGridVIew_Oqituvchi.Location = new System.Drawing.Point(34, 179);
			this.DataGridVIew_Oqituvchi.Name = "DataGridVIew_Oqituvchi";
			this.DataGridVIew_Oqituvchi.ReadOnly = true;
			this.DataGridVIew_Oqituvchi.RowHeadersVisible = false;
			this.DataGridVIew_Oqituvchi.RowHeadersWidth = 51;
			this.DataGridVIew_Oqituvchi.RowTemplate.Height = 29;
			this.DataGridVIew_Oqituvchi.Size = new System.Drawing.Size(638, 266);
			this.DataGridVIew_Oqituvchi.TabIndex = 58;
			this.DataGridVIew_Oqituvchi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// kafedraId
			// 
			this.kafedraId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.kafedraId.FormattingEnabled = true;
			this.kafedraId.Location = new System.Drawing.Point(710, 308);
			this.kafedraId.Name = "kafedraId";
			this.kafedraId.Size = new System.Drawing.Size(283, 31);
			this.kafedraId.TabIndex = 50;
			// 
			// gunatextBox
			// 
			this.gunatextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gunatextBox.Location = new System.Drawing.Point(710, 198);
			this.gunatextBox.Name = "gunatextBox";
			this.gunatextBox.PlaceholderText = "To\'liq ism sharifini kiriting";
			this.gunatextBox.Size = new System.Drawing.Size(283, 30);
			this.gunatextBox.TabIndex = 51;
			// 
			// gunatextbox2
			// 
			this.gunatextbox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.gunatextbox2.Location = new System.Drawing.Point(710, 250);
			this.gunatextbox2.Name = "gunatextbox2";
			this.gunatextbox2.PlaceholderText = "O\'qituvchi darajasi (raqam)";
			this.gunatextbox2.Size = new System.Drawing.Size(283, 30);
			this.gunatextbox2.TabIndex = 53;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(710, 290);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 15);
			this.label2.TabIndex = 54;
			this.label2.Text = "Kafedrani tanlang";
			// 
			// guna2Button2
			// 
			this.guna2Button2.AutoSize = true;
			this.guna2Button2.ForeColor = System.Drawing.Color.Tomato;
			this.guna2Button2.Location = new System.Drawing.Point(706, 382);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(230, 24);
			this.guna2Button2.TabIndex = 55;
			this.guna2Button2.Text = "Oqituvchi qo\'shishga rozi man";
			this.guna2Button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(710, 416);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 29);
			this.button1.TabIndex = 56;
			this.button1.Text = "create";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// guna2Button3
			// 
			this.guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.Location = new System.Drawing.Point(860, 416);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new System.Drawing.Size(129, 29);
			this.guna2Button3.TabIndex = 57;
			this.guna2Button3.Text = "cancel";
			this.guna2Button3.UseVisualStyleBackColor = false;
			// 
			// guna2Button1
			// 
			this.guna2Button1.BackColor = System.Drawing.SystemColors.Control;
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
			this.guna2Button1.Location = new System.Drawing.Point(334, 129);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(43, 32);
			this.guna2Button1.TabIndex = 60;
			this.guna2Button1.UseVisualStyleBackColor = false;
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2TextBox1.Location = new System.Drawing.Point(34, 130);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PlaceholderText = "Qidirish uchun so\'z kiriting";
			this.guna2TextBox1.Size = new System.Drawing.Size(283, 30);
			this.guna2TextBox1.TabIndex = 59;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.label1.Location = new System.Drawing.Point(744, 144);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 29);
			this.label1.TabIndex = 61;
			this.label1.Text = "O\'qituvchi qo\'shish";
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Id";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 50;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "Full Name";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "O\'qituvchi darajasi";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 170;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Kafedra";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Update";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Text = "✏️";
			this.Column5.UseColumnTextForButtonValue = true;
			this.Column5.Width = 80;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Delete";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Text = "X";
			this.Column6.UseColumnTextForButtonValue = true;
			this.Column6.Width = 80;
			// 
			// UC_O_qituvchilar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(this.guna2TextBox1);
			this.Controls.Add(this.DataGridVIew_Oqituvchi);
			this.Controls.Add(this.guna2Button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.guna2Button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gunatextbox2);
			this.Controls.Add(this.gunatextBox);
			this.Controls.Add(this.kafedraId);
			this.Controls.Add(this.panel1);
			this.Name = "UC_O_qituvchilar";
			this.Size = new System.Drawing.Size(1040, 481);
			this.Load += new System.EventHandler(this.UC_O_qituvchilar_Load_1);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridVIew_Oqituvchi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
		private DataGridView DataGridVIew_Oqituvchi;
		private ComboBox kafedraId;
		private TextBox gunatextBox;
		private TextBox gunatextbox2;
		private Label label2;
		private CheckBox guna2Button2;
		private Button button1;
		private Button guna2Button3;
		private Button guna2Button1;
		private TextBox guna2TextBox1;
		private Label label1;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewButtonColumn Column5;
		private DataGridViewButtonColumn Column6;
	}
}
