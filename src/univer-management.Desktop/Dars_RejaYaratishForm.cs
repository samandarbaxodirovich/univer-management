using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace univer_management.Desktop
{
    public partial class Dars_RejaYaratishForm : Form
    {
        public Dars_RejaYaratishForm()
        {
            InitializeComponent();
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DarsRejabtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="1")
            {
               MessageBox.Show("1 Parani qo'shishga rozimi siz","Ogohlantirish",MessageBoxButtons.OKCancel);
                    this.Close();
            }
           else if (comboBox1.Text == "2")
            {
                MessageBox.Show("2 Parani qo'shishga rozimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
                this.Close();
            }
           else if (comboBox1.Text == "3")
            {
                MessageBox.Show("3 Parani qo'shishga rozimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
                this.Close();
            }
           else if (comboBox1.Text == "4")
            {
                MessageBox.Show("4 Parani qo'shishga rozimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
                this.Close();
            }
            else if (comboBox1.Text == "5")
            {
                MessageBox.Show("5 Parani qo'shishga rozimi siz", "Ogohlantirish", MessageBoxButtons.OKCancel);
                this.Close();
            }
        }
    }
}
