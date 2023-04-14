using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using univer_management.Service.Services;

namespace univer_management.Desktop.UserControls2
{
    public partial class UC_O_qituvchilar : UserControl
    {
        private readonly TeacherService _service;
        public UC_O_qituvchilar()
        {
            InitializeComponent();
            _service = new TeacherService();
            InsertTeachers();
        }

        private void AllTeachers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void InsertTeachers()
        {
            var teachers = _service.GetAllTeachers();
            AllTeachers.DataSource = teachers;
        }
    }
}
