using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using univer_management.Service.Services;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_Guruh : UserControl
    {

        GuruxService _service;
        public static UC_Guruh Instance;
        public UC_Guruh()
        {
            Instance = this;
            _service = new GuruxService();
            InitializeComponent();


        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            AddGuruhForm addGuruhForm = new AddGuruhForm();
            addGuruhForm.ShowDialog();
        }

        private void UC_Guruh_Load(object sender, EventArgs e)
        {
            SetValues();
        }

        private async Task ActionControl(byte action, long id)
        {
            if (action == 6)
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

        public async void SetValues()
        {
            datagridview1.Rows.Clear();

            var targets = await _service.GetAll();

            if (targets != null)
            {
                foreach (var item in targets)
                {
                    datagridview1.Rows.Add(item.Id, item.Name, item.Smena, item.Capacity, item.Semestr, item.Mutaxasislik.Name, item.Auditoriya.NumberOfOrder);
                }
            }
        }

        private async void datagridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridview1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridview1.SelectedRows[0];
                var clientId = long.Parse(selectedRow.Cells[0].Value.ToString()!);
                byte actionId = 10;
                if (datagridview1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                    actionId = byte.Parse(e.ColumnIndex.ToString());
                if (actionId == 6)
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
