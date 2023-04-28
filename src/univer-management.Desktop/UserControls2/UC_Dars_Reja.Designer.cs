namespace univer_management.Desktop.UserControls2
{
    partial class UC_Dars_Reja
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
            panel1 = new Panel();
            lblTitle = new Label();
            DataGridViewDars = new DataGridView();
            guna2Button1 = new Button();
            guna2Button5 = new Button();
            guna2Button2 = new Button();
            guna2Button3 = new Button();
            guna2Button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewDars).BeginInit();
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
            panel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(431, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Dars Rejasi";
            // 
            // DataGridViewDars
            // 
            DataGridViewDars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewDars.BackgroundColor = SystemColors.Control;
            DataGridViewDars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewDars.Location = new Point(249, 123);
            DataGridViewDars.Name = "DataGridViewDars";
            DataGridViewDars.RowHeadersVisible = false;
            DataGridViewDars.RowHeadersWidth = 51;
            DataGridViewDars.RowTemplate.Height = 29;
            DataGridViewDars.Size = new Size(755, 324);
            DataGridViewDars.TabIndex = 59;
            DataGridViewDars.CellMouseClick += DataGridViewDars_CellMouseClick_1;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Blue;
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(21, 123);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(205, 45);
            guna2Button1.TabIndex = 60;
            guna2Button1.Text = "1 Dars";
            guna2Button1.UseVisualStyleBackColor = false;
            guna2Button1.Click += guna2Button1_Click_2;
            // 
            // guna2Button5
            // 
            guna2Button5.BackColor = Color.Blue;
            guna2Button5.ForeColor = Color.White;
            guna2Button5.Location = new Point(21, 328);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.Size = new Size(205, 45);
            guna2Button5.TabIndex = 61;
            guna2Button5.Text = "5 Dars";
            guna2Button5.UseVisualStyleBackColor = false;
            guna2Button5.Click += guna2Button5_Click_1;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Blue;
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(21, 277);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(205, 45);
            guna2Button2.TabIndex = 62;
            guna2Button2.Text = "4 Dars";
            guna2Button2.UseVisualStyleBackColor = false;
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button3
            // 
            guna2Button3.BackColor = Color.Blue;
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(21, 226);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.Size = new Size(205, 45);
            guna2Button3.TabIndex = 63;
            guna2Button3.Text = "3 Dars";
            guna2Button3.UseVisualStyleBackColor = false;
            guna2Button3.Click += guna2Button3_Click;
            // 
            // guna2Button4
            // 
            guna2Button4.BackColor = Color.Blue;
            guna2Button4.ForeColor = Color.White;
            guna2Button4.Location = new Point(21, 174);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.Size = new Size(205, 45);
            guna2Button4.TabIndex = 64;
            guna2Button4.Text = "2 Dars";
            guna2Button4.UseVisualStyleBackColor = false;
            guna2Button4.Click += guna2Button4_Click;
            // 
            // UC_Dars_Reja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Button4);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button5);
            Controls.Add(guna2Button1);
            Controls.Add(DataGridViewDars);
            Controls.Add(panel1);
            Name = "UC_Dars_Reja";
            Size = new Size(1040, 481);
            Load += UC_Dars_Reja_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewDars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private DataGridView DataGridViewDars;
        private Button guna2Button1;
        private Button guna2Button5;
        private Button guna2Button2;
        private Button guna2Button3;
        private Button guna2Button4;
    }
}
