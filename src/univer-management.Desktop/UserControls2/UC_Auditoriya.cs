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
using univer_management.Service.Dtos.CreateDtos;
using univer_management.Service.Services;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_Auditoriya : UserControl
    {
        private readonly AuditoriyaService service = new();

        public UC_Auditoriya()
        {
            InitializeComponent();
            SetValues();
        }
        private void DataGrid_Auditoriya(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridVIew_Auditor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void SetValues()
        {
            DataGridVIew_Auditor.Rows.Clear();
            var targets = await service.GetAllAsync();
            foreach (var item in targets)
                DataGridVIew_Auditor.Rows.Add(item.Id, item.NumberOfOrder,item.AuditoriyaTipi,item.Capacity,item.Korpus);
            guna2ComboBox1.DataSource = service.GetAllTypes();
            
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked)
            {
                var tool = new AuditoriyaCreateDto()
                {
                    NumberOfOrder = auditoriyaRaqami.Text,
                    AuditoriyaTipi = guna2ComboBox1.Text,
                    Capacity = int.Parse(joylarSoni.Text),
                    Korpus = auditoriyaBino.Text
                };
                var result = await service.CreateAsync(tool);
                if(result.Item2)
                    MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetValues();
        }

        private void DataGridVIew_Auditor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
