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
    public partial class Form1 : Form
    {
        private OleDbConnection conn;
        private OleDbCommand cmd = new OleDbCommand();
        // private string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Mydatabase\MyDatabase.mdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {

        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {






        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public static implicit operator Form1(bool v)
        {
            throw new NotImplementedException();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }



        private void button21_Click_1(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string timeText = DateTime.Now.ToLongTimeString();  //เวลา


        }

        private void da_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            timer1.Start();
            timer2.Start();
            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM 102_TB WHERE R_Resident_F";

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            DataSet QryData = new DataSet();

            adapter.Fill(QryData);

            if (QryData.Tables[0].Rows.Count != 0)
            {
                button42.BackColor = Color.Red;
                button29.Enabled = true;
                button29.BackColor = Color.Yellow;
                button42.Enabled = false;
                conn.Close();
            }
            string dbpathE = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringE = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpathE + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringE);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM 101_TB WHERE R_Resident_F";

            OleDbDataAdapter adapterE = new OleDbDataAdapter(cmd);

            DataSet QryDataE = new DataSet();

            adapterE.Fill(QryDataE);

            if (QryDataE.Tables[0].Rows.Count != 0)
            {
                button33.BackColor = Color.Red;
                button32.Enabled = true;
                button32.BackColor = Color.Yellow;
                button33.Enabled = false;
                conn.Close();
            }
            string dbpathe = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringe = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpathe + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringe);
            conn.Open();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM 103_TB WHERE R_Resident_F";

            OleDbDataAdapter adapterEE = new OleDbDataAdapter(cmd);

            DataSet QryDataEE = new DataSet();

            adapterEE.Fill(QryDataEE);

            if (QryDataEE.Tables[0].Rows.Count != 0)
            {
                button41.BackColor = Color.Red;
                button30.Enabled = true;
                button30.BackColor = Color.Yellow;
                button41.Enabled = false;
                conn.Close();
            }
            string dbpatheW = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringeW = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpatheW + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringeW);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM 104_TB WHERE R_Resident_F";

            OleDbDataAdapter adapterEEE = new OleDbDataAdapter(cmd);

            DataSet QryDataEEE = new DataSet();

            adapterEEE.Fill(QryDataEEE);

            if (QryDataEEE.Tables[0].Rows.Count != 0)
            {
                button40.BackColor = Color.Red;
                button23.Enabled = true;
                button23.BackColor = Color.Yellow;
                button40.Enabled = false;
                conn.Close();
            }
            string dbpatheF = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringeF = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpatheF + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringeF);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM 105_TB WHERE R_Resident_F";

            OleDbDataAdapter adapterEEEE = new OleDbDataAdapter(cmd);

            DataSet QryDataEEEE = new DataSet();

            adapterEEEE.Fill(QryDataEEEE);

            if (QryDataEEEE.Tables[0].Rows.Count != 0)
            {
                button39.BackColor = Color.Red;
                button24.Enabled = true;
                button24.BackColor = Color.Yellow;
                button39.Enabled = false;
                conn.Close();
            }
            string dbpatheQ = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringeQ = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpatheQ + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringeQ);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM 106_TB WHERE R_Resident_F";

            OleDbDataAdapter adapterEEEEG = new OleDbDataAdapter(cmd);

            DataSet QryDataEEEEG = new DataSet();

            adapterEEEEG.Fill(QryDataEEEEG);

            if (QryDataEEEEG.Tables[0].Rows.Count != 0)
            {
                button38.BackColor = Color.Red;
                button25.Enabled = true;
                button25.BackColor = Color.Yellow;
                button38.Enabled = false;
                conn.Close();
            }
            string dbpatheEE = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringeEE = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpatheEE + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringeEE);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM 107_TB WHERE R_Resident_F";

            OleDbDataAdapter adapterEEEEGH = new OleDbDataAdapter(cmd);

            DataSet QryDataEEEEGH = new DataSet();

            adapterEEEEGH.Fill(QryDataEEEEGH);

            if (QryDataEEEEGH.Tables[0].Rows.Count != 0)
            {
                button37.BackColor = Color.Red;
                button26.Enabled = true;
                button26.BackColor = Color.Yellow;
                button37.Enabled = false;
                conn.Close();
            }
            string dbpatheC = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringeC = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpatheC + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringeC);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM 108_TB WHERE R_Resident_F";

            OleDbDataAdapter a = new OleDbDataAdapter(cmd);

            DataSet Q = new DataSet();

            a.Fill(Q);

            if (Q.Tables[0].Rows.Count != 0)
            {
                button36.BackColor = Color.Red;
                button27.Enabled = true;
                button27.BackColor = Color.Yellow;
                button36.Enabled = false;
                conn.Close();
            }
            string dbpatheX = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringeX = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpatheX + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringeX);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM 109_TB WHERE R_Resident_F";

            OleDbDataAdapter aa = new OleDbDataAdapter(cmd);

            DataSet Qa = new DataSet();

            aa.Fill(Qa);

            if (Qa.Tables[0].Rows.Count != 0)
            {
                button35.BackColor = Color.Red;
                button28.Enabled = true;
                button28.BackColor = Color.Yellow;
                button35.Enabled = false;
                conn.Close();
            }
            string dbpatheP = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringeP = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpatheP + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringeP);
            conn.Open();
            cmd.Connection = conn; cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM 110_TB WHERE R_Resident_F";

            OleDbDataAdapter aas = new OleDbDataAdapter(cmd);

            DataSet Qas = new DataSet();

            aas.Fill(Qas);

            if (Qas.Tables[0].Rows.Count != 0)
            {
                button34.BackColor = Color.Red;
                button31.Enabled = true;
                button31.BackColor = Color.Yellow;
                button34.Enabled = false;
                conn.Close();
            }
        }

        private void button21_Click_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click_1(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();

            Form2 form = new Form2();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(form);
            form.Show();

            button33.BackColor = Color.Red;
            button32.Enabled = true;
            button32.BackColor = Color.Yellow;
            button33.Enabled = false;
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form3 formR = new Form3();
            formR.TopLevel = false;
            formR.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formR);
            formR.Show();
            button42.BackColor = Color.Red;
            button29.Enabled = true;
            button29.BackColor = Color.Yellow;
            button42.Enabled = false;
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form4 formR = new Form4();
            formR.TopLevel = false;
            formR.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formR);
            formR.Show();
            button41.BackColor = Color.Red;
            button30.Enabled = true;
            button30.BackColor = Color.Yellow;
            button41.Enabled = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form5 formRH = new Form5();
            formRH.TopLevel = false;
            formRH.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formRH);
            formRH.Show();
            button40.BackColor = Color.Red;
            button23.Enabled = true;
            button23.BackColor = Color.Yellow;
            button40.Enabled = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form6 formRJ = new Form6();
            formRJ.TopLevel = false;
            formRJ.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formRJ);
            formRJ.Show();
            button39.BackColor = Color.Red;
            button24.Enabled = true;
            button24.BackColor = Color.Yellow;
            button39.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form7 formRZ = new Form7();
            formRZ.TopLevel = false;
            formRZ.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formRZ);
            formRZ.Show();
            button38.BackColor = Color.Red;
            button25.Enabled = true;
            button25.BackColor = Color.Yellow;
            button38.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form8 formRL = new Form8();
            formRL.TopLevel = false;
            formRL.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formRL);
            formRL.Show();
            button37.BackColor = Color.Red;
            button26.Enabled = true;
            button26.BackColor = Color.Yellow;
            button37.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form9 formRHJ = new Form9();
            formRHJ.TopLevel = false;
            formRHJ.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formRHJ);
            formRHJ.Show();
            button36.BackColor = Color.Red;
            button27.Enabled = true;
            button27.BackColor = Color.Yellow;
            button36.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form10 formR1 = new Form10();
            formR1.TopLevel = false;
            formR1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formR1);
            formR1.Show();
            button35.BackColor = Color.Red;
            button28.Enabled = true;
            button28.BackColor = Color.Yellow;
            button35.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form11 formR456 = new Form11();
            formR456.TopLevel = false;
            formR456.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formR456);
            formR456.Show();
            button34.BackColor = Color.Red;
            button31.Enabled = true;
            button31.BackColor = Color.Yellow;
            button34.Enabled = false;
        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void Who_TextChanged(object sender, EventArgs e)
        {

        }

        private void เขาสฐานขอมลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult UI = new DialogResult();
            UI = MessageBox.Show("คุณต้องการออกหรือไม่ Master?", "ออกป่าว", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UI == DialogResult.Yes) { this.Close(); }



        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 YU = new Form12();
            YU.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";
            button31.Enabled = false;
            button31.BackColor = Color.White;
            button34.Enabled = true;
            button34.BackColor = Color.White;
            button34.FlatStyle = FlatStyle.Popup;
            button31.FlatStyle = FlatStyle.Standard;
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM 110_TB";
            try
            {
                int state = cmd.ExecuteNonQuery();
                {//ดำเนินการใช้คำสั่งกับฐานข้อมูล
                    if (state > 0)
                    {
                    }
                }
            }


            catch (Exception)
            {

            }
}


                
            
        

        private void button32_Click(object sender, EventArgs e)
        {
            string dbpatheFFF = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringeFFF = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpatheFFF + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringeFFF);
            conn.Open();
            cmd.Connection = conn;
            button33.Enabled = true;
            button33.BackColor = Color.White;
            button32.Enabled = false;
            button32.BackColor = Color.White;
            button32.FlatStyle = FlatStyle.Popup;
            button33.FlatStyle = FlatStyle.Standard;
            cmd.CommandText = "DELETE FROM 101_TB";
            try
            {
                int state = cmd.ExecuteNonQuery();
                {//ดำเนินการใช้คำสั่งกับฐานข้อมูล
                    if (state > 0)
                    {

                    }


                }
            }

            catch (Exception) { }







        }

        private void button29_Click(object sender, EventArgs e)
        {
            string dbpatheB = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringeB = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpatheB + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringeB);
            conn.Open();
            cmd.Connection = conn;
            button42.Enabled = true;
            button42.BackColor = Color.White;
            button29.Enabled = false;
            button29.BackColor = Color.White;
            button29.FlatStyle = FlatStyle.Popup;
            button42.FlatStyle = FlatStyle.Standard;

            cmd.CommandText = "DELETE FROM 102_TB";
            try
            {
                int state = cmd.ExecuteNonQuery();
                {//ดำเนินการใช้คำสั่งกับฐานข้อมูล
                    if (state > 0)
                    {

                    }


                }
            }

            catch (Exception) { }





        }

        private void button30_Click(object sender, EventArgs e)
        {
            button41.Enabled = true;
            button41.BackColor = Color.White;
            button30.Enabled = false;
            button30.BackColor = Color.White;
            button30.FlatStyle = FlatStyle.Popup;
            button41.FlatStyle = FlatStyle.Standard;
            string dbpatheS = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionStringeS = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpatheS + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionStringeS);
            conn.Open();
            cmd.Connection = conn;
 

            cmd.CommandText = "DELETE FROM 103_TB";
            try
            {
                int state = cmd.ExecuteNonQuery();
                {//ดำเนินการใช้คำสั่งกับฐานข้อมูล
                    if (state > 0)
                    {

                    }


                }
            }

            catch (Exception) { }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            button40.Enabled = true;
            button40.BackColor = Color.White;
            button23.Enabled = false;
            button23.BackColor = Color.White;
            button23.FlatStyle = FlatStyle.Popup;
            button40.FlatStyle = FlatStyle.Standard;
                string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM 104_TB";
            try
            {
                int state = cmd.ExecuteNonQuery();
                {//ดำเนินการใช้คำสั่งกับฐานข้อมูล
                    if (state > 0)
                    {

                    }


                }
            }

            catch (Exception) { }
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";
            button39.Enabled = true;
            button39.BackColor = Color.White;
            button24.Enabled = false;
            button24.BackColor = Color.White;
            button24.FlatStyle = FlatStyle.Popup;
            button39.FlatStyle = FlatStyle.Standard;
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM 105_TB";
            try
            {
                int state = cmd.ExecuteNonQuery();
                {//ดำเนินการใช้คำสั่งกับฐานข้อมูล
                    if (state > 0)
                    {

                    }


                }
            }

            catch (Exception) { }
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";
            button25.Enabled = false;
            button25.BackColor = Color.White;
            button38.Enabled = true;
            button38.BackColor = Color.White;
            button38.FlatStyle = FlatStyle.Popup;
            button25.FlatStyle = FlatStyle.Standard;
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM 106_TB";
            try
            {
                int state = cmd.ExecuteNonQuery();
                {//ดำเนินการใช้คำสั่งกับฐานข้อมูล
                    if (state > 0)
                    {

                    }


                }
            }

            catch (Exception) { }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";
            button27.Enabled = false;
            button27.BackColor = Color.White;
            button36.Enabled = true;
            button36.BackColor = Color.White;
            button36.FlatStyle = FlatStyle.Popup;
            button27.FlatStyle = FlatStyle.Standard;
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM 108_TB";
            try
            {
                int state = cmd.ExecuteNonQuery();
                {//ดำเนินการใช้คำสั่งกับฐานข้อมูล
                    if (state > 0)
                    {

                    }


                }
            }

            catch (Exception) { }
        }
    


        private void button26_Click(object sender, EventArgs e)
        {
            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";
            button26.Enabled = false;
            button26.BackColor = Color.White;
            button37.Enabled = true;
            button37.BackColor = Color.White;
            button37.FlatStyle = FlatStyle.Popup;
            button26.FlatStyle = FlatStyle.Standard;
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM 107_TB";
            try
            {
                int state = cmd.ExecuteNonQuery();
                {//ดำเนินการใช้คำสั่งกับฐานข้อมูล
                    if (state > 0)
                    {

                    }


                }
            }

            catch (Exception) { }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";
            button28.Enabled = false;
            button28.BackColor = Color.White;
            button35.Enabled = true;
            button35.BackColor = Color.White;
            button35.FlatStyle = FlatStyle.Popup;
            button28.FlatStyle = FlatStyle.Standard;
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM 109_TB";
            try
            {
                int state = cmd.ExecuteNonQuery();
                {//ดำเนินการใช้คำสั่งกับฐานข้อมูล
                    if (state > 0)
                    {

                    }


                }
            }

            catch (Exception) { }
        }
    }
}
