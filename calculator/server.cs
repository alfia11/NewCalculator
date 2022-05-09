using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class server : Form
    {
        public static bool IsStarted { get; private set; }

        public server()
        {
            InitializeComponent();
        }
        SimpleTcpServer Server;
        private void server_Load(object sender, EventArgs e)
        {
            // SimpleTcpServer server;
            Server = new SimpleTcpServer();
            Server.Delimiter = 0x13;//enter
            Server.StringEncoder = Encoding.UTF8;
            Server.DataReceived += Server_DataReceived;
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update mesage to txtStatus
            richTextBox1.Invoke((MethodInvoker)delegate ()
             {
                 richTextBox1.Text += e.MessageString;
                 e.ReplyLine(string.Format("You said: {0}", e.MessageString));
             });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Start server host
            richTextBox1.Text += "Server starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(textBox1.Text);
            Server.Start(ip, Convert.ToInt32(textBox2.Text));
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                Server.Stop();
        }


    }
}
