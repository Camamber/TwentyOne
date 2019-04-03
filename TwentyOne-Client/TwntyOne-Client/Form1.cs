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
            
            lobby = new Lobby(new Player("Котя"));
            richTextBox1.Text += lobby.Connect("127.0.0.1", 8888)+"\n";

            numericUpDown1.Value = lobby.MinBet;
            label4.Text = lobby.Player.Balance.ToString();           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            lobby.Disconnect();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            bool started = lobby.Start();
            panel1.Visible = !started;
            panel3.Enabled = started;
            //timer1.Start();

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
    }
}


