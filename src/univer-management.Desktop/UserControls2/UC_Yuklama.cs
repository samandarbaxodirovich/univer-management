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
using univer_management.Domain.Entities;
using univer_management.Service.Services;

namespace FinalProject.UserControls2
{
    public partial class UC_Yuklama : UserControl
    {
        YuklamaService service = new();
        public UC_Yuklama()
        {
            InitializeComponent();
            SetValues();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            YuklamaForm yuklamaForm = new YuklamaForm();
            yuklamaForm.ShowDialog();
        }

        private void datagrid_Yuklama_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Yuklama_Load(object sender, EventArgs e)
        {

        }
        private void SetValues()
        {
            datagrid_Yuklama.Columns.Clear();
            var result = service.GetAll();
            foreach(var item in result)
            {
                datagrid_Yuklama.Rows.Add(item.Id,item.GuruxNomi,item.FanNomi,item.OqituvchiIsmi,item.Mashgulot,item.Haftalar,item.HaftalarSoatlar,item.AuditoriyaIsmi);
            }
        }
    }
}
