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
using univer_management.Domain.Entities;
using univer_management.Service.Services;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_Mashg_ulotlar : UserControl
    {
        MashgulotService _service;
        public UC_Mashg_ulotlar()
        {
            _service = new MashgulotService();
            InitializeComponent();
            SetValues();
        }
        private void SetValues()
        {
            DataGridVIew_Oqituvchi.Rows.Clear();
            var targets = _service.GetAll();
            foreach (var item in targets)
                DataGridVIew_Oqituvchi.Rows.Add(item.Id, item.Name);
        }

       

        private async void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                Mashgulot mashgulot = new Mashgulot() { Name = gunatextBox.Text };
                var result = await _service.CreateAsync(mashgulot);
                if (result.Item1) MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetValues();
            }
            else MessageBox.Show($"Siz avvalo mashgulot qo'shishga roziligingizni bildirishingiz shart", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }
    }
}
