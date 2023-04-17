using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using univer_management.Desktop;
using univer_management.Service.Services;

namespace FinalProject.UserControls2
{
    public partial class UC_Uquv_reja : UserControl
    {
        public UC_Uquv_reja()
        {
            InitializeComponent();
            SetValues();
        }

        MutaxasislikService mService = new();

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
            OquvrejaForm oquvrejaForm = new OquvrejaForm(mService.GetAll()
                .FirstOrDefault(x=>x.Name == guna2ComboBox1.SelectedItem.ToString())
                !.Id,int.Parse(guna2ComboBox2.SelectedItem.ToString()!));
            oquvrejaForm.ShowDialog();
        }

        private void datagrid_Oquv_reja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetValues()
        {
            guna2ComboBox1.DataSource = mService.GetAll().Select(x=>x.Name).ToList();
        }
    }
}
