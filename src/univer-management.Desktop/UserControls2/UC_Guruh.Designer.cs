﻿namespace univer_management.Desktop.UserControls2
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
			this.button3 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
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
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Control;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(330, 127);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(43, 32);
			this.button3.TabIndex = 60;
			this.button3.UseVisualStyleBackColor = false;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBox4.Location = new System.Drawing.Point(30, 128);
			this.textBox4.Name = "textBox4";
			this.textBox4.PlaceholderText = "Qidirish uchun so\'z kiriting";
			this.textBox4.Size = new System.Drawing.Size(283, 30);
			this.textBox4.TabIndex = 59;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(30, 177);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(981, 266);
			this.dataGridView1.TabIndex = 58;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(815, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(196, 31);
			this.button1.TabIndex = 56;
			this.button1.Text = "Guruh qo\'shish";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// UC_Guruh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Name = "UC_Guruh";
			this.Size = new System.Drawing.Size(1040, 481);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
		private Button button3;
		private TextBox textBox4;
		private DataGridView dataGridView1;
		private Button button1;
	}
}
