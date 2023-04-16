using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using univer_management.Service.Services;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_Guruh : UserControl
    {

		GuruxService _service;
		public static UC_Guruh Instance;
        public UC_Guruh()
        {
			Instance = this;
			_service= new GuruxService();
            InitializeComponent();
        }

		private void guna2Button2_Click_1(object sender, EventArgs e)
		{
			AddGuruhForm addGuruhForm = new AddGuruhForm();
			addGuruhForm.ShowDialog();
		}

		private void UC_Guruh_Load(object sender, EventArgs e)
		{
			SetValues();
		}



		public async void SetValues()
		{
			datagridview1.Controls.Clear();

			var targets = await _service.GetAll();

			if(targets != null)
			{
				foreach (var item in targets)
				{
					datagridview1.Rows.Add(item.Id, item.Name, item.Smena, item.Capacity, item.Semestr, item.Mutaxasislik.Name, item.Auditoriya.NumberOfOrder);
				}
			}
		}
	}
}
