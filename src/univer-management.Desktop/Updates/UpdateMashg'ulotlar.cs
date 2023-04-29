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

namespace univer_management.Desktop.Updates
{
    public partial class UpdateMashg_ulotlar : Form
    {
        MashgulotService mashgulotService;
        public UpdateMashg_ulotlar()
        {
            mashgulotService = new MashgulotService();
            InitializeComponent();
        }
        public string Name { get; set; }
        public long Id { get; set; }

        private void Mashgulot()
        {
            DialogResult dlg = MessageBox.Show("Mashg'ulot nomini o'zgartirishni xoxlaysizmi??", "редактировать", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var result = mashgulotService.UpdateAsync(gunatextBox.Text, Id);
                if (result != null)
                {
                    AutoClosingMessageBox.Show("Mashg'ulot yangilandi", "O'zgartirish", 500);
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
        private void UpdateMashg_ulotlar_Load(object sender, EventArgs e)
        {
            gunatextBox.Text=Name;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
                Mashgulot();
                this.Close();
            
        }
    }
}
