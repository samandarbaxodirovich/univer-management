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
    public partial class Dars_RejaForm : Form
    {



        public Dars_RejaForm()
        {
            InitializeComponent();
            UC_Dars_Reja dars_Reja = new UC_Dars_Reja();
            addUserControl(dars_Reja);
        }



        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer11.Controls.Clear();
            panelContainer11.Controls.Add(userControl);
            userControl.BringToFront();
        }



		private void guna2Button11_Click_1(object sender, EventArgs e)
		{
			UC_Dars_Reja dars_Reja = new UC_Dars_Reja(); addUserControl(dars_Reja);

		}

		private void guna2Button33_Click_1(object sender, EventArgs e)
		{
			UC_Oqituvchi_dars_reja dars_Reja1 = new UC_Oqituvchi_dars_reja();
			addUserControl(dars_Reja1);
		}
	}
}
