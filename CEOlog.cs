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
    public partial class CEOlog : Form
    {
        private OleDbConnection conn;
        private OleDbCommand cmd = new OleDbCommand();
        private string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Mydatabase\MyDatabase.mdb";

        public CEOlog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(ConnectionString);
            conn.Open();
            string WE = MMM.Text;
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Admin_TB WHERE WhoAdmin_R ='" + WE + "'";
            OleDbDataAdapter HOEF = new OleDbDataAdapter(cmd);
            DataSet QryData = new DataSet();
            HOEF.Fill(QryData);
            if (QryData.Tables[0].Rows.Count > 0)
            {


                this.panel1.Controls.Clear();
                CEO formRHJ = new CEO();
                formRHJ.TopLevel = false;
                formRHJ.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(formRHJ);
                formRHJ.Show();
            }
            else { MessageBox.Show("ตรวจสอบใหม่"); }
        }
    }
}
