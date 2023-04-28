using FinalProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using univer_management.Desktop;
using univer_management.Domain.Entities;

namespace FinalProject
{
    public partial class MainForm : Form
    {

        private Form activeForm;
        private Button currentButton;



        public MainForm()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }



        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    Color color = Color.Black;
                    btnCloseChildForm.Visible = true;
                }
            }
        }




        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childform);
            this.panelDesktopPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitle.Text = childform.Text;
        }






		private void btnRoyxat_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Royxatlar(), sender);
		}

		private void btnDarsJadvali_Click_1(object sender, EventArgs e)
		{
			OpenChildForm(new Dars_RejaForm(), sender);

		}

		private void btnYuklamalar_Click_1(object sender, EventArgs e)
		{
			OpenChildForm(new Yuklamalar(), sender);
		}

		private void btnAlmashtirishlar_Click(object sender, EventArgs e)
		{

		}
	}
}
