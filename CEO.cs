using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HOH
{
    public partial class Form13 : Form
    {
        private OleDbConnection conn;
        
        private OleDbCommand cmd = new OleDbCommand();
       // private string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Mydatabase\MyDatabase.mdb";

        OleDbDataAdapter NB;
        OleDbCommandBuilder TN;
        DataTable TB;
        OleDbDataAdapter NA;
        DataTable TPA;
        OleDbCommandBuilder HO;
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Mydatabase\\MyDatabase.mdb");
            string dbpath2 = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath2 + ";Jet OLEDB:Database Password=password;";

            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            NB = new OleDbDataAdapter("SELECT F_Room as ห้อง,R_Resident_F as ชื่อ,R_Resident_L as นามสกุล,R_Resident_cardnumber as บัตรประชาชน,R_Resident_Email as Email,R_Resident_TP as เบอร์โทรศัพ,D_R as วัน,M_R as เดือน,Y_R as ปี FROM All_TB", conn);


            DialogResult mb = new DialogResult();
            mb = MessageBox.Show("You Want?", "sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mb == DialogResult.Yes)
            {
                TN = new OleDbCommandBuilder(NB);
                NB.Update(TB);
                TB = new DataTable();
                NB.Fill(TB);
                dataGridView1.DataSource = TB;
                MessageBox.Show("ทำการ UPDATE แล้ว");
            }
            else { }

        }

        private void Form13_Load(object sender, EventArgs e)
        {

            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";

            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            NB = new OleDbDataAdapter("SELECT F_Room as ห้อง,R_Resident_F as ชื่อ,R_Resident_L as นามสกุล,R_Resident_cardnumber as บัตรประชาชน,R_Resident_Email as Email,R_Resident_TP as เบอร์โทรศัพ,D_R as วัน,M_R as เดือน,Y_R as ปี FROM All_TB", conn);
            NA = new OleDbDataAdapter("SELECT ID_R as ID,PS_R as Pssword FROM Staff_TB", conn);
            TB = new DataTable();
            TPA = new DataTable();
            NB.Fill(TB);
            NA.Fill(TPA);
            dataGridView1.DataSource = TB;
            dataGridView2.DataSource = TPA;
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Mydatabase\\MyDatabase.mdb");
            string dbpathS = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpathS + ";Jet OLEDB:Database Password=password;";

            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            NB = new OleDbDataAdapter("SELECT F_Room as ห้อง,R_Resident_F as ชื่อ,R_Resident_L as นามสกุล,R_Resident_cardnumber as บัตรประชาชน,R_Resident_Email as Email,R_Resident_TP as เบอร์โทรศัพ,D_R as วัน,M_R as เดือน,Y_R as ปี FROM All_TB", conn);

            TB = new DataTable();
            NB.Fill(TB);
            dataGridView1.DataSource = TB;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string key = MMO.Text;

            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";

            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM All_TB WHERE R_Resident_F LIKE '%" + key + "%' ";


            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            DataSet QryData = new DataSet();

            adapter.Fill(QryData);

            dataGridView1.DataSource = QryData.Tables[0];

            dataGridView1.Update();

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            string dbpathA = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpathA + ";Jet OLEDB:Database Password=password;";

            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            NA = new OleDbDataAdapter("SELECT ID_R,PS_R FROM Staff_TB", conn);


            DialogResult mb = new DialogResult();
            mb = MessageBox.Show("You Want?", "sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mb == DialogResult.Yes)
            {
                HO = new OleDbCommandBuilder(NA);
                NA.Update(TPA);
                TPA = new DataTable();
                NA.Fill(TPA);
                dataGridView2.DataSource = TPA;
                MessageBox.Show("ทำการ UPDATE แล้ว");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string M = DateTime.Now.ToLongTimeString();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            DialogResult NNO = new DialogResult();
                NNO = MessageBox.Show("คุณแน่ใจหรอว่าทำการปรับเปลี่ยนข้อมูลอย่างถูกต้องแล้ว?", "ออกจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (NNO == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string dbpathF = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpathF + ";Jet OLEDB:Database Password=password;";

            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            NA = new OleDbDataAdapter("SELECT ID_R as ID,PS_R as Password FROM Staff_TB", conn);
            TPA = new DataTable();
            NA.Fill(TPA);
            dataGridView2.DataSource=TPA;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string keyU = HOT.Text;
            string dbpathM = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpathM + ";Jet OLEDB:Database Password=password;";


            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM Staff_TB WHERE ID_R LIKE '%" + keyU + "%' ";


            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            DataSet QryData = new DataSet();

            adapter.Fill(QryData);

            dataGridView2.DataSource = QryData.Tables[0];

            dataGridView2.Update();

            conn.Close();
        }

        private void ออกจากโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult N = new DialogResult();
            N = MessageBox.Show("คุณแน่ในหรอว่าทำการแก้ไขข้อมูลถูกต้องและเหมาะกับการใช้งานแล้ว", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (N == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void DN_Click(object sender, EventArgs e)
        {
  
        }

        private void Re_Click(object sender, EventArgs e)
        {

            string dbpathFW = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpathFW + ";Jet OLEDB:Database Password=password;";

            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            NA = new OleDbDataAdapter("SELECT ID_R,PS_R FROM Staff_TB", conn);
            TPA = new DataTable();
            NA.Fill(TPA);
            dataGridView2.DataSource = TPA;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
