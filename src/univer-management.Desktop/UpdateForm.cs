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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        public string name { get; set; }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            guna2TextBox2.Text = name;
        }
    }
}
