using univer_management.DataAccess.DbContexts;
using univer_management.Desktop.Updates;
using univer_management.Domain.Entities;
using univer_management.Service.Services;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_Kafedra : UserControl
    {
        KafedraService _service;


        public UC_Kafedra()
        {
            _service = new KafedraService();
            InitializeComponent();
            SetValues();
            guna2Button2.KeyDown += guna2Button2_KeyDown;
        }





        private async void ComboBoxFill()
        {
            using (var db = new AppDbContext())
            {
                var result = db.Mutaxasisliklar.ToList();
                mutaxasislikCmb.DataSource = result;
                mutaxasislikCmb.DisplayMember = "Name";
                mutaxasislikCmb.ValueMember = "Id";
            }
        }



        private async void SetValues()
        {
            datagridView_kafedra.Rows.Clear();

            var targets = await _service.GetAll();

            foreach (var item in targets)
            {
                datagridView_kafedra.Rows.Add(item.Id, item.Name, item.Mutaxasislik.Name);
            }

        }



        private void guna2Button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button2.PerformClick();
            }
        }




        private async Task ActionControl(byte action, long id)
        {
            if (action == 4)
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



        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                Mutaxasislik obj = mutaxasislikCmb.SelectedItem as Mutaxasislik;

                Kafedra kafedra = new Kafedra()
                {
                    Name = kafedratxt_box.Text,
                    MutaxasislikId = obj.Id
                };

                var result = await _service.CreateAsync(kafedra);

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

        private async void datagridView_kafedra_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridView_kafedra.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagridView_kafedra.SelectedRows[0];
                var clientId = long.Parse(selectedRow.Cells[0].Value.ToString()!);
                byte actionId = 10;
                if (datagridView_kafedra.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                    actionId = byte.Parse(e.ColumnIndex.ToString());
                if (actionId == 3)
                {
                    UpdateKafedra updateKafedra = new UpdateKafedra();
                    updateKafedra.Id = Convert.ToInt64(selectedRow.Cells[0].Value.ToString());
                    updateKafedra.Name = selectedRow.Cells[1].Value.ToString();
                    updateKafedra.Mutaxassilik = selectedRow.Cells[2].Value.ToString();
                    updateKafedra.ShowDialog();
                    SetValues();
                }

                else if (actionId == 4)
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

        private void UC_Kafedra_Load(object sender, EventArgs e)
        {
            ComboBoxFill();
        }
    }
}
