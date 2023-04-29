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
using univer_management.Service.Services;

namespace univer_management.Desktop.Updates
{
    public partial class UpdateGuruh : Form
    {
        GuruxService guruxService;
        AuditoriyaService auditoriyaService;
        MutaxasislikService mutaxasislikService;

        public UpdateGuruh()
        {
            guruxService = new GuruxService();
            auditoriyaService = new AuditoriyaService();
            mutaxasislikService = new MutaxasislikService();
            InitializeComponent();
            SetValue();

        }
        public long Id { get; set; }
        public string GuruhNomi { get; set; }
        public string Talabasoni { get; set; }
        public string Auditoriya { get; set; }
        public string Mutaxassilik { get; set; } 

        private void SetValue()
        {
            comboBox2.DataSource = auditoriyaService.GetAll().Select(x => x.NumberOfOrder).ToList();
            comboBox1.DataSource = mutaxasislikService.GetAll().Select(x => x.Name).ToList();
        }

        private async void guna2Button21_Click(object sender, EventArgs e)
        {
            //var mut = (await auditoriyaService.GetAllAsync()).FirstOrDefault(x => x.AuditoriyaTipi == Auditoriya)!.Id;
			var mut = (await auditoriyaService.GetAllAsync()).FirstOrDefault(x => x.NumberOfOrder == comboBox2.SelectedItem.ToString())!.Id;
            var mutax = mutaxasislikService.GetAll().FirstOrDefault(x => x.Name == comboBox1.SelectedItem.ToString())!.Id;
            var result = await guruxService.UpdateAsync(Id, new Gurux()
            {
                Name = textBox1.Text,
                Capacity = int.Parse(textBox2.Text),
                AuditoriyaId = mut,
                MutaxasislikId = mutax
            });
            if (result.Item2 != null)
            {
                MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void UpdateGuruh_Load(object sender, EventArgs e)
        {
            textBox1.Text = GuruhNomi;
            textBox2.Text = Talabasoni;
            comboBox2.Text = Auditoriya;
            comboBox1.Text = Mutaxassilik;
        }
    }
}
