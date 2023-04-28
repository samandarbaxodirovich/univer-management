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
    public partial class UC_Fanlar : UserControl
    {
        FanService service = new();
        KafedraService kService = new();


        public UC_Fanlar()
        {
            InitializeComponent();
            SetValues();
        }



        private async void SetValues()
        {
            guna2DataGridView1.Rows.Clear();

            var targets = service.GetAll();

            foreach (var item in targets)
            {
                guna2DataGridView1.Rows.Add(item.Id, item.Name, item.Level, item.KafedraName);
            }
            guna2ComboBox1.DataSource = (await kService.GetAll()).Select(x => x.Name).ToList();
        }




        private async Task ActionControl(byte action, long id)
        {
            if (action == 5)
            {
                await Task.Run(async () =>
                {
                    {
                        var result = await service.DeleteAsync(id);
                        if (result.Item1) MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            };

        }



        private async void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                var result = await service.CreateAsync(new Fan()
                {
                    Level = double.Parse(guna2ComboBox2.Text),
                    Name = guna2TextBox2.Text,
                }, guna2ComboBox1.Text);
                if (result.Item1)
                {
                    MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SetValues();
            }
            else MessageBox.Show($"Siz avvalo kafedra qo'shishga roziligingizni bildirishingiz shart", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }



        private async void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                var clientId = long.Parse(selectedRow.Cells[0].Value.ToString()!);
                byte actionId = 10;
                if (guna2DataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                    actionId = byte.Parse(e.ColumnIndex.ToString());
                if (actionId == 5)
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
    }
}
