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
    public partial class Chang : Form
    {
        private OleDbConnection conn;
        private OleDbCommand cmd = new OleDbCommand();
        //ขั้นตอนที่ 3 กำหนด ConnectionSString สำหรับชื่อที่อยู่ของ ฐานข้อมูล
        private string ConnectionString =
            @"provider=Microsoft.jet.OLEDB.4.0;Data Source=C:\Mydatabase\MyDatabase.mdb";
        public Chang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UP = OP.Text;
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            //ดึงบาร์โคดมาเก็บไว้ในตัวแปร
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Staff_TB WHERE PS_R='" + UP + "'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            DataSet QryData = new DataSet();

            adapter.Fill(QryData);

            if (QryData.Tables[0].Rows.Count > 0)
            {
                if (NP.Text == CP.Text)
                {
                    string OK = User.Text;

                    conn = new OleDbConnection(ConnectionString);
                    conn.Open();
                    OleDbCommand cmdUpdate = new OleDbCommand();
                    cmdUpdate.Connection = conn;
                    cmdUpdate.CommandText = " UPDATE Staff_TB SET  PS_R = @PS  WHERE ID_R = '" + OK + "'";


                    cmdUpdate.Parameters.AddWithValue("@PS", NP.Text);
                    int state = cmdUpdate.ExecuteNonQuery();
                    if (state > 0)
                    {
                        MessageBox.Show("แก้แล้ว");
                    }
                    else
                    {
                        MessageBox.Show("มีข้อผิดผลาด");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            //ดึงบาร์โคดมาเก็บไว้ในตัวแปร
            string U = User.Text;
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Staff_TB WHERE ID_R='" + U + "'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

            DataSet QryData = new DataSet();

            adapter.Fill(QryData);

            if (QryData.Tables[0].Rows.Count != 0)
            {
                OP.ReadOnly = false;
                NP.ReadOnly = false;
                CP.ReadOnly = false;
            }
            else{

                MessageBox.Show("มาส");
            }
        }

        private void Chang_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

