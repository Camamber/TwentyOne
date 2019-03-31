using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwentyOne_Client
{
    public partial class Form1 : Form
    {
        Client cl;
        bool a = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            long unixTimestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            cl = new Client("127.0.0.1", 8888, unixTimestamp, "Tolya");
            richTextBox1.Text += String.Format("{0}\n", cl.Connect());          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cl.Disconnect();
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            Structures.Response response;

            if (!a)
            {
                a = true;
                response = cl.SendCommand("ready", "");
            }
            else
            {
                a = false;
                response = cl.SendCommand("unready", "");
            }

            richTextBox1.Text += String.Format("({0}){1}\n", response.status, response.data);
            if (response.status == 200)
            {
                btn_Status.Text = a ? "Unready" : "Ready";
                btn_Start.Enabled = a;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {

            Structures.Response response = cl.SendCommand("start", "");
            if (response.status == 200)
            {
                panel1.Visible = false;
            }

        }
    }
}


