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
using univer_management.Domain.Entities;
using univer_management.Service.Services;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_O_qituvchilar : UserControl
    {
        TeacherService _service;
        public UC_O_qituvchilar()
        {
            _service = new TeacherService();
            InitializeComponent();
            SetValues();
        }
        private async void ComboBoxFill()
        {
            using (var db = new AppDbContext())
            {
                var result = db.Kafedralar.ToList();
                kafedraId.DataSource = result;
                kafedraId.DisplayMember = "Name";
                kafedraId.ValueMember = "Id";
            }
        }



        private void DataGridVIew_Oqituvchi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_O_qituvchilar_Load(object sender, EventArgs e)
        {
            ComboBoxFill();
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2CheckBox11.Checked)
            {
                Kafedra obj = kafedraId.SelectedItem as Kafedra;

                Oqituvchi oqituvchi = new Oqituvchi()
                {
                    FullName = gunatextBox.Text,
                    Level = Convert.ToDouble(gunatextbox2.Text),
                    KafedraId = obj.Id
                };

                var result = await _service.CreateAsync(oqituvchi);

                if (result.Item1)
                {
                    MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gunatextBox.Clear();
                    gunatextbox2.Clear();
                    kafedraId.Text = "kafedra tanlang";
                }
                else
                {
                    MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SetValues();
            }
            else MessageBox.Show($"Siz avvalo O'qituvchi qo'shishga roziligingizni bildirishingiz shart", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private async void SetValues()
        {
            DataGridVIew_Oqituvchi.Rows.Clear();

            var targets = _service.GetAllTeachers();

            foreach (var item in targets)
            {
                DataGridVIew_Oqituvchi.Rows.Add(item.Id, item.FullName, item.Level, item.Kafedra);
            }

        }
    }
}
