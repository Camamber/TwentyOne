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
        Player player;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            long unixTimestamp = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            player = new Player(unixTimestamp, "Котя");
            richTextBox1.Text += player.Connect("127.0.0.1", 8888)+"\n";
            label4.Text = player.Balance.ToString();
            numericUpDown1.Value = player.MinBet;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Disconnect();
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
            player.Ready = !player.Ready;
            btn_Status.Text = player.Ready ? "Unready" : "Ready";
            btn_Start.Enabled = player.Ready;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            bool started = player.Start();
            panel1.Visible = !started;
        }
    }
}


