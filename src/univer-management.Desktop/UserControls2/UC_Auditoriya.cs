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
using univer_management.Service.Dtos.CreateDtos;
using univer_management.Service.Services;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_Auditoriya : UserControl
    {
        private readonly AuditoriyaService service = new();

        public UC_Auditoriya()
        {
            InitializeComponent();
            SetValues();
        }
        private void DataGrid_Auditoriya(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridVIew_Auditor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void SetValues()
        {
            DataGridVIew_Auditor.Rows.Clear();
            var targets = await service.GetAllAsync();
            foreach (var item in targets)
                DataGridVIew_Auditor.Rows.Add(item.Id, item.NumberOfOrder,item.AuditoriyaTipi,item.Capacity,item.Korpus);
            guna2ComboBox1.DataSource = service.GetAllTypes();
            
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked)
            {
                var tool = new AuditoriyaCreateDto()
                {
                    NumberOfOrder = auditoriyaRaqami.Text,
                    AuditoriyaTipi = guna2ComboBox1.Text,
                    Capacity = int.Parse(joylarSoni.Text),
                    Korpus = auditoriyaBino.Text
                };
                var result = await service.CreateAsync(tool);
                if(result.Item2)
                    MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show($"Siz avvalo mutaxasislik qo'shishga roziligingizni bildirishingiz shart", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            SetValues();
        }

        private async void DataGridVIew_Auditor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridVIew_Auditor.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridVIew_Auditor.SelectedRows[0];
                var clientId = long.Parse(selectedRow.Cells[0].Value.ToString()!);
                byte actionId = 10;
                if (DataGridVIew_Auditor.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                    actionId = byte.Parse(e.ColumnIndex.ToString());
                //if (actionId == 5)
                //{
                //    UpdateForm update = new UpdateForm();
                //    update.Name = selectedRow.Cells[1].Value.ToString();
                //    update.Id = Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                //    update.Tag = this.Tag.ToString();
                //    update.ShowDialog();
                //}

                if (actionId == 6)
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
        private async Task ActionControl(byte action, long id)
        {
            if (action == 6)
            {
                await Task.Run(async () =>
                {
                    {
                        var result = await service.DeleteAsync(id);
                        if (result) MessageBox.Show($"Auditoriya muvaffaqiyatli o'chirildi", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show($"Nimadir xato ketdi,internet aloqasini tekshiring", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            };

        }
    }
}
