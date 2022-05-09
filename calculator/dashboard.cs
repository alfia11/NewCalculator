using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            Form1 d = new Form1();
            //d.MdiParent = this;
            d.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

           

            if (label1.Text == "USER")
            {
                


                MessageBox.Show("user didnot have the provision to access user details");
            }
            else if (label1.Text == "ADMIN")
            {
                button2.Visible = true;
                //this.IsMdiContainer = true;
                Admin a = new Admin();
                //a.MdiParent = this;
                a.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client1 c = new client1();
            c.Show();
            server s = new server();
            s.Show();
        }
    }
}
