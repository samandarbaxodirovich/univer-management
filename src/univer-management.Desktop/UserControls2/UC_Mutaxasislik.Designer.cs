﻿namespace univer_management.Desktop.UserControls2
{
    partial class UC_Mutaxasislik
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Mutaxasislik));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mutaxassisliknomi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.panel1.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(359, 23);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(413, 32);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Mutaxassisliklarni shakllantirish";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.label1.Location = new System.Drawing.Point(694, 150);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(318, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Mutaxassislikni qo\'shish";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Control;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(331, 134);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(43, 32);
			this.button3.TabIndex = 71;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox4.Location = new System.Drawing.Point(31, 135);
			this.textBox4.Name = "textBox4";
			this.textBox4.PlaceholderText = "Qidirish uchun so\'z kiriting";
			this.textBox4.Size = new System.Drawing.Size(283, 30);
			this.textBox4.TabIndex = 70;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Mutaxassisliknomi,
            this.Update,
            this.Delete});
			this.dataGridView1.Location = new System.Drawing.Point(31, 184);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(638, 266);
			this.dataGridView1.TabIndex = 69;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(857, 421);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(129, 29);
			this.button2.TabIndex = 68;
			this.button2.Text = "cancel";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(707, 421);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 29);
			this.button1.TabIndex = 67;
			this.button1.Text = "create";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = System.Drawing.Color.Tomato;
			this.checkBox1.Location = new System.Drawing.Point(707, 307);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(248, 24);
			this.checkBox1.TabIndex = 66;
			this.checkBox1.Text = "Mutahasislik qo\'shishga rozi man";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox3.Location = new System.Drawing.Point(707, 255);
			this.textBox3.Name = "textBox3";
			this.textBox3.PlaceholderText = "Mutaxassislik qisqacha nomini kiriting";
			this.textBox3.Size = new System.Drawing.Size(283, 30);
			this.textBox3.TabIndex = 64;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox2.Location = new System.Drawing.Point(707, 203);
			this.textBox2.Name = "textBox2";
			this.textBox2.PlaceholderText = "Mutaxassislik nomini kiriting";
			this.textBox2.Size = new System.Drawing.Size(283, 30);
			this.textBox2.TabIndex = 63;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.Width = 125;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 50;
			// 
			// Mutaxassisliknomi
			// 
			this.Mutaxassisliknomi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Mutaxassisliknomi.HeaderText = "Mutaxassislik nomiv";
			this.Mutaxassisliknomi.MinimumWidth = 6;
			this.Mutaxassisliknomi.Name = "Mutaxassisliknomi";
			this.Mutaxassisliknomi.ReadOnly = true;
			// 
			// Update
			// 
			this.Update.HeaderText = "Update";
			this.Update.MinimumWidth = 6;
			this.Update.Name = "Update";
			this.Update.ReadOnly = true;
			this.Update.Text = "✏️";
			this.Update.UseColumnTextForButtonValue = true;
			// 
			// Delete
			// 
			this.Delete.HeaderText = "Delete";
			this.Delete.MinimumWidth = 6;
			this.Delete.Name = "Delete";
			this.Delete.ReadOnly = true;
			this.Delete.Text = "X";
			this.Delete.UseColumnTextForButtonValue = true;
			// 
			// UC_Mutaxasislik
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "UC_Mutaxasislik";
			this.Size = new System.Drawing.Size(1040, 481);
			this.Tag = "Mutahasislik";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label label1;
		private Button button3;
		private TextBox textBox4;
		private DataGridView dataGridView1;
		private Button button2;
		private Button button1;
		private CheckBox checkBox1;
		private TextBox textBox3;
		private TextBox textBox2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn Mutaxassisliknomi;
		private DataGridViewButtonColumn Update;
		private DataGridViewButtonColumn Delete;
		private DataGridViewTextBoxColumn ID;
	}
}
