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
using univer_management.Desktop.UserControls2;
using univer_management.Domain.Entities;
using univer_management.Service.Services;

namespace univer_management.Desktop
{
    public partial class AddGuruhForm : Form
    {
        GuruxService _service;
        AddGuruhForm Instance;
        public AddGuruhForm()
        {
            Instance = this;
            _service = new GuruxService();
            InitializeComponent();
        }

        private async void AddGuruhForm_Load(object sender, EventArgs e)
        {
            ComboBoxFill();
            ComboBoxFill2();
        }


        private async void ComboBoxFill()
        {
            using (var db = new AppDbContext())
            {
                var result = db.Mutaxasisliklar.ToList();
                mutaxasislikCombobox.DataSource = result;
                mutaxasislikCombobox.DisplayMember = "Name";
                mutaxasislikCombobox.ValueMember = "Id";
            }
        }



        private async void ComboBoxFill2()
        {
            using (var db = new AppDbContext())
            {
                var result = db.Auditoriyalar.ToList();
                auditorycombobox.DataSource = result;
                auditorycombobox.DisplayMember = "NumberOfOrder";
                auditorycombobox.ValueMember = "Id";
            }
        }



        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTb.Text)
               && string.IsNullOrEmpty(semestrTb.Text) && string.IsNullOrEmpty(numberofSTb.Text))
            {
                MessageBox.Show("Iltimos barcha maydonlarni toldiring");
                return;
            }


            Mutaxasislik obj = mutaxasislikCombobox.SelectedItem as Mutaxasislik;
            Auditoriya obj2 = auditorycombobox.SelectedItem as Auditoriya;

            Gurux gurux = new Gurux()
            {
                Name = nameTb.Text,
                Semestr = int.Parse(semestrTb.Text),
                Capacity = int.Parse(numberofSTb.Text),
                MutaxasislikId = obj.Id,
                AuditoriyaId = obj2.Id
            };

            var result = await _service.CreateAsync(gurux);

            if (result.Item1)
            {
                MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UC_Guruh.Instance.SetValues();
            }
            else
            {
                MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
