using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using univer_management.Desktop.Components;
using univer_management.Desktop.UserControls2;
using univer_management.Domain.Entities;
using univer_management.Service.Services;

namespace univer_management.Desktop.Updates
{
    public partial class UpdateKafedra : Form
    {
        public UpdateKafedra()
        {
            InitializeComponent();
            SetValue();
        }
        public string Name { get;set; }
        public long Id { get; set; }
        public string Mutaxassilik { get; set; }

        KafedraService kafedraService=new KafedraService();
        MutaxasislikService service=new MutaxasislikService();

        private void UpdateKafedra_Load(object sender, EventArgs e)
        {
            Kafedra1.Text = Mutaxassilik;
            guna2TextBox1.Text = Name;
        }

        private async void kafedraupdate_Click(object sender, EventArgs e)
        {
            var mut = service.GetAll().FirstOrDefault(x => x.Name == Mutaxassilik)!.Id;
            var kaf = (await kafedraService.GetAll()).FirstOrDefault(x => x.Name == Name);
            var result = await kafedraService.UpdateAsync(new Kafedra() { MutaxasislikId = mut, Name = guna2TextBox1.Text },kaf!.Id);
            if (result.Item2 != null)
            {
                MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void SetValue()
        {
            Kafedra1.DataSource = service.GetAll().Select(x=>x.Name).ToList();
        }
    }
}
