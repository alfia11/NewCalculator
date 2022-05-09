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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        private void BindGrid()
        {
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\calculator - Copy\calculator\calci.mdf'; Integrated Security = True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT email,name,usertype FROM sign", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;

                        }
                    }
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calciDataSet6.sign' table. You can move, or remove it, as needed.
            this.signTableAdapter.Fill(this.calciDataSet6.sign);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\calculator - Copy\calculator\calci.mdf'; Integrated Security = True";

            DataGridViewRow row1 = dataGridView1.Rows[e.RowIndex];
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DELETE")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //regisBindingSource.RemoveAt(e.RowIndex);
                //string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Calculato\Calculato\Calcu.mdf';Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constring))



                {
                    using (SqlCommand cmd = new SqlCommand("delete FROM sign where name=@name ", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@name", row.Cells[0].Value);
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                }



            }
            BindGrid();
            // DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            try {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "UPDATE")
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    //regisBindingSource.RemoveAt(e.RowIndex);
                    //string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Calculato\Calculato\Calcu.mdf';Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(constring))



                    {
                        using (SqlCommand cmd = new SqlCommand("update sign set usertype=@usertype where name=@name", con))
                        {
                            cmd.CommandType = CommandType.Text;

                            cmd.Parameters.AddWithValue("@usertype", row1.Cells[3].Value);




                            cmd.Parameters.AddWithValue("@name", row.Cells[0].Value);

                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {

                                using (DataTable dt = new DataTable())
                                {
                                    sda.Fill(dt);
                                    dataGridView1.DataSource = dt;
                                }
                            }
                        }
                    }
                    BindGrid();

                }

            }
            catch(Exception)
            {
                MessageBox.Show("please do any updation in the usertype");
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 g = new Form4();
            g.Show();
        }
    }
}
