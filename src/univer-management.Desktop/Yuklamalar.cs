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
    }
}
