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
    public partial class UC_Muttaxasislik : UserControl
    {
        private readonly MutaxasislikService service;
        public UC_Muttaxasislik()
        {
            InitializeComponent();
            service = new MutaxasislikService();
            SetValues();
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
        private void guna2DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                var clientId = long.Parse(selectedRow.Cells[0].Value.ToString()!);
                int actionId;
                if (guna2DataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                    actionId = int.Parse(e.ColumnIndex.ToString());
            }
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
            guna2DataGridView1.Rows.Clear();
            var targets = service.GetByKeyword(guna2TextBox1.Text);
            foreach (var item in targets)
                guna2DataGridView1.Rows.Add(item.Id, item.Name);
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
