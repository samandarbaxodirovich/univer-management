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
using univer_management.Service.Services;

namespace univer_management.Desktop
{
    public partial class UpdateForm : Form
    {
        MutaxasislikService _serviceMut;
        public UpdateForm()
        {
            _serviceMut= new MutaxasislikService();
            InitializeComponent();
        }

        public string Name { get; set; }
        public long Id { get; set; }
        public string Tag { get; set; }

		private void UpdateForm_Load_1(object sender, EventArgs e)
		{
			guna2TextBox2.Text = Name;
			label2.Text = Tag.ToString();
		}
	
		private void guna2Button2_Click(object sender, EventArgs e)
		{
            if (Tag == "Mutahasislik" && !string.IsNullOrEmpty(guna2TextBox2.Text))
            {
				Mutahasislik();
			}
		}


        private void Mutahasislik()
        {
			DialogResult dlg = MessageBox.Show("Mutahasislik nomini o'zgartirishni xoxlaysizmi??", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			if (dlg == DialogResult.OK)
			{
				var result = _serviceMut.UpdateAsync(guna2TextBox2.Text, Id);
				if (result != null)
				{
					AutoClosingMessageBox.Show("Muvaffaqiyatli yangilandi", "O'zgartirish", 500);
					this.Close();
				}
				else
				{
					MessageBox.Show("Iltimos maydonni toldiring");
				}
			}
			if (dlg == DialogResult.Cancel)
			{
				this.Close();
			}
			
		}


	}
}
