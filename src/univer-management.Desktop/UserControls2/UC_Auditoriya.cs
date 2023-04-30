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
using univer_management.DataAccess.Repositories.Common;
using univer_management.DataAccess.Repositories.Main;
using univer_management.Desktop.Updates;
using univer_management.Domain.Entities;
using univer_management.Service.Dtos.CreateDtos;
using univer_management.Service.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_Auditoriya : UserControl
    {
        UnitOfWork _work = SingeltonUnitOfWork.Instance;
        private readonly AuditoriyaService service = new();
        private readonly Auditoriya_TypiService service2 = new();
        public UC_Auditoriya()
        {
            InitializeComponent();
            SetValues();
        }


        private async void SetValues()
        {
            DataGridVIew_Auditor.Rows.Clear();
            var targets = await service.GetAllAsync();
            foreach (var item in targets)
                DataGridVIew_Auditor.Rows.Add(item.Id, item.NumberOfOrder, item.AuditoriyaTipi, item.Capacity, item.Korpus);
            guna2ComboBox1.DataSource = service.GetAllTypes();

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


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DataGridVIew_Auditor.Rows.Clear();
            var targets = service.GetByKeyword(guna2TextBox1.Text);
            foreach (var item in targets)
                DataGridVIew_Auditor.Rows.Add(item.Id, item.NumberOfOrder, item.AuditoriyaTipi, item.Capacity, item.Korpus);
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
                if (actionId == 5)
                {
                    UpdateAuditoriya update = new UpdateAuditoriya();
                    update.Number = selectedRow.Cells[1].Value.ToString();
                    update.Id = Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                    update.Auditoriya_Tipiw = selectedRow.Cells[2].Value.ToString();
                    update.Sigimi = selectedRow.Cells[3].Value.ToString();
                    update.Korpus = selectedRow.Cells[4].Value.ToString();
                    update.ShowDialog();
                    SetValues();
                }

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

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            int capacity;
            bool isNumeric = int.TryParse(joylarSoni.Text, out capacity);
            if (isNumeric)
            {
                if (guna2CheckBox1.Checked)
                {
                    if (await _work.AuditoriyaTiplari.FirstOrDefaultAsync(x => x.Type == guna2ComboBox1.Text) == null)
                    {
                        if (!await service2.Create(new Domain.Entities.Auditoriya_Tipi() { Type = guna2ComboBox1.Text }))
                        {
                            MessageBox.Show($"Auditoriya turi qo'shishda xatolik", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    var tool = new AuditoriyaCreateDto()
                    {
                        NumberOfOrder = auditoriyaRaqami.Text,
                        AuditoriyaTipi = guna2ComboBox1.Text,
                        Capacity = capacity,
                        Korpus = auditoriyaBino.Text
                    };
                    var result = await service.CreateAsync(tool);
                    if (result.Item2)
                        MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show($"Siz avvalo mutaxasislik qo'shishga roziligingizni bildirishingiz shart", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"{joylarSoni.Text} kiritilgan son emas!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetValues();
        }

        private async void DataGridVIew_Auditor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DataGridVIew_Auditor.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridVIew_Auditor.SelectedRows[0];
                var clientId = long.Parse(selectedRow.Cells[0].Value.ToString()!);
                byte actionId = 10;
                if (DataGridVIew_Auditor.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                    actionId = byte.Parse(e.ColumnIndex.ToString());
                if (actionId == 5)
                {
                    UpdateAuditoriya update = new UpdateAuditoriya();
                    update.Number = selectedRow.Cells[1].Value.ToString();
                    update.Id = Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                    update.Auditoriya_Tipiw = selectedRow.Cells[2].Value.ToString();
                    update.Sigimi = selectedRow.Cells[3].Value.ToString();
                    update.Korpus = selectedRow.Cells[4].Value.ToString();
                    update.ShowDialog();
                    SetValues();
                }

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
    }
}
