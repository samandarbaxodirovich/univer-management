namespace univer_management.Desktop.UserControls2
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
            panel1 = new Panel();
            lblTitle = new Label();
            label1 = new Label();
            button3 = new Button();
            textBox4 = new TextBox();
            dataGridView11 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Mutaxassisliknomi = new DataGridViewTextBoxColumn();
            Update = new DataGridViewButtonColumn();
            Column4 = new DataGridViewButtonColumn();
            button2 = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView11).BeginInit();
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
            panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(359, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(413, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Mutaxassisliklarni shakllantirish";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(694, 150);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(318, 32);
            label1.TabIndex = 5;
            label1.Text = "Mutaxassislikni qo'shish";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(331, 134);
            button3.Name = "button3";
            button3.Size = new Size(43, 32);
            button3.TabIndex = 71;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(31, 135);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Qidirish uchun so'z kiriting";
            textBox4.Size = new Size(283, 30);
            textBox4.TabIndex = 70;
            // 
            // dataGridView11
            // 
            dataGridView11.AllowUserToAddRows = false;
            dataGridView11.AllowUserToDeleteRows = false;
            dataGridView11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView11.BackgroundColor = SystemColors.Control;
            dataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView11.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Mutaxassisliknomi, Update, Column4 });
            dataGridView11.Location = new Point(31, 184);
            dataGridView11.Name = "dataGridView11";
            dataGridView11.ReadOnly = true;
            dataGridView11.RowHeadersVisible = false;
            dataGridView11.RowHeadersWidth = 51;
            dataGridView11.RowTemplate.Height = 29;
            dataGridView11.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView11.Size = new Size(638, 266);
            dataGridView11.TabIndex = 69;
            dataGridView11.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // Mutaxassisliknomi
            // 
            Mutaxassisliknomi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Mutaxassisliknomi.HeaderText = "Mutaxassislik nomiv";
            Mutaxassisliknomi.MinimumWidth = 6;
            Mutaxassisliknomi.Name = "Mutaxassisliknomi";
            Mutaxassisliknomi.ReadOnly = true;
            // 
            // Update
            // 
            Update.HeaderText = "O'zgartirish";
            Update.MinimumWidth = 6;
            Update.Name = "Update";
            Update.ReadOnly = true;
            Update.SortMode = DataGridViewColumnSortMode.Automatic;
            Update.Text = "✏️";
            Update.UseColumnTextForButtonValue = true;
            Update.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "O'chirish";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Text = "X";
            Column4.UseColumnTextForButtonValue = true;
            Column4.Width = 125;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.ForeColor = Color.White;
            button2.Location = new Point(857, 421);
            button2.Name = "button2";
            button2.Size = new Size(129, 29);
            button2.TabIndex = 68;
            button2.Text = "toshalash";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(707, 421);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 67;
            button1.Text = "qo'shish";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Tomato;
            checkBox1.Location = new Point(707, 307);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(248, 24);
            checkBox1.TabIndex = 66;
            checkBox1.Text = "Mutahasislik qo'shishga rozi man";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(707, 255);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Mutaxassislik qisqacha nomini kiriting";
            textBox3.Size = new Size(283, 30);
            textBox3.TabIndex = 64;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(707, 203);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Mutaxassislik nomini kiriting";
            textBox2.Size = new Size(283, 30);
            textBox2.TabIndex = 63;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // UC_Mutaxasislik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(dataGridView11);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UC_Mutaxasislik";
            Size = new Size(1040, 481);
            Tag = "Mutahasislik";
            Load += UC_Mutaxasislik_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Label label1;
        private Button button3;
        private TextBox textBox4;
        private DataGridView dataGridView11;
        private Button button2;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Mutaxassisliknomi;
        private DataGridViewButtonColumn Update;
        private DataGridViewButtonColumn Column4;
    }
}
