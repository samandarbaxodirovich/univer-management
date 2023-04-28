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

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_Dars_Reja : UserControl
    {
        public UC_Dars_Reja()
        {
            InitializeComponent();
            SetValues();
        }
        UnitOfWork work = SingeltonUnitOfWork.Instance;

        private void SetValues()
        {
            DataGridViewDars.Rows.Clear();  
            var list = work.DarsJadvallari.GetAll().ToList();
            foreach (var item in list)
            {
                DataGridViewDars.Rows.Add(item.paraRaqami,item.Dushanba,item.sehanba,item.Chorshanba,item.payshanba,item.Juma);
            }
        }

        private void UC_Dars_Reja_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Siz 1 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
                yaratishForm.comboBox1.SelectedIndex = 0;
                yaratishForm.ShowDialog();
                SetValues();
            }
            return;
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Siz 3 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
                yaratishForm.comboBox1.SelectedIndex = 2;
                yaratishForm.ShowDialog();
                SetValues();
            }
            return;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }




		private void guna2Button1_Click_2(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Siz 1 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
			if (res == DialogResult.OK)
			{
				Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
				yaratishForm.comboBox1.SelectedIndex = 0;
				yaratishForm.ShowDialog();
				SetValues();
			}
			return;
		}

		private async void DataGridViewDars_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
		{
			int row = e.RowIndex + 1;
			int column = e.ColumnIndex;
			var bb = int.Parse(DataGridViewDars.SelectedCells[0].Value.ToString()!);
			if (column == 6)
			{
				var target = work.DarsJadvallari.GetAll().FirstOrDefault(x => x.paraRaqami == bb);
				work.DarsJadvallari.Delete(target.Id);
				if (await work.SaveChangesAsync() != 0)
				{
					SetValues();
					MessageBox.Show("Dars jadvali muvaffaqqiyatli o'chirildi");
				}
				else MessageBox.Show("Dars jadvali o'chirishda xatolik");
			}
		}

		private async void guna2Button5_Click_1(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Siz 5 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
			if (res == DialogResult.OK)
			{
				Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
				yaratishForm.comboBox1.SelectedIndex = 4;
				yaratishForm.ShowDialog();
				SetValues();
			}
			return;
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Siz 4 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
			if (res == DialogResult.OK)
			{
				Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
				yaratishForm.comboBox1.SelectedIndex = 3;
				yaratishForm.ShowDialog();
				SetValues();
			}
			return;
		}

		private void guna2Button4_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Siz 2 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
			if (res == DialogResult.OK)
			{
				Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
				yaratishForm.comboBox1.SelectedIndex = 1;
				yaratishForm.ShowDialog();
				SetValues();
			}
			return;
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Siz 3 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
			if (res == DialogResult.OK)
			{
				Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
				yaratishForm.comboBox1.SelectedIndex = 2;
				yaratishForm.ShowDialog();
				SetValues();
			}
			return;
		}
	}
}
