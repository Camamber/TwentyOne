using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwentyOne_Client.Properties;

namespace TwentyOne_Client
{
    public partial class Form1 : Form
    {
        Lobby lobby;
        int bet;
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
            int port;
            if(!int.TryParse(tb_Port.Text, out port))           
                return;
            
            bet = 0;
            lobby = new Lobby(new Player(tb_username.Text));
            richTextBox1.Text += lobby.Connect(tb_IP.Text, port) + "\n";
            lbl_balance.Text = lobby.Player.Balance.ToString();

            bool started = lobby.Start();
            panel1.Visible = !started;
            table.Enabled = started;
            if (started)
                timer1.Start();

        }

        private PictureBox NewCard(PictureBox pb, string img,string name,int i)
        {
            ResourceManager rm = Resources.ResourceManager;
            Image myImage = (Image)rm.GetObject(img);
            return new PictureBox { Name = name, Image = myImage, BackColor = pb.BackColor, SizeMode = pb.SizeMode, Size = pb.Size, Location = new Point(pb.Location.X+(15*i), pb.Location.Y)  };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.Text += lobby.Update() + "\n";
            for (int i = 0; i < lobby.Player.Hand.Count; i++)
            {
                if (!table.Controls.ContainsKey("p_card" + 1 + i))
                {
                    string imgName = "_" + lobby.Player.Hand[i].Value + "_of_" + lobby.Player.Hand[i].Suit;
                    PictureBox pb = NewCard(p_card, imgName,"p_card" + 1 + i, i);                  
                    panel_Player.Controls.Add(pb);
                    pb.BringToFront();
                }
            }

            for (int i = 0; i < lobby.Banker.Hand.Count; i++)
            {
                if (!table.Controls.ContainsKey("b_card" + 1 + i))
                {
                    string imgName = "_" + lobby.Banker.Hand[i].Value + "_of_" + lobby.Banker.Hand[i].Suit;
                    PictureBox pb = NewCard(b_card, imgName, "b_card" + 1 + i, -i);
                    panel_Banker.Controls.Add(pb);
                    pb.BringToFront();
                }
            }

            if (lobby.Player.State == State.Win || lobby.Player.State == State.Lose)
            {
                timer1.Stop();
                if(lobby.Player.State == State.Lose)
                {
                    label5.Text = "К сожалению, Вы проиграли!!!";
                }
                else
                {
                    if(lobby.Player.Score == 21)
                        label5.Text = "Поздравляем, у вас Очко!!!";
                    else
                        label5.Text = "Поздравляем, Вы выиграли!!!";
                }

            }

            btn_More.Enabled = (lobby.Player.State != State.Win && lobby.Player.State != State.Lose);
            btn_Done.Enabled = (lobby.Player.State != State.Win && lobby.Player.State != State.Lose);
            panel2.Visible = (lobby.Player.State == State.Win || lobby.Player.State == State.Lose);

            lbl_balance.Text = lobby.Player.Balance.ToString();

            btn_Bet.Visible = lobby.Player.State == State.Bet;
            btn_Bet1.Enabled = lobby.Player.State == State.Bet;
            btn_Bet5.Enabled = lobby.Player.State == State.Bet;
            btn_Bet20.Enabled = lobby.Player.State == State.Bet;
            btn_Bet25.Enabled = lobby.Player.State == State.Bet;
            btn_BetClear.Enabled = lobby.Player.State == State.Bet;

            lbl_Score.Text = lobby.Player.Score.ToString();
            lbl_banker.Text = lobby.Banker.Score.ToString();

            btn_More.Enabled = lobby.Player.State == State.Play;
            btn_Done.Enabled = lobby.Player.State == State.Play;
        }

        private void bnt_Bet_Click(object sender, EventArgs e)
        {
            
            lobby.Player.MakeBet(bet);
            btn_Bet.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bet = 0;
            lbl_Bet.Text = this.bet.ToString();
            panel_Player.Controls.Clear();
            panel_Banker.Controls.Clear();
            bool continued = lobby.Continue();
            panel2.Visible = !continued;
            table.Enabled = continued;
            if (continued)
                timer1.Start();

        }

        private void btn_More_Click(object sender, EventArgs e)
        {
            lobby.Player.More();
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            lobby.Player.Enough();
        }

        private void btn_Bet1_Click(object sender, EventArgs e)
        {
            IncBet(1);
        }

        private void btn_Bet5_Click(object sender, EventArgs e)
        {
            IncBet(5);
        }

        private void btn_Bet20_Click(object sender, EventArgs e)
        {
            IncBet(20);
        }

        private void btn_Bet25_Click(object sender, EventArgs e)
        {
            IncBet(25);
        }

        public void IncBet(int bet)
        {
            this.bet += bet;
            lbl_Bet.Text = this.bet.ToString();
        }

        private void btn_BetClear_Click(object sender, EventArgs e)
        {
            this.bet = 0;
            lbl_Bet.Text = this.bet.ToString();
        }

        private void lbl_Bet_TextChanged(object sender, EventArgs e)
        {
            if (bet > lobby.Player.Balance || bet < lobby.MinBet)
                btn_Bet.Enabled = false;
            else
                btn_Bet.Enabled = true;
        }


    }
}


