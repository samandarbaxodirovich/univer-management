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

namespace FinalProject.Forms
{
    public partial class Yuklamalar : Form
    {
        public Yuklamalar()
        {
            InitializeComponent();
            UC_Uquv_reja uC_Uquv_Reja = new UC_Uquv_reja();
            addUserControl(uC_Uquv_Reja);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer2.Controls.Clear();
            panelContainer2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Uquv_reja uC_Uquv_Reja = new UC_Uquv_reja();
            addUserControl(uC_Uquv_Reja);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Yuklama uC_Yuklama = new UC_Yuklama();
            addUserControl(uC_Yuklama);
        }

        private void Yuklamalar_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Oqituvchi_dars_reja uC_Oqituvchi_Dars_Reja = new UC_Oqituvchi_dars_reja();
            addUserControl(uC_Oqituvchi_Dars_Reja);
        }
    }
}
