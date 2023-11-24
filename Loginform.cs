using Attendance_system.DataSet1TableAdapters;
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
    public partial class Loginform : Form
    {
        public bool Loginflag { get; set; }
        public int UserId { get; set; }
        public Loginform()
        {
            InitializeComponent();
            Loginflag = false;
        }

        private void Loginform_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AttendeeTableAdapter UserAD = new DataSet1TableAdapters.AttendeeTableAdapter();
            DataTable Dt = UserAD.GetDatabyuserandpass(metroTextBox1.Text, metroTextBox2.Text);

            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                UserId = int.Parse(Dt.Rows[0]["UserId"].ToString());    
                Loginflag = true;
                
            }
            else
            {
                Loginflag = false;
                MessageBox.Show("Login unsuccessful");
            }
            Close();    
        }
    }
}
