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
    public partial class UpdateFanlar : Form
    {
        FanService _service;
        KafedraService _kafedraService;
        public UpdateFanlar()
        {
            _kafedraService = new KafedraService();
            _service = new FanService();
            InitializeComponent();
            SetValue();
        }
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Levell { get; set; }
        public string Kafedra { get; set; } = string.Empty;

        private async void SetValue()
        {
            guna2ComboBox1.DataSource = (await _kafedraService.GetAll()).Select(x => x.Name).ToList();
        }

        private void UpdateFanlar_Load(object sender, EventArgs e)
        {
            guna2TextBox2.Text = Name;
            comboBox1.Text = Levell;
            guna2ComboBox1.Text = Kafedra;

        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            var mut = (await _kafedraService.GetAll()).FirstOrDefault(x => x.Name == guna2ComboBox1.Text.ToString())!.Id;
            var kaf = _service.GetAll().FirstOrDefault(x => x.Name == Name);
            var result = await _service.UpdateAsync(new Fan()
            {
                Name = guna2TextBox2.Text,
                Level = double.Parse(comboBox1.Text),
                KafedraId = mut
            },kaf!.Id);
            if (result.Item2 != null)
            {
                MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
