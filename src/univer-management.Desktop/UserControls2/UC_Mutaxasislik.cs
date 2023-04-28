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
    public partial class UC_Mutaxasislik : UserControl
    {
        private readonly MutaxasislikService service;

        public UC_Mutaxasislik()
        {
            InitializeComponent();
            service = new MutaxasislikService();
            SetValues();
        }

        private void SetValues()
        {
            dataGridView1.Rows.Clear();
            var targets = service.GetAll();
            foreach (var item in targets)
                dataGridView1.Rows.Add(item.Id, item.Name);
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox2.Text = string.Empty;
            checkBox1.Checked = false;
        }
        private async Task ActionControl(byte action, long id)
        {
            if (action == 3)
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



        private async void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Mutaxasislik mutaxasislik = new Mutaxasislik() { Name = textBox2.Text };
                var result = await service.CreateAsync(mutaxasislik);
                if (result.Item1) MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetValues();
            }
            else MessageBox.Show($"Siz avvalo mutaxasislik qo'shishga roziligingizni bildirishingiz shart", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var targets = service.GetByKeyword(textBox2.Text);
            foreach (var item in targets)
                dataGridView1.Rows.Add(item.Id, item.Name);
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                var clientId = long.Parse(selectedRow.Cells[0].Value.ToString()!);
                byte actionId = 10;
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                    actionId = byte.Parse(e.ColumnIndex.ToString());
                if (actionId == 2)
                {
                    UpdateForm update = new UpdateForm();
                    update.Name = selectedRow.Cells[1].Value.ToString()!;
                    update.Id = Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                    update.Tag = this.Tag.ToString()!;
                    update.ShowDialog();
                    SetValues();
                }

                else if (actionId == 3)
                {
                     MessageBox.Show($"Siz avvalo mutaxasislik qo'shishga roziligingizni bildirishingiz shart", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //DialogResult dialogResult = MessageBox.Show($"Siz xaqiqatdan xam {selectedRow.Cells[1].Value} mutaxasisligini o'chirmoqchimisiz?", "Natija", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //if (dialogResult == DialogResult.Cancel)
                    //{
                    //    return;
                    //}
                    //else
                    //{
                    //    await ActionControl(actionId, clientId);
                    //    SetValues();
                    //}
                }
            }
        }
    }
}
