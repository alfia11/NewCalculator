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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        SqlCommand cmd;
        SqlConnection conn;
        // conn;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    SqlConnection conn = new SqlConnection(str);
            //    SqlCommand cmd = new SqlCommand();


            //    conn.Open();


            //}
            //catch (Exception)
            //{

            //}
            

                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("fields may not be empty!!!!");
            }
            if (textBox3.Text == textBox4.Text)
            {
                label7.Text = "matched";
            }
            else
            {
                label7.Text = "mismatching";
            }
            if (textBox1.Text == "")
            {
                label6.Text = "name must not be empty";
            }
            else
            {
                System.Text.RegularExpressions.Regex username = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][a-zA-Z]{5,11}");
                if (!username.IsMatch(textBox1.Text))
                {
                    label6.Text = "not in correct format";
                }
                else
                {
                    label6.Text = "in correct format";
                }


            }
            if (textBox3.Text == null)
            {
                label8.Text = "not be empty";

            }
            else
            {
                System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (textBox2.Text.Length > 0)
                {
                    if (!rEMail.IsMatch(textBox2.Text))
                    {
                        label8.Text = "invalid mail id";
                    }
                    else
                    {
                        label8.Text = "matched";
                    }
                }
                System.Text.RegularExpressions.Regex username = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][a-zA-Z]{5,11}");
                if (textBox3.Text == textBox4.Text && username.IsMatch(textBox1.Text) && rEMail.IsMatch(textBox2.Text))

                {
                    cmd = new SqlCommand("insert into sign(name,email,password,usertype) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','user')", conn);

                    conn.Open();



                    int i = cmd.ExecuteNonQuery();

                    Console.WriteLine(i);

                    conn.Close();
                    MessageBox.Show("registered successfully");
                }

            }
        }

        private void textBox1_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
    
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
