using FinalProject.UserControls2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using univer_management.Desktop.UserControls2;

namespace univer_management.Desktop
{
    public partial class Royxatlar : Form
    {
        public Royxatlar()
        {
            InitializeComponent();
            UC_Mutaxasislik uC_Muttaxasislik = new UC_Mutaxasislik();
            addUserControl(uC_Muttaxasislik);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer3.Controls.Clear();
            panelContainer3.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Mutaxasislik uC_Muttaxasislik = new UC_Mutaxasislik();
            addUserControl(uC_Muttaxasislik);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			UC_Mutaxasislik uC_Muttaxasislik = new UC_Mutaxasislik();
			addUserControl(uC_Muttaxasislik);
		}

		private void guna2Button2_Click_1(object sender, EventArgs e)
		{
			UC_Kafedra uC_Kafedra = new UC_Kafedra();
			addUserControl(uC_Kafedra);
		}

		private void guna2Button3_Click_1(object sender, EventArgs e)
		{
			UC_Auditoriya uC_Auditoriya = new UC_Auditoriya();
			addUserControl(uC_Auditoriya);
		}

		private void guna2Button4_Click_1(object sender, EventArgs e)
		{
			UC_O_qituvchilar uC_O_Qituvchilar = new UC_O_qituvchilar();
			addUserControl(uC_O_Qituvchilar);
		}

		private void guna2Button5_Click_1(object sender, EventArgs e)
		{
			UC_Guruh uC_Guruh = new UC_Guruh();
			addUserControl(uC_Guruh);
		}

		private void guna2Button6_Click_1(object sender, EventArgs e)
		{
			UC_Fanlar uC_Fanlar = new UC_Fanlar();
			addUserControl(uC_Fanlar);
		}

		private void guna2Button7_Click_1(object sender, EventArgs e)
		{
			UC_Mashg_ulotlar uC_Mashg_ = new UC_Mashg_ulotlar();
			addUserControl(uC_Mashg_);
		}
	}
}
