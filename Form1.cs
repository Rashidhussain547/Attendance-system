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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public int LoggedIn { get; set; }
        public int UserId { get; set; }
        public Form1()
        {
            InitializeComponent();
            LoggedIn = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (LoggedIn == 0)
            {
               
                Loginform newLogin = new Loginform();
                newLogin.ShowDialog();
               
                if (newLogin.Loginflag == false)
                {
                    Close();
                }
                else
                {
                  UserId = newLogin.UserId;
                  Statuslbluser.Text = UserId.ToString();
                  LoggedIn = 1;

                  // TODO: This line of code loads data into the 'dataSet1.Classes' table. You can move, or remove it, as needed.
                  this.classesTableAdapter.Fill(this.dataSet1.Classes);
                  classesBindingSource.Filter = "UserId = '" + UserId.ToString() + "'";
                }
                
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Addclass addclass = new Addclass();
            addclass.UserId = this.UserId;
            addclass.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            RecordsTableAdapter AttAd = new RecordsTableAdapter();
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    AttAd.UpdateQuery(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(), (int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                    
                }

            }
            DataTable dt_new = AttAd.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }
        

        private void metroButton4_Click(object sender, EventArgs e)
        {
            StudentForm stdform = new StudentForm();
            stdform.className = metroComboBox1.Text;
            stdform.classId = (int)metroComboBox1.SelectedValue;
            stdform.ShowDialog();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            RecordsTableAdapter AttAd = new RecordsTableAdapter();
            DataTable dt = AttAd.GetDataBy((int)metroComboBox1.SelectedValue,dateTimePicker1.Text);
            if(dt.Rows.Count > 0)
            {
                DataTable dt_new = AttAd.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;
            }
            else
            {
                StudentsTableAdapter stdAd = new StudentsTableAdapter();
                DataTable dt_Students = stdAd.GetDataByClassId((int)metroComboBox1.SelectedValue);
                foreach(DataRow dr in dt_Students.Rows)
                {
                    AttAd.InsertQuery((int)dr[0], (int)metroComboBox1.SelectedValue, dateTimePicker1.Text, "", dr[1].ToString(), metroComboBox1.Text);
                }
                DataTable dt_new = AttAd.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;
            }

            


            // TODO: This line of code loads data into the 'dataSet1.Records' table. You can move, or remove it, as needed.
            //this.recordsTableAdapter.Fill(this.dataSet1.Records);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            RecordsTableAdapter AttAd = new RecordsTableAdapter();
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    AttAd.UpdateQuery("", dr.Cells[1].Value.ToString(), (int)metroComboBox1.SelectedValue, dateTimePicker1.Text);

                }

            }
            DataTable dt_new = AttAd.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           
            
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            StudentsTableAdapter stdAd = new StudentsTableAdapter();
            DataTable dt_Students = stdAd.GetDataByClassId((int)metroComboBox2.SelectedValue);

            RecordsTableAdapter AttAd = new RecordsTableAdapter();
            int P = 0;
            int A = 0;
            int L = 0;
            int E = 0;
            foreach (DataRow dr in dt_Students.Rows)
            {
                P = (int)AttAd.GetDataByReports(dateTimePicker2.Value.Month, dr[0].ToString(), "Present").Rows[0][6];

                A = (int)AttAd.GetDataByReports(dateTimePicker2.Value.Month, dr[0].ToString(), "Absent").Rows[0][6];

                L = (int)AttAd.GetDataByReports(dateTimePicker2.Value.Month, dr[0].ToString(), "Leave").Rows[0][6];

                E = (int)AttAd.GetDataByReports(dateTimePicker2.Value.Month, dr[0].ToString(), "Excused").Rows[0][6];

                ListViewItem Litem = new ListViewItem();
                Litem.Text = dr[1].ToString();
                Litem.SubItems.Add(P.ToString());
                Litem.SubItems.Add(A.ToString());
                Litem.SubItems.Add(L.ToString());
                Litem.SubItems.Add(E.ToString());
                listView1.Items.Add(Litem);
            }
        }
    }
}
