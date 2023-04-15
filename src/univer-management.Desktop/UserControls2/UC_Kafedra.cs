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
using univer_management.Service.Services;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_Kafedra : UserControl
    {
		public UC_Kafedra()
        {
            InitializeComponent();
        }


		private void UC_Kafedra_Load(object sender, EventArgs e)
		{
			ComboBoxFill();
		}

		private async void ComboBoxFill()
		{
			using (var db = new AppDbContext())
			{
				var result = db.Mutaxasisliklar.ToList();
				mutaxasislikCmb.DataSource = result;
				mutaxasislikCmb.DisplayMember = "Name";
				mutaxasislikCmb.ValueMember = "Id";
			}
		}


	}
}
