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
        Lobby lobby;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                     
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(lobby!=null)
                lobby.Disconnect();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            lobby = new Lobby(new Player(tb_username.Text));
            richTextBox1.Text += lobby.Connect(tb_IP.Text, 8888) + "\n";
            numericUpDown1.Value = lobby.MinBet;
            label4.Text = lobby.Player.Balance.ToString();

            bool started = lobby.Start();
            panel1.Visible = !started;
            panel3.Enabled = started;
            if(started)
                timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text += lobby.Update() + "\n";
           
        }

        private void bnt_Bet_Click(object sender, EventArgs e)
        {
            lobby.Player.Bet((int)numericUpDown1.Value);
            bnt_Bet.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lobby.Player.More();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lobby.Player.Enough();
        }
    }
}


