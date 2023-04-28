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
using univer_management.Domain.Entities;
using univer_management.Service.Interfaces;
using univer_management.Service.Services;

namespace univer_management.Desktop.Updates
{
    public partial class UpdateAuditoriya : Form
    {
        AuditoriyaService _service;
        Auditoriya_TypiService _serviceTypiService;



        public UpdateAuditoriya()
        {
            _serviceTypiService=new Auditoriya_TypiService();
            _service = new AuditoriyaService();
            InitializeComponent();
            SetValue();
        }



        public long Id { get; set; }
        public string Number { get; set; }
        public string Sigimi { get; set; }
        public string Auditoriya_Tipiw { get; set; }
        public string Korpus { get; set; } = string.Empty;




        private void SetValue()
        {
            guna2ComboBox11.DataSource = _service.GetAll().Select(x => x.Auditoriya_Tipi.Type).ToList();
        }



		private async void guna2Button21_Click(object sender, EventArgs e)
		{
			var mut = (await _serviceTypiService.GetAllAsync()).FirstOrDefault(x => x.Type == Auditoriya_Tipiw)!.Id;
			var result = await _service.UpdateAsync(Id, new Auditoriya()
			{
				NumberOfOrder = auditoriyaRaqami1.Text,
				Capacity = int.Parse(joylarSoni1.Text),
				Auditoriya_TipiId = mut,
				Korpus = auditoriyaBino1.Text
			});
			if (result.Item2 != null)
			{
				MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else MessageBox.Show($"{result.Item1}", "Natija", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}
		




		private void UpdateAuditoriya_Load(object sender, EventArgs e)
		{
			auditoriyaRaqami1.Text = Number;
			guna2ComboBox11.Text = Auditoriya_Tipiw;
			joylarSoni1.Text = Sigimi;
			auditoriyaBino1.Text = Korpus;
		}
	}
}
