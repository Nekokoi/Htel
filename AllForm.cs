using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOH
{
    public partial class AllForm : Form
    {
        public AllForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Staff formRHJ = new Staff();
            formRHJ.TopLevel = false;
            formRHJ.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(formRHJ);
            formRHJ.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Admin HI = new Admin();
            HI.TopLevel = false;
            HI.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(HI);
            HI.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            CEOlog HIE = new CEOlog();
            HIE.TopLevel = false;
            HIE.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(HIE);
            HIE.Show();
        }
    }
}
