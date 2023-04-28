using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using univer_management.DataAccess.DbContexts;
using univer_management.DataAccess.Repositories.Common;
using univer_management.Desktop;
using univer_management.Domain.Entities;
using univer_management.Service.Services;

namespace FinalProject.UserControls2
{
    public partial class UC_Yuklama : UserControl
    {
        YuklamaService service = new();
        UnitOfWork work = SingeltonUnitOfWork.Instance;



        public UC_Yuklama()
        {
            InitializeComponent();
            SetValues();
        }




        private void SetValues()
        {
            YuklamaGuruhR.DataSource = work.Guruxlar.GetAll().Select(x=>x.Name).ToList();
            guna2DataGridView1.Rows.Clear();
            var result = service.GetAll().ToList();
            foreach (var item in result)
            {
                guna2DataGridView1.Rows.Add(item.Id.ToString(), item.GuruxNomi, item.FanNomi, item.OqituvchiIsmi, item.Mashgulot, item.Haftalar, item.HaftalarSoatlar, item.AuditoriyaIsmi);
            }
        }




        private void UC_Yuklama_Load_1(object sender, EventArgs e)
        {

        }


		private void guna2Button2_Click_2(object sender, EventArgs e)
		{
			YuklamaForm yuklamaForm = new YuklamaForm();
			yuklamaForm.ShowDialog();
			yuklamaForm.SetValues();
		}

		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			guna2DataGridView1.Rows.Clear();
			var result = service.GetAll().Where(x => x.GuruxNomi == YuklamaGuruhR.SelectedItem.ToString()).ToList();
			foreach (var item in result)
			{
				guna2DataGridView1.Rows.Add(item.Id.ToString(), item.GuruxNomi, item.FanNomi, item.OqituvchiIsmi, item.Mashgulot, item.Haftalar, item.HaftalarSoatlar, item.AuditoriyaIsmi);
			}
		}
	}
}
