using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class client1 : Form
    {
        public client1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            //Connect to server
            client.Connect(textBox1.Text, Convert.ToInt32(textBox2.Text));
        }

        private void client1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update message to txtStatus
           richTextBox1.Invoke((MethodInvoker)delegate ()
            {
                richTextBox1.Text += e.MessageString;
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(richTextBox2.Text, TimeSpan.FromSeconds(3));
        }
    }
}
