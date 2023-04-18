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
using univer_management.Desktop.UserControls2;
using univer_management.Domain.Entities;
using univer_management.Service.Dtos.CreateDtos;
using univer_management.Service.Services;

namespace univer_management.Desktop
{
    public partial class OquvrejaForm : Form
    {
        public OquvrejaForm(long mutaxasislik,int semestr)
        {
            InitializeComponent();
            SetCombo();
            mutaxasisId= mutaxasislik;
            semest = semestr;
        }
        private long mutaxasisId;
        private int semest;
        FanService fanService = new();
        OquvRejaService service = new();
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
        }
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
        private void SetCombo()
        {
            guna2ComboBox1.DataSource = fanService.GetAll().Select(x => x.Name).ToList();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
        }

        private void OquvrejaForm_Load(object sender, EventArgs e)
        {
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Oquvrejabtn_Click(object sender, EventArgs e)
        {
            OquvRejaFanCreateDto dto = new();
            {
                dto.Fan = fanService.GetAll().FirstOrDefault(x => x.Name == guna2ComboBox1.Text)!.Id;
                dto.Semestr = semest;
                try
                {
                    dto.HaftalarSoni = int.Parse(guna2TextBox7.Text);

                }
                catch { }
                try
                {
                    dto.Lektsiya = double.Parse(guna2TextBox1.Text);


                }
                catch { }
                try
                {
                    dto.Imtihon = double.Parse(guna2TextBox4.Text);

                }
                catch { }
                try
                {
                    dto.MustaqilTalim = double.Parse(guna2TextBox5.Text);
                }
                catch { }
                try
                {
                    dto.Seminar = double.Parse(guna2TextBox2.Text);

                }
                catch { }
                dto.UmumiyDarsSoati = double.Parse(label3.Text);
                dto.Mutaxasislik = mutaxasisId;
            }
            var result = await service.CreateAsync(dto);
            if (result.Item1)
            {
                if (result.Item1) MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show($"{result.Item2}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
