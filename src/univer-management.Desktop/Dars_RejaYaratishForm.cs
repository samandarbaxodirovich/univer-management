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
using univer_management.Domain.Entities;

namespace univer_management.Desktop
{
    public partial class Dars_RejaYaratishForm : Form
    {
        public Dars_RejaYaratishForm()
        {
            InitializeComponent();
            SetValues();
        }


        UnitOfWork _work = SingeltonUnitOfWork.Instance;
        


        private void DarsRejabtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="1")
            {
               MessageBox.Show("1 Parani qo'shishga rozimi siz","Ogohlantirish",MessageBoxButtons.OKCancel);
                    this.Close();
            }
           else if (comboBox1.Text == "2")
            {
                MessageBox.Show("2 Parani qo'shishga rozimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
                this.Close();
            }
           else if (comboBox1.Text == "3")
            {
                MessageBox.Show("3 Parani qo'shishga rozimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
                this.Close();
            }
           else if (comboBox1.Text == "4")
            {
                MessageBox.Show("4 Parani qo'shishga rozimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
                this.Close();
            }
            else if (comboBox1.Text == "5")
            {
                MessageBox.Show("5 Parani qo'shishga rozimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
                this.Close();
            }
        }




        private void Dars_RejaYaratishForm_Load(object sender, EventArgs e)
        {
        }



        private void SetValues()
        {
            ComboFill(); ComboFill1(); ComboFill2(); ComboFill3(); ComboFill4();
        }




        private void ComboFill()
        {
            using (var db = new AppDbContext())
            {
                var list = _work.Fanlar.GetAll().ToList();
                guna2ComboBox2.DataSource = list;
                guna2ComboBox2.DisplayMember = "Name";
                guna2ComboBox2.ValueMember = "Id";
            }
        }



        private void ComboFill1()
        {
            using (var db = new AppDbContext())
            {
                var list = _work.Fanlar.GetAll().ToList();
                guna2ComboBox1.DataSource = list;
                guna2ComboBox1.DisplayMember = "Name";
                guna2ComboBox1.ValueMember = "Id";
            }
        }



        private void ComboFill2()
        {
            using (var db = new AppDbContext())
            {
                var list = _work.Fanlar.GetAll().ToList();
                guna2ComboBox4.DataSource = list;
                guna2ComboBox4.DisplayMember = "Name";
                guna2ComboBox4.ValueMember = "Id";
            }
        }




        private void ComboFill3()
        {
            using (var db = new AppDbContext())
            {
                var list = _work.Fanlar.GetAll().ToList();
                guna2ComboBox5.DataSource = list;
                guna2ComboBox5.DisplayMember = "Name";
                guna2ComboBox5.ValueMember = "Id";
            }
        }



        private void ComboFill4()
        {
            using (var db = new AppDbContext())
            {
                var list = _work.Fanlar.GetAll().ToList();
                guna2ComboBox3.DataSource = list;
                guna2ComboBox3.DisplayMember = "Name";
                guna2ComboBox3.ValueMember = "Id";
            }
        }




		private async void DarsRejabtn_Click_2(object sender, EventArgs e)
		{
			var res = new DarsJadval()
			{
				paraRaqami = int.Parse(comboBox1.Text),
				Dushanba = guna2ComboBox5.Text,
				sehanba = guna2ComboBox4.Text,
				Chorshanba = guna2ComboBox2.Text,
				payshanba = guna2ComboBox3.Text,
				Juma = guna2ComboBox1.Text,
			};
			_work.DarsJadvallari.Add(res);
			if (await _work.SaveChangesAsync() != 0)
			{
				MessageBox.Show("Dars jadvali muvaffaqqiyatli saqlandi");
				this.Close();
			}
			else MessageBox.Show("Dars jadvali saqlashda xatolik");
		}
	}
}
