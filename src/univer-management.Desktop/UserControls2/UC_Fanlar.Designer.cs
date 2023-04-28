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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.guna2Button1 = new System.Windows.Forms.Button();
			this.guna2TextBox1 = new System.Windows.Forms.TextBox();
			this.guna2DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.guna2Button3 = new System.Windows.Forms.Button();
			this.guna2Button2 = new System.Windows.Forms.Button();
			this.guna2CheckBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2TextBox2 = new System.Windows.Forms.TextBox();
			this.guna2ComboBox2 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.guna2ComboBox1 = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
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
			this.lblTitle.Location = new System.Drawing.Point(365, 22);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(292, 32);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Fanlarni shakllantirish";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label2.Location = new System.Drawing.Point(761, 132);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 32);
			this.label2.TabIndex = 18;
			this.label2.Text = "Fan qo\'shish";
			// 
			// guna2Button1
			// 
			this.guna2Button1.BackColor = System.Drawing.SystemColors.Control;
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
			this.guna2Button1.Location = new System.Drawing.Point(343, 131);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(43, 32);
			this.guna2Button1.TabIndex = 60;
			this.guna2Button1.UseVisualStyleBackColor = false;
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2TextBox1.Location = new System.Drawing.Point(43, 132);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PlaceholderText = "Qidirish uchun so\'z kiriting";
			this.guna2TextBox1.Size = new System.Drawing.Size(283, 30);
			this.guna2TextBox1.TabIndex = 59;
			// 
			// guna2DataGridView1
			// 
			this.guna2DataGridView1.AllowUserToAddRows = false;
			this.guna2DataGridView1.AllowUserToDeleteRows = false;
			this.guna2DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.guna2DataGridView1.Location = new System.Drawing.Point(43, 181);
			this.guna2DataGridView1.Name = "guna2DataGridView1";
			this.guna2DataGridView1.ReadOnly = true;
			this.guna2DataGridView1.RowHeadersVisible = false;
			this.guna2DataGridView1.RowHeadersWidth = 51;
			this.guna2DataGridView1.RowTemplate.Height = 29;
			this.guna2DataGridView1.Size = new System.Drawing.Size(638, 266);
			this.guna2DataGridView1.TabIndex = 58;
			this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick_1);
			// 
			// Id
			// 
			this.Id.HeaderText = "ID";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Width = 50;
			// 
			// name
			// 
			this.name.HeaderText = "Fan ";
			this.name.MinimumWidth = 6;
			this.name.Name = "name";
			this.name.ReadOnly = true;
			this.name.Width = 125;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Fan qiyinchiligi";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 140;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "Kafedra nomi";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Update";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Text = "✏️";
			this.Column3.UseColumnTextForButtonValue = true;
			this.Column3.Width = 80;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Delete";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Text = "X";
			this.Column4.UseColumnTextForButtonValue = true;
			this.Column4.Width = 80;
			// 
			// guna2Button3
			// 
			this.guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.Location = new System.Drawing.Point(869, 418);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new System.Drawing.Size(129, 29);
			this.guna2Button3.TabIndex = 57;
			this.guna2Button3.Text = "cancel";
			this.guna2Button3.UseVisualStyleBackColor = false;
			// 
			// guna2Button2
			// 
			this.guna2Button2.BackColor = System.Drawing.Color.Blue;
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Location = new System.Drawing.Point(719, 418);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(129, 29);
			this.guna2Button2.TabIndex = 56;
			this.guna2Button2.Text = "create";
			this.guna2Button2.UseVisualStyleBackColor = false;
			this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
			// 
			// guna2CheckBox1
			// 
			this.guna2CheckBox1.AutoSize = true;
			this.guna2CheckBox1.ForeColor = System.Drawing.Color.Tomato;
			this.guna2CheckBox1.Location = new System.Drawing.Point(715, 360);
			this.guna2CheckBox1.Name = "guna2CheckBox1";
			this.guna2CheckBox1.Size = new System.Drawing.Size(185, 24);
			this.guna2CheckBox1.TabIndex = 55;
			this.guna2CheckBox1.Text = "Fan qo\'shishga roziman";
			this.guna2CheckBox1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(715, 228);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 15);
			this.label1.TabIndex = 54;
			this.label1.Text = "Fan qiyinchiligini kiriting ";
			// 
			// guna2TextBox2
			// 
			this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2TextBox2.Location = new System.Drawing.Point(715, 181);
			this.guna2TextBox2.Name = "guna2TextBox2";
			this.guna2TextBox2.PlaceholderText = "Fan nomi";
			this.guna2TextBox2.Size = new System.Drawing.Size(283, 30);
			this.guna2TextBox2.TabIndex = 52;
			// 
			// guna2ComboBox2
			// 
			this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2ComboBox2.FormattingEnabled = true;
			this.guna2ComboBox2.Location = new System.Drawing.Point(715, 246);
			this.guna2ComboBox2.Name = "guna2ComboBox2";
			this.guna2ComboBox2.Size = new System.Drawing.Size(283, 31);
			this.guna2ComboBox2.TabIndex = 50;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(715, 291);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 15);
			this.label3.TabIndex = 62;
			this.label3.Text = "Kafedrani kiriting";
			// 
			// guna2ComboBox1
			// 
			this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.guna2ComboBox1.FormattingEnabled = true;
			this.guna2ComboBox1.Location = new System.Drawing.Point(715, 309);
			this.guna2ComboBox1.Name = "guna2ComboBox1";
			this.guna2ComboBox1.Size = new System.Drawing.Size(283, 31);
			this.guna2ComboBox1.TabIndex = 61;
			// 
			// UC_Fanlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.guna2ComboBox1);
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(this.guna2TextBox1);
			this.Controls.Add(this.guna2DataGridView1);
			this.Controls.Add(this.guna2Button3);
			this.Controls.Add(this.guna2Button2);
			this.Controls.Add(this.guna2CheckBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2TextBox2);
			this.Controls.Add(this.guna2ComboBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Name = "UC_Fanlar";
			this.Size = new System.Drawing.Size(1040, 481);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
