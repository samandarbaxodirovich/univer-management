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
        OquvRejaService oquvRejaService = new();






        private void SetValues()
        {
            guna2ComboBox1.DataSource = mService.GetAll().Select(x => x.Name).ToList();
        }




        private void SetTable()
        {
            datagrid_Oquv_reja.Rows.Clear();
            var oquvRejalar = oquvRejaService.GetAll(mService.GetByKeyword(guna2ComboBox1.SelectedItem.ToString()).First().Id
                , int.Parse(guna2ComboBox2.SelectedItem.ToString()!));
            foreach (var item in oquvRejalar)
            {
                datagrid_Oquv_reja.Rows.Add(item.Id, item.FanName, item.Lektsiya, item.Seminar, item.OraliqImtihon, item.MustaqilTalim);
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedItem == null)
            {
                MessageBox.Show("Iltimos semestr raqamini kiriting");
                return;
            }
            OquvrejaForm oquvrejaForm = new OquvrejaForm(mService.GetAll()
                .FirstOrDefault(x => x.Name == guna2ComboBox1.SelectedItem.ToString())
                !.Id, int.Parse(guna2ComboBox2.SelectedItem.ToString()!));
            oquvrejaForm.ShowDialog();
            SetTable();

        }


        //update delete yozilmagan ekan
        private void datagrid_Oquv_reja_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            SetTable();
        }
    }
}
