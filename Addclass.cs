using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_system
{
    public partial class Addclass : Form
    {
        public int UserId { get; set; }
        public Addclass()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClassesTableAdapter ClassAd = new DataSet1TableAdapters.ClassesTableAdapter();
            ClassAd.Addclass(metroTextBox1.Text, UserId);
            MessageBox.Show("Class added successfully");
            Close();
        }
    }
}
