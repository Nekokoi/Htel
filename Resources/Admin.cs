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
    public partial class Admin : Form
    {
        private OleDbConnection conn;
        private OleDbCommand cmd = new OleDbCommand();
        private string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Mydatabase\MyDatabase.mdb";

        public Admin()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
         
            string IDE = IDA.Text;
            string PSA1 = PsA.Text;
            string PSA2 = PsA2.Text;
            cmd.Connection = conn;





 




            cmd.CommandText = "SELECT * FROM Admin_TB WHERE ID_R ='" + IDE + "'";
            OleDbDataAdapter HOW = new OleDbDataAdapter(cmd);
            DataSet QryDataM = new DataSet();
            HOW.Fill(QryDataM);




            cmd.CommandText = "SELECT * FROM Admin_TB WHERE Ps_R ='" + PSA1 + "'";
            OleDbDataAdapter HOR = new OleDbDataAdapter(cmd);
            DataSet QryDataN = new DataSet();
            HOR.Fill(QryDataN);




            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Admin_TB WHERE Ps2_R ='" + PSA2 + "'";
            OleDbDataAdapter HO = new OleDbDataAdapter(cmd);
            DataSet QryDataB = new DataSet();
            HO.Fill(QryDataB);
            
            if (QryDataB.Tables[0].Rows.Count > 0 & QryDataN.Tables[0].Rows.Count > 0  & QryDataM.Tables[0].Rows.Count > 0)
            {
                this.panel1.Controls.Clear();
                Form13 formRHJ = new Form13();
                formRHJ.TopLevel = false;
                formRHJ.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(formRHJ);
                formRHJ.Show();
                PsA.ReadOnly = true;
                PsA2.ReadOnly = true;
                IDA.ReadOnly = true;
      
                button22.Enabled = false;
                button1.Enabled = true;            }
            else {
                MessageBox.Show("ท่านกรอกรหัสไม่ถูกต้อง");
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult UIO = new DialogResult();
            UIO = MessageBox.Show("คุณแน่ใจหรอว่าทำการเปลี่ยนข้อมูลหรือแก้ไขให้รับรอวต่อการใช้งานแล้ว", "กำลังออกจากระบบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UIO == DialogResult.Yes) { this.panel1.Controls.Clear();
                button22.Enabled = true;
                PsA.ReadOnly = false;
                PsA2.ReadOnly = false;
                IDA.ReadOnly = false;
             
                PsA.Text ="";
                PsA2.Text = ""; 
                IDA.Text = "";
     
                button1.Enabled = false;

            }

        }
    }
}
