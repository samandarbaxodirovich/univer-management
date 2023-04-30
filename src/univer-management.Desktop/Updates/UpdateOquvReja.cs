using FinalProject.UserControls2;
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
using univer_management.Service.Dtos.UpdateDtos;
using univer_management.Service.Services;
using univer_management.Service.ViewModels;

namespace univer_management.Desktop.Updates
{
    public partial class UpdateOquvReja : Form
    {
        public UpdateOquvReja()
        {
            InitializeComponent();
        }

        public string OquvRejaNomi { get; set; }
        public OquvRejaViewModel oquvReja { get; set; }
        private OquvRejaService service = new OquvRejaService();
        private void SetTotal()
        {
            
            List<string> list = new List<string>()
            {
                guna2TextBox1.Text,guna2TextBox5.Text,guna2TextBox4.Text ,guna2TextBox2.Text
            };
            var resultAll = 0.0;
            foreach (string s in list)
            {
                try
                {
                    resultAll += double.Parse(s);
                }
                catch { }
                label3.Text = resultAll.ToString();
            }
        }
        public void SetSciense()
        {
            guna2TextBox1.Text = oquvReja.Lektsiya.ToString();
            guna2TextBox2.Text = oquvReja.Seminar.ToString();
            guna2TextBox4.Text = oquvReja.OraliqImtihon.ToString();
            guna2TextBox5.Text = oquvReja.MustaqilTalim.ToString();
            guna2TextBox7.Text = oquvReja.Hafta.ToString();
            label1.Text = OquvRejaNomi;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            SetTotal();

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            SetTotal();

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            SetTotal();

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {
            SetTotal();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Oquvrejabtn_Click(object sender, EventArgs e)
        {
            try
            {
                var target = new OquvRejaFanUpdateDto()
                {
                    HaftalarSoni = int.Parse(guna2TextBox7.Text),
                    UmumiyDarsSoati = double.Parse(label3.Text),
                    Imtihon = double.Parse(guna2TextBox4.Text.ToString()),
                    Seminar = double.Parse(guna2TextBox2.Text.ToString()),
                    Lektsiya = double.Parse(guna2TextBox1.Text.ToString()),
                    MustaqilTalim = double.Parse(guna2TextBox5.Text.ToString()),
                    OquvRejaId = oquvReja.Id
                };
                if (await service.Update(target))
                {
                    MessageBox.Show("O'quv reja muvaffaqqiyatli o'zgartirildi");
                    this.Close();
                }
                else
                    MessageBox.Show("O'quv reja o'zgartirishda xatolik");
            }
            catch
            {
                MessageBox.Show("Iltimos hamma hududlarni to'gri to'ldiring");
            }
                
            
        }
    }
}
