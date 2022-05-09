using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Build.Tasks;
using Microsoft.Data.Sqlite;
using NLog;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using Twilio;
using Xceed.Wpf.Toolkit;
using ILogger = NLog.ILogger;



namespace calculator
{
    public partial class Form1 : Form
    {

        private readonly ILogger _logger;
        double FirstNumber;
        string Operations;
        double SecondNumber;
        //here creating the object of the outter class oper
        Oper oo = new Oper();
        SqlConnection conn;
        SqlCommand cmd;

        //private SqlConnection con;

        ////create new sqlconnection and connection to database by using connection string from web.config file


        public void Fun(double n)
        {
            if (tb1.Text == "0" && tb1.Text != null)

            {
                tb1.Text = Convert.ToString(n);
            }
            else
            {
                tb1.Text = tb1.Text + n;
            }
        }
        public void Operation(string s)
        {
            try
            {
                FirstNumber = Convert.ToDouble(tb1.Text);
                tb1.Text = "";
                tb1.Clear();
                Operations = s;
            }
            catch (Exception ee)
            {
                label3.Text = "input error";

            }
        }




        public Form1()
        {

            //_logger = logger;
            InitializeComponent();


            timer1.Interval = 1000;
            timer1.Start();
            tb1.Text = "0";
            String g = "d://list2.txt";
            using (StreamReader sr = new StreamReader(g))
                while (!sr.EndOfStream)
                {
                    listBox.Items.Add(sr.ReadLine());
                }
        }
        private void btn0_Click_1(object sender, EventArgs e)
        {

            Fun(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Fun(1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Fun(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Fun(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Fun(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Fun(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Fun(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Fun(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Fun(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Fun(9);
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Operation("+");
        }
        private void btnsub_Click(object sender, EventArgs e)
        {
            Operation("-");
        }
        private void btnmul_Click(object sender, EventArgs e)
        {
            Operation("*");
        }
        private void btndiv_Click(object sender, EventArgs e)
        {
            Operation("/");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Operation("%");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Result;
            if (Operations == "+")
            {
                try
                {
                    SecondNumber = Convert.ToDouble(tb1.Text);
                    double g = oo.Add(FirstNumber, SecondNumber);
                    //Result = (FirstNumber + SecondNumber);
                    tb1.Text = Convert.ToString(g);
                    String t = Convert.ToString(FirstNumber);
                    String t1 = Convert.ToString(SecondNumber);
                    String g1 = "+";
                    listBox.Items.Add(t + g1 + t1 + "=" + g);
                    FirstNumber = g;
                    FirstNumber = 0;
                }
                catch (Exception ff)
                {
                    label3.Text = "error";
                    ILogger _logger = LogManager.GetLogger("fileLogger");
                    _logger.Error(ff, "Whoops!");
                }
            }
            if (Operations == "-")
            {
                try
                {
                    SecondNumber = Convert.ToDouble(tb1.Text);
                    double b = oo.Sub(FirstNumber, SecondNumber);
                    tb1.Text = Convert.ToString(b);
                    listBox.Items.Add(Convert.ToString(FirstNumber) + "-" + Convert.ToString(SecondNumber) + "=" + b);
                    FirstNumber = b;
                    SecondNumber = b;
                }
                catch (Exception ex)
                {
                    label3.Text = "error!!!!!!!!!!!!!!!";
                    ILogger _logger = LogManager.GetLogger("fileLogger");
                    _logger.Error(ex, "Whoops!");
                }
            }
            if (Operations == "*")
            {
                try
                {
                    SecondNumber = Convert.ToDouble(tb1.Text);

                    double l = oo.Mul(FirstNumber, SecondNumber);
                    //Result = (FirstNumber * SecondNumber);
                    tb1.Text = Convert.ToString(l);
                    listBox.Items.Add(Convert.ToString(FirstNumber) + "*" + Convert.ToString(SecondNumber) + "=" + l);
                    //listBox.Items.Add(l);
                    FirstNumber = l;
                    FirstNumber = 0;
                    SecondNumber = 0;
                }
                catch (Exception ee)
                {
                    label3.Text = "error!!!!!!!";
                    ILogger _logger = LogManager.GetLogger("fileLogger");
                    _logger.Error(ee, "Whoops!");
                    _logger.Info("error");
                }
            }
            if (Operations == "/")
            {
                try
                {
                    SecondNumber = Convert.ToDouble(tb1.Text);
                }
                catch (Exception)
                {
                    label3.Text = "error!!!!!!!!!!!!!!!";

                }
                if (SecondNumber == 0)
                {

                    label4.Text = "Cannot divide by zero";
                    FirstNumber = 0;
                    SecondNumber = 0;
                }
                else
                {
                    SecondNumber = Convert.ToDouble(tb1.Text);
                    Oper t = new Oper();
                    double j = t.Div(FirstNumber, SecondNumber);
                    tb1.Text = Convert.ToString(j);
                    listBox.Items.Add(Convert.ToString(FirstNumber) + "/" + Convert.ToString(SecondNumber) + "=" + j);
                    FirstNumber = j;
                    FirstNumber = 0;
                    SecondNumber = 0;
                }
            }
            if (Operations == "%")
            {
                try
                {
                    SecondNumber = Convert.ToDouble(tb1.Text);
                    double u = oo.Percen(FirstNumber, SecondNumber);
                    tb1.Text = Convert.ToString(u);
                    listBox.Items.Add(Convert.ToString(FirstNumber) + "%" + Convert.ToString(SecondNumber) + "=" + u);
                    //listBox.Items.Add(u);
                    FirstNumber = u;
                    FirstNumber = 0;
                }
                catch (Exception)
                {
                    Result = FirstNumber / 100;
                    tb1.Text = Convert.ToString(Result);
                    listBox.Items.Add(Convert.ToString(FirstNumber) + "%" + Convert.ToString(SecondNumber) + "=" + Result);
                    // listBox.Items.Add(Result);
                }

            }
            string sPath = "d://list2.txt";
            using (StreamWriter SaveFile = new StreamWriter(sPath))
                //using (StreamWriter sw = File.AppendText(sPath))
                foreach (var h in listBox.Items)
                {
                    SaveFile.WriteLine(h);
                }
            string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection conn = new SqlConnection(str);
            try
            {

                SqlCommand cmd = new SqlCommand();

                //ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["constrr"];
                //string connectionString = conSettings.ConnectionString;
                //try
                //{
                //con1 = new SqlConnection(strcon);
                conn.Open();
                Console.WriteLine("set");

            }
            catch (Exception)
            {

            }
            //    Console.WriteLine("settttttttttttt");
            //}
            //catch (Exception ee)
            //{
            //    Console.WriteLine("error");
            //}
            //con1.Open();

            //con = new SqlConnection();

            //con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\calculator - Copy\calculator\calci.mdf'; Integrated Security = True";

            //con.Open();
            ////con.ConnectionString =ConfigurationManager.ConnectionStrings["constr"].ConnectionString;


            //Console.WriteLine("opened");
            //cmd = new SqlCommand("insert...", con);


            // string s = ("insert into calci) values ('" + listBox.Items[j].ToString()+ "')", con);




            for (int k = 0; k < listBox.Items.Count; k++)

            {
                if (conn.State == ConnectionState.Closed)

                {
                    str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                    conn = new SqlConnection(str);
                    conn.Open();
                }
                cmd = new SqlCommand("insert into history1 values ('" + listBox.Items[k].ToString() + "','" + label1.Text + "','"+DateTime.Now.ToString()+"')", conn);

                //con.Open();

                //SqlCommand cmd = new SqlCommand()

                int i = cmd.ExecuteNonQuery();

                //Console.WriteLine(i);

                conn.Close();

            }

            //con = new SqlConnection();

            //con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\calculator - Copy\calculator\calci.mdf'; Integrated Security = True";

            //con.Open();
            //con.Open();




            //con = new SqlConnection();

            //con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\calculator - Copy\calculator\calci.mdf';Integrated Security=True";
            //////conStr = ConfigurationManager.ConnectionStrings["test"].ToString();

            //con.Open();










        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            label3.Text = "";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "0" && tb1.Text != null)
            {
                tb1.Text = ".";
            }
            else
            {
                tb1.Text = tb1.Text + ".";
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Start();
            label4.Text = DateTime.Now.ToLongTimeString();
            Random rn = new Random();
            int R, G, B;
            R = rn.Next(0, 255);
            G = rn.Next(0, 255);
            B = rn.Next(0, 255);
            //label5.Text = "Red" + R + "Green" + G + "Black" + B;
            BackColor = Color.FromArgb(R, G, B);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            SqlConnection conn = new SqlConnection(str);
            try
            {

                SqlCommand cmd = new SqlCommand();

                //ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["constrr"];
                //string connectionString = conSettings.ConnectionString;
                //try
                //{
                //con1 = new SqlConnection(strcon);
                conn.Open();
                Console.WriteLine("set");

            }
            catch (Exception)
            {

            }
            //    Console.WriteLine("settttttttttttt");
            //}
            //catch (Exception ee)
            //{
            //    Console.WriteLine("error");
            //}
            //con1.Open();

            //con = new SqlConnection();

            //con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'D:\calculator - Copy\calculator\calci.mdf'; Integrated Security = True";

            //con.Open();
            ////con.ConnectionString =ConfigurationManager.ConnectionStrings["constr"].ConnectionString;


            //Console.WriteLine("opened");
            //cmd = new SqlCommand("insert...", con);


            // string s = ("insert into calci) values ('" + listBox.Items[j].ToString()+ "')", con);




            SqlDataAdapter ada = new SqlDataAdapter();
            ada = new SqlDataAdapter("select * from history1 where creted='" + label1.Text + "'", conn);
            DataTable dt=new DataTable();
            ada.Fill(dt);

            //con.Open();

            //SqlCommand cmd = new SqlCommand()

            

            //Console.WriteLine(i);
            Form2 f = new Form2();
            f.dataGridView1.DataSource = dt;
            
            f.Show();

            conn.Close();

        }

    
            
        

        private void button14_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }



