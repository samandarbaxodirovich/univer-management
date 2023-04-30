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
using univer_management.Desktop;
using univer_management.Domain.Entities;
using univer_management.Service.Interfaces;
using univer_management.Service.Services;

namespace FinalProject.UserControls2
{
    public partial class UC_Yuklama : UserControl
    {
        YuklamaService service = new();
        UnitOfWork work = SingeltonUnitOfWork.Instance;



        public UC_Yuklama()
        {
            InitializeComponent();
            SetValues();
        }




        private void SetValues()
        {
            try
            {
                YuklamaGuruhR.DataSource = work.Guruxlar.GetAll().Select(x => x.Name).ToList();
                guna2DataGridView1.Rows.Clear();
                var result = service.GetAll().ToList();
                foreach (var item in result)
                {
                    guna2DataGridView1.Rows.Add(item.Id.ToString(), item.GuruxNomi, item.FanNomi, item.OqituvchiIsmi, item.Mashgulot, item.Haftalar, item.HaftalarSoatlar, item.AuditoriyaIsmi);
                }
            }
            catch { }
           
        }




        private void UC_Yuklama_Load_1(object sender, EventArgs e)
        {

        }


        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
            
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            var result = service.GetAll().Where(x => x.GuruxNomi == YuklamaGuruhR.SelectedItem.ToString()).ToList();
            foreach (var item in result)
            {
                guna2DataGridView1.Rows.Add(item.Id.ToString(), item.GuruxNomi, item.FanNomi, item.OqituvchiIsmi, item.Mashgulot, item.Haftalar, item.HaftalarSoatlar, item.AuditoriyaIsmi);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            YuklamaForm yuklamaForm = new YuklamaForm();
            yuklamaForm.ShowDialog();
            yuklamaForm.SetValues();
            
        }
        private async void ActionControl(byte action, long id)
        {
            if (action == 8)
            {
                work.Yuklamalar.Delete(id);
                if (await work.SaveChangesAsync() != 0) MessageBox.Show($"Yuklama muvaffaqqiyatli o'chirildi", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"Yuklama o'chirishda xatolik", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

        }
        private async void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                var clientId = long.Parse(selectedRow.Cells[0].Value.ToString()!);
                byte actionId = 10;
                if (guna2DataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
                    actionId = byte.Parse(e.ColumnIndex.ToString());
                if (actionId == 8)
                {
                    DialogResult dialogResult = MessageBox.Show($"Siz xaqiqatdan xam {selectedRow.Cells[1].Value} fani yuklamasini o'chirmoqchimisiz?", "Natija", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        ActionControl(actionId, clientId);
                        SetValues();
                    }
                }
                SetValues();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
                        guna2DataGridView1.Rows.Clear();
            var result = service.GetAll().Where(x => x.GuruxNomi == YuklamaGuruhR.SelectedItem.ToString()).ToList();
            foreach (var item in result)
            {
                guna2DataGridView1.Rows.Add(item.Id.ToString(), item.GuruxNomi, item.FanNomi, item.OqituvchiIsmi, item.Mashgulot, item.Haftalar, item.HaftalarSoatlar, item.AuditoriyaIsmi);
            }
        }
    }
}
