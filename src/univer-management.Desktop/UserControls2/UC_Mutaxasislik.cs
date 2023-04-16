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
            guna2Button1.KeyDown += guna2Button1_KeyDown;
        }

        private void UC_Muttaxasislik_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Muttaxasislik_Load_1(object sender, EventArgs e)
        {

        }
        
        private void SetValues()
        {
            guna2DataGridView1.Rows.Clear();
            var targets = service.GetAll();
            foreach (var item in targets)
                guna2DataGridView1.Rows.Add(item.Id, item.Name);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                Mutaxasislik mutaxasislik = new Mutaxasislik() { Name = guna2TextBox2.Text };
                var result = await service.CreateAsync(mutaxasislik);
                if (result.Item1) MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetValues();
            }
            else MessageBox.Show($"Siz avvalo mutaxasislik qo'shishga roziligingizni bildirishingiz shart", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2TextBox3.Text = string.Empty;
            guna2TextBox2.Text = string.Empty;
            guna2CheckBox1.Checked = false;
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            var targets = service.GetByKeyword(guna2TextBox1.Text);
            foreach (var item in targets)
                guna2DataGridView1.Rows.Add(item.Id, item.Name);
        }

        private async void guna2DataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                var clientId = long.Parse(selectedRow.Cells[0].Value.ToString()!);
                byte actionId = 10;
                if (guna2DataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                    actionId = byte.Parse(e.ColumnIndex.ToString());
                if (actionId == 2)
                {
                    UpdateForm update = new UpdateForm();
                    update.Name = selectedRow.Cells[1].Value.ToString()!;
                    update.Id = Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                    update.Tag = this.Tag.ToString()!;
                    update.ShowDialog();
                }

                else if (actionId == 3)
                {
                    DialogResult dialogResult = MessageBox.Show($"Siz xaqiqatdan xam {selectedRow.Cells[1].Value} mutaxasisligini o'chirmoqchimisiz?", "Natija", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
