namespace FinalProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            btnAlmashtirishlar = new Button();
            btnDarsJadvali = new Button();
            btnYuklamalar = new Button();
            btnRoyxat = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPanel = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnAlmashtirishlar);
            panelMenu.Controls.Add(btnDarsJadvali);
            panelMenu.Controls.Add(btnYuklamalar);
            panelMenu.Controls.Add(btnRoyxat);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(263, 953);
            panelMenu.TabIndex = 0;
            // 
            // btnAlmashtirishlar
            // 
            btnAlmashtirishlar.Dock = DockStyle.Top;
            btnAlmashtirishlar.FlatAppearance.BorderSize = 0;
            btnAlmashtirishlar.FlatStyle = FlatStyle.Flat;
            btnAlmashtirishlar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlmashtirishlar.ForeColor = Color.Gainsboro;
            btnAlmashtirishlar.Image = (Image)resources.GetObject("btnAlmashtirishlar.Image");
            btnAlmashtirishlar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlmashtirishlar.Location = new Point(0, 296);
            btnAlmashtirishlar.Name = "btnAlmashtirishlar";
            btnAlmashtirishlar.Padding = new Padding(12, 0, 0, 0);
            btnAlmashtirishlar.Size = new Size(263, 72);
            btnAlmashtirishlar.TabIndex = 4;
            btnAlmashtirishlar.Text = "   Almashtirishlar";
            btnAlmashtirishlar.TextAlign = ContentAlignment.MiddleLeft;
            btnAlmashtirishlar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlmashtirishlar.UseVisualStyleBackColor = true;
            btnAlmashtirishlar.Click += btnAlmashtirishlar_Click;
            // 
            // btnDarsJadvali
            // 
            btnDarsJadvali.Dock = DockStyle.Top;
            btnDarsJadvali.FlatAppearance.BorderSize = 0;
            btnDarsJadvali.FlatStyle = FlatStyle.Flat;
            btnDarsJadvali.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDarsJadvali.ForeColor = Color.Gainsboro;
            btnDarsJadvali.Image = (Image)resources.GetObject("btnDarsJadvali.Image");
            btnDarsJadvali.ImageAlign = ContentAlignment.MiddleLeft;
            btnDarsJadvali.Location = new Point(0, 224);
            btnDarsJadvali.Name = "btnDarsJadvali";
            btnDarsJadvali.Padding = new Padding(12, 0, 0, 0);
            btnDarsJadvali.Size = new Size(263, 72);
            btnDarsJadvali.TabIndex = 3;
            btnDarsJadvali.Text = "   Dars jadvali";
            btnDarsJadvali.TextAlign = ContentAlignment.MiddleLeft;
            btnDarsJadvali.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDarsJadvali.UseVisualStyleBackColor = true;
            btnDarsJadvali.Click += btnDarsJadvali_Click;
            // 
            // btnYuklamalar
            // 
            btnYuklamalar.Dock = DockStyle.Top;
            btnYuklamalar.FlatAppearance.BorderSize = 0;
            btnYuklamalar.FlatStyle = FlatStyle.Flat;
            btnYuklamalar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnYuklamalar.ForeColor = Color.Gainsboro;
            btnYuklamalar.Image = (Image)resources.GetObject("btnYuklamalar.Image");
            btnYuklamalar.ImageAlign = ContentAlignment.MiddleLeft;
            btnYuklamalar.Location = new Point(0, 152);
            btnYuklamalar.Name = "btnYuklamalar";
            btnYuklamalar.Padding = new Padding(12, 0, 0, 0);
            btnYuklamalar.Size = new Size(263, 72);
            btnYuklamalar.TabIndex = 2;
            btnYuklamalar.Text = "   Yuklamalar";
            btnYuklamalar.TextAlign = ContentAlignment.MiddleLeft;
            btnYuklamalar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnYuklamalar.UseVisualStyleBackColor = true;
            btnYuklamalar.Click += btnYuklamalar_Click;
            // 
            // btnRoyxat
            // 
            btnRoyxat.Dock = DockStyle.Top;
            btnRoyxat.FlatAppearance.BorderSize = 0;
            btnRoyxat.FlatStyle = FlatStyle.Flat;
            btnRoyxat.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRoyxat.ForeColor = Color.Gainsboro;
            btnRoyxat.Image = (Image)resources.GetObject("btnRoyxat.Image");
            btnRoyxat.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoyxat.Location = new Point(0, 80);
            btnRoyxat.Name = "btnRoyxat";
            btnRoyxat.Padding = new Padding(12, 0, 0, 0);
            btnRoyxat.Size = new Size(263, 72);
            btnRoyxat.TabIndex = 1;
            btnRoyxat.Text = "   Ro'yxatlar";
            btnRoyxat.TextAlign = ContentAlignment.MiddleLeft;
            btnRoyxat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoyxat.UseVisualStyleBackColor = true;
            //btnRoyxat.Click += btnRoyxat_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(263, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(209, 23);
            label1.TabIndex = 0;
            label1.Text = "Scheduling machine";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(263, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(762, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(47, 80);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(348, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(98, 34);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(263, 80);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(762, 873);
            panelDesktopPanel.TabIndex = 2;
            panelDesktopPanel.Paint += panelDesktopPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1032, 953);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "  ";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnAlmashtirishlar;
        private Button btnDarsJadvali;
        private Button btnYuklamalar;
        private Button btnRoyxat;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPanel;
        private Button btnCloseChildForm;
    }
}