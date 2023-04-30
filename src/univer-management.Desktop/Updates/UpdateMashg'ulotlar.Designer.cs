namespace univer_management.Desktop.Updates
{
    partial class UpdateMashg_ulotlar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gunatextBox = new TextBox();
            label1 = new Label();
            guna2Button2 = new Button();
            SuspendLayout();
            // 
            // gunatextBox
            // 
            gunatextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gunatextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gunatextBox.Location = new Point(22, 84);
            gunatextBox.Name = "gunatextBox";
            gunatextBox.PlaceholderText = "Mashg'ulotni kiriting";
            gunatextBox.Size = new Size(283, 30);
            gunatextBox.TabIndex = 54;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(62, 27);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(203, 29);
            label1.TabIndex = 62;
            label1.Text = "Mashg'ulot kiritish";
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button2.BackColor = Color.Blue;
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(62, 141);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(203, 48);
            guna2Button2.TabIndex = 63;
            guna2Button2.Text = "qo'shish";
            guna2Button2.UseVisualStyleBackColor = false;
            guna2Button2.Click += guna2Button2_Click;
            // 
            // UpdateMashg_ulotlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 237);
            Controls.Add(guna2Button2);
            Controls.Add(label1);
            Controls.Add(gunatextBox);
            Name = "UpdateMashg_ulotlar";
            Text = "UpdateMashg_ulotlar";
            Load += UpdateMashg_ulotlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox gunatextBox;
        private Label label1;
        private Button guna2Button2;
    }
}