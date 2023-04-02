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
    public partial class Form2 : Form
    {
        private OleDbConnection conn;
        private OleDbCommand cmd = new OleDbCommand();
        //private string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Mydatabase\MyDatabase.mdb";


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string dbpath = AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.mdb";
            string ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" + dbpath + ";Jet OLEDB:Database Password=password;";
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO 101_TB (F_Room, R_Resident_F, R_Resident_L, R_Resident_cardnumber, R_Resident_Email, R_Resident_TP, D_R, M_R, Y_R) VALUES (@F_R,@R_FRe,@R_LRe,@R_cardRe,@R_ReEm,@R_ReTP,@D_R,@M_R,@Y_R)";
            cmd.Parameters.AddWithValue("@F_R", txtRnum.Text);
            cmd.Parameters.AddWithValue("@R_F", txtFname.Text);
            cmd.Parameters.AddWithValue("@R_FRe", txtLname.Text);
            cmd.Parameters.AddWithValue("@R_cardRe", txtcrdnum.Text);
            cmd.Parameters.AddWithValue("@R_ReEm", txtem.Text);
            cmd.Parameters.AddWithValue("@R_ReTP", txtTPN.Text);
            cmd.Parameters.AddWithValue("@D_R", txtD.Text);
            cmd.Parameters.AddWithValue("@M_R", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@Y_R", txtY.Text);
            try
            {
                int QryStatus = cmd.ExecuteNonQuery();

              

                if (QryStatus > 0)
                {
                   
                }
            }

            catch


            {
                MessageBox.Show("ไม่สามารถเพิ่มได้การุณาตรวจสอบข้อมูลที่กรอกมาด้วย");
                conn.Close();
            }


            string b = textBox7.Text;
            string h = textBox1.Text;
            string y = textBox6.Text;
            string k = textBox2.Text;
            string ph = textBox3.Text;
            string pct = textBox4.Text;
            string hmn = textBox5.Text;
            double answer = 0.00;

            cmd.CommandText = "INSERT INTO All_TB (F_Room, R_Resident_F, R_Resident_L, R_Resident_cardnumber, R_Resident_Email, R_Resident_TP, D_R, M_R, Y_R) VALUES (@F_R,@R_FRe,@R_LRe,@R_cardRe,@R_ReEm,@R_ReTP,@D_R,@M_R,@Y_R)";
            cmd.Parameters.AddWithValue("@F_R", txtRnum.Text);
            cmd.Parameters.AddWithValue("@R_F", txtFname.Text);
            cmd.Parameters.AddWithValue("@R_FRe", txtLname.Text);
            cmd.Parameters.AddWithValue("@R_cardRe", txtcrdnum.Text);
            cmd.Parameters.AddWithValue("@R_ReEm", txtem.Text);
            cmd.Parameters.AddWithValue("@R_ReTP", txtTPN.Text);
            cmd.Parameters.AddWithValue("@D_R", txtD.Text);
            cmd.Parameters.AddWithValue("@M_R", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@Y_R", txtY.Text);
            try
            {
                int QryStatus = cmd.ExecuteNonQuery();
                if (txtD.Text.Equals(""))
                {
                    double N = 0.00;
                   
                    string OP = txtD.Text;
                    N = Double.Parse(OP);
                    answer = N * 350;
                }
                else {
                    if (checkBox1.Checked == false)
                    {

                    }
                    else {
                        double J = 0.00;

                        J = Double.Parse(b);
                        answer = J * 50 + answer;

                    }
                    if (checkBox2.Checked == false)
                    {

                    }
                    else
                    {
                        double JE = 0.00;

                        JE = Double.Parse(h);
                        answer = JE * 500 + answer;

                    }
                    if (checkBox3.Checked == false)
                    {

                    }
                    else
                    {
                        double JH = 0.00;

                        JH = Double.Parse(y);
                        answer = JH * 1000 + answer;

                    }
                    if (checkBox4.Checked == false)
                    {

                    }
                    else
                    {
                        double JJ = 0.00;

                        JJ = Double.Parse(k);
                        answer = JJ * 20 + answer;

                    }
                    if (checkBox5.Checked == false)
                    {

                    }
                    else
                    {
                        double JM = 0.00;

                        JM = Double.Parse(ph);
                        answer = JM * 100 + answer;

                    }
                    if (checkBox6.Checked == false)
                    {

                    }
                    else
                    {
                        double JG = 0.00;

                        JG = Double.Parse(pct);
                        answer = JG * 50 + answer;

                    }
                    if (checkBox7.Checked == false)
                    {

                    }
                    else
                    {
                        double JL = 0.00;

                        JL = Double.Parse(hmn);
                        answer = JL * 50 + answer;

                    }





                    if (QryStatus > 0) ;
                    {
                        MessageBox.Show("ค่าบริการ" + answer);
                        this.Close();
                    }
                }
            }









            catch
            {

            }
        }
    

        
        
        
        
        
                        
         
        
        
        
        


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrdnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTPN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("ล้างข้อมูลที่กรอกมา?"
                , "Clear Data"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DMP();

            }



}
            private void DMP()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtTPN.Text = "";
            txtcrdnum.Text = "";
            txtD.Text = "";
            txtem.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

