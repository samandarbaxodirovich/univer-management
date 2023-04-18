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
using univer_management.Service.Interfaces;
using univer_management.Service.Services;

namespace univer_management.Desktop.Updates
{
    public partial class UpdateOqituvchi : Form
    {
        TeacherService service = new TeacherService();
        KafedraService kafedra = new KafedraService();
        public UpdateOqituvchi()
        {
            InitializeComponent();
            SetValue();
        }
        public long Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Level { get; set; }
        public string Kafedra { get; set; } = string.Empty;

        private void UpdateOqituvchi_Load(object sender, EventArgs e)
        {
            auditoriyaRaqami11.Text = FullName;
            oqituvchi.Text = Level;
            guna2Combo.Text = Kafedra;
        }

        private async void guna2But_Click(object sender, EventArgs e)
        {
            var mut = (await kafedra.GetAll()).FirstOrDefault(x => x.Name == Kafedra )!.Id;
            var kaf =  service.GetAllTeachers().FirstOrDefault(x => x.FullName == FullName);
            var result = await service.UpdateAsync(new Oqituvchi()
            {
                FullName = auditoriyaRaqami11.Text,
                Level = oqituvchi.Text,
                KafedraId = mut
            },kaf!.Id);
            if (result.Item2 != null)
            {
                MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private async void SetValue()
        {
            guna2Combo.DataSource =(await kafedra.GetAll()).Select(x => x.Name).ToList();
        }
    }
}
