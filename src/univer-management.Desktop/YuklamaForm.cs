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
using univer_management.Desktop.UserControls2;
using univer_management.Domain.Entities;
using univer_management.Service.Services;

namespace univer_management.Desktop
{
    public partial class YuklamaForm : Form
    {
        YuklamaService service;

        public YuklamaForm()
        {
            service = new YuklamaService();
            InitializeComponent();
        }

        private async void ComboBoxFill()
        {
            using (var db = new AppDbContext())
            {
                var result = db.Fanlar.ToList();
                guna2ComboBox1.DataSource = result;
                guna2ComboBox1.DisplayMember = "Name";
                guna2ComboBox1.ValueMember = "Id";
            }
        }
        private async void ComboBoxFill2()
        {
            using (var db = new AppDbContext())
            {
                var result = db.Oqituvchilar.ToList();
                guna2ComboBox2.DataSource = result;
                guna2ComboBox2.DisplayMember = "FullName";
                guna2ComboBox2.ValueMember = "Id";
            }
        }
        private async void ComboBoxFill3()
        {
            using (var db = new AppDbContext())
            {
                var result = db.Mashgulotlar.ToList();
                guna2ComboBox4.DataSource = result;
                guna2ComboBox4.DisplayMember = "Name";
                guna2ComboBox4.ValueMember = "Id";
            }
        }
        private async void ComboBoxFill4()
        {
            using (var db = new AppDbContext())
            {
                var result = db.Oquv_Rejalar.ToList();
                guna2ComboBox3.DataSource = result;
                guna2ComboBox3.DisplayMember = "NumberOfOrder";
                guna2ComboBox3.ValueMember = "Id";
            }
        }
        private async void ComboBoxFill5()
        {
            using (var db = new AppDbContext())
            {
                var result = db.Auditoriyalar.ToList();
                guna2ComboBox5.DataSource = result;
                guna2ComboBox5.DisplayMember = "NumberOfOrder";
                guna2ComboBox5.ValueMember = "Id";
            }
        }

        private async void ComboBoxFill6()
        {
            using (var db = new AppDbContext())
            {
                var result = db.Guruxlar.ToList();
                guna2ComboBox6.DataSource = result;
                guna2ComboBox6.DisplayMember = "Name";
                guna2ComboBox6.ValueMember = "Id";
            }
        }

        private void YuklamaForm_Load(object sender, EventArgs e)
        {
        }

        private async void Yuxlamabtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void YuklamaForm_Load_1(object sender, EventArgs e)
        {
            ComboBoxFill(); ComboBoxFill2(); ComboBoxFill3(); ComboBoxFill4(); ComboBoxFill5(); ComboBoxFill6();
        }

        private async void Yuxlamabtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(YukDarstxt.Text))
            {
                MessageBox.Show("Iltimos barcha maydonlarni toldiring");
                return;
            }

            Fan obj = guna2ComboBox1.SelectedItem as Fan;
            Oqituvchi obj1 = guna2ComboBox2.SelectedItem as Oqituvchi;
            Mashgulot obj2 = guna2ComboBox4.SelectedItem as Mashgulot;
            Oquv_Reja obj3 = guna2ComboBox3.SelectedItem as Oquv_Reja;
            Auditoriya obj4 = guna2ComboBox5.SelectedItem as Auditoriya;
            Gurux obj5 = guna2ComboBox6.SelectedItem as Gurux;

            Yuklama yuklama = new Yuklama()
            {
                GuruxId = obj5.Id,
                FanId = obj.Id,
                OqituvchiId = obj1.Id,
                MashgulotId = obj2.Id,
                Oquv_RejaId = obj3.Id,
                HaftasigaDars = long.Parse(YukDarstxt.Text),
                AuditoriyaId = obj4.Id
            };
            var result = await service.CreateAsync(yuklama);
            if (result.Item1)
            {
                MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
