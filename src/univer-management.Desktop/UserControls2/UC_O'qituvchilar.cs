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
        private async Task ActionControl(byte action, long id)
        {
            if (action == 5)
            {
                await Task.Run(async () =>
                {
                    {
                        var result = await _service.DeleteAsync(id);
                        if (result.Item1) MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            };

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

        private async void DataGridVIew_Oqituvchi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridVIew_Oqituvchi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridVIew_Oqituvchi.SelectedRows[0];
                var clientId = long.Parse(selectedRow.Cells[0].Value.ToString()!);
                byte actionId = 10;
                if (DataGridVIew_Oqituvchi.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                    actionId = byte.Parse(e.ColumnIndex.ToString());
                if (actionId == 5)
                {
                    DialogResult dialogResult = MessageBox.Show($"Siz xaqiqatdan xam {selectedRow.Cells[1].Value.ToString()} kafedrani o'chirmoqchimisiz?", "Natija", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        await ActionControl(actionId, clientId);
                        SetValues();
                    }
                }
            }
        }
    }
}
