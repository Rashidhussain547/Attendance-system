namespace Attendance_system
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Attendance_system.DataSet1();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Statuslbluser = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classesTableAdapter = new Attendance_system.DataSet1TableAdapters.ClassesTableAdapter();
            this.recordsTableAdapter = new Attendance_system.DataSet1TableAdapters.RecordsTableAdapter();
            this.classesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(776, 429);
            this.metroTabControl1.TabIndex = 1;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButton5);
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.Controls.Add(this.statusStrip1);
            this.metroTabPage1.Controls.Add(this.metroButton4);
            this.metroTabPage1.Controls.Add(this.metroButton3);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.dateTimePicker1);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroComboBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(768, 390);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Attendance";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(440, 37);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 23);
            this.metroButton5.TabIndex = 13;
            this.metroButton5.Text = "Get values";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 269);
            this.dataGridView1.TabIndex = 12;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataMember = "Records";
            this.recordsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Statuslbluser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 368);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "User:";
            // 
            // Statuslbluser
            // 
            this.Statuslbluser.Name = "Statuslbluser";
            this.Statuslbluser.Size = new System.Drawing.Size(0, 17);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(674, 52);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(75, 23);
            this.metroButton4.TabIndex = 10;
            this.metroButton4.Text = "Add student";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(674, 23);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 9;
            this.metroButton3.Text = "Add class";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(338, 342);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Clear";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(257, 342);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Save";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(205, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "select date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Select class";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.classesBindingSource;
            this.metroComboBox1.DisplayMember = "ClassName";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(0, 37);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(185, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.ValueMember = "ClassId";
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.dataSet1;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.Controls.Add(this.metroButton6);
            this.metroTabPage2.Controls.Add(this.label2);
            this.metroTabPage2.Controls.Add(this.dateTimePicker2);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.metroComboBox2);
            this.metroTabPage2.Controls.Add(this.listView1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(768, 390);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Reports";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(690, 36);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(75, 23);
            this.metroButton6.TabIndex = 7;
            this.metroButton6.Text = "Get values";
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date and day";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(350, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select class";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.DataSource = this.classesBindingSource1;
            this.metroComboBox2.DisplayMember = "ClassName";
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(3, 36);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(194, 29);
            this.metroComboBox2.TabIndex = 3;
            this.metroComboBox2.ValueMember = "ClassId";
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(768, 263);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Presence";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Absence";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Late";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Excuse";
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // recordsTableAdapter
            // 
            this.recordsTableAdapter.ClearBeforeFill = true;
            // 
            // classesBindingSource1
            // 
            this.classesBindingSource1.DataMember = "Classes";
            this.classesBindingSource1.DataSource = this.dataSet1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 509);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Text = "Attendance system";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Statuslbluser;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private DataSet1TableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource recordsBindingSource;
        private DataSet1TableAdapters.RecordsTableAdapter recordsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroButton metroButton6;
        private System.Windows.Forms.BindingSource classesBindingSource1;
    }
}

