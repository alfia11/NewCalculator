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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                
                    SqlConnection conn = new SqlConnection(str);
                    conn.Open();
                    SqlDataAdapter ada = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();

                    ada = new SqlDataAdapter("Select * from sign where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'and usertype='admin'", conn);
                    DataTable dt = new DataTable();
                
                    ada.Fill(dt);

                    if (dt.Rows.Count != 0)
                    {

                    //if (textBox1.Text == "admins" && textBox2.Text == "admin")
                    //{
                    //this.Hide();
                    //Admin g = new Admin();
                    //g.Show();
                    
                    dashboard d = new dashboard();
                    d.label1.Text = dt.Rows[0]["usertype"].ToString();
                    d.label2.Text ="Welcome  "  +   dt.Rows[0]["name"].ToString();
                    d.Show();
                    }






                    //SqlConnection conn = new SqlConnection(str);
                    //conn.Open();
                    //SqlDataAdapter ada = new SqlDataAdapter();
                    //SqlCommand cmd = new SqlCommand();
                    else
                    {



                        ada = new SqlDataAdapter("Select * from sign where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'and usertype='user'", conn);
                        //DataTable dt = new DataTable();
                        ada.Fill(dt);
                    
                        if (dt.Rows.Count == 1)
                        {

                        //this.Hide();
                        //Form1 f1 = new Form1();
                        //f1.label1.Text = textBox1.Text;
                        //f1.Show();
                        dashboard d = new dashboard();
                        d.label1.Text = dt.Rows[0]["usertype"].ToString();
                        d.label2.Text = "Welcome  " + dt.Rows[0]["name"].ToString();
                        d.Show();
                    }
                    }


                //dashboard s = new dashboard();
                //    s.Show();
                








                //else
                //{
                //    MessageBox.Show("username and password incorrect");
                //}







                



            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form3 f = new Form3();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ADMIn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
