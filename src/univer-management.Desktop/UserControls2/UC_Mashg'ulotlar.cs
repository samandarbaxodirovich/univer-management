using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using univer_management.Desktop.Updates;
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


        private async Task ActionControl(byte action, long id)
        {
            if (action == 3)
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
                if (actionId == 2)
                {
                    UpdateMashg_ulotlar update = new UpdateMashg_ulotlar();
                    update.Name = selectedRow.Cells[1].Value.ToString()!;
                    update.Id = Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                    update.ShowDialog();
                    SetValues();
                }
                else if (actionId == 3)
                {
                    DialogResult dialogResult = MessageBox.Show($"Siz xaqiqatdan xam {selectedRow.Cells[1].Value.ToString()} Guruhni o'chirmoqchimisiz?", "Natija", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private async void guna2Button2_Click(object sender, EventArgs e)
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


        // backendi yozilmagan ekan
        // search textbox
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        // search button(lupa)
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void UC_Mashg_ulotlar_Load(object sender, EventArgs e)
        {

        }
    }
}
