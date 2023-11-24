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
    public partial class StudentForm : Form
    {
        public int classId { get; set; }
        public string className { get; set; }
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dataSet1.Students);
            metroLabel2.Text = className.ToString();
            this.metroLabel4.Text = classId.ToString();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.studentsBindingSource.EndEdit();
            this.studentsTableAdapter.Update(dataSet1.Students);
            MessageBox.Show("Student added successfully");
        }
    }
}
