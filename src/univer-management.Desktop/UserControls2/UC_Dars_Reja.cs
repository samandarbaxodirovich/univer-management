using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_Dars_Reja : UserControl
    {
        public UC_Dars_Reja()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Siz 1 para darsni kiritmoqchimi siz","Ogohlantirish",MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
                yaratishForm.comboBox1.SelectedIndex = 0;
                yaratishForm.ShowDialog();
            }
            return;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Siz 2 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
                yaratishForm.comboBox1.SelectedIndex = 1;
                yaratishForm.ShowDialog();
            }
            return;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Siz 3 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
                yaratishForm.comboBox1.SelectedIndex = 2;
                yaratishForm.ShowDialog();
            }
            return;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Siz 4 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
                yaratishForm.comboBox1.SelectedIndex = 3;
                yaratishForm.ShowDialog();
            }
            return;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Siz 5 para darsni kiritmoqchimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                Dars_RejaYaratishForm yaratishForm = new Dars_RejaYaratishForm();
                yaratishForm.comboBox1.SelectedIndex = 4;
                yaratishForm.ShowDialog();
            }
            return;
        }
    }
}
