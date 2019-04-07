using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwentyOne_Client
{
    enum State { Bet, Play, Enough, Win, Lose }
    class Player
    {
        string name;
        Client client;
        int balance;
        State state;
        List<Card> hand;

        public Player(string name)
        {
            this.name = name;
  
        }

        public void SetClient(Client client)
        {
            this.client = client;
        }
     
        public void MakeBet(int bet)
        {
            client.SendCommand("bet", bet.ToString());
        }

        public void More()
        {
            client.SendCommand("up", "");
        }

        public void Enough()
        {
            client.SendCommand("enough", "");
        }

        public string Name
        {
            get { return this.name; }
            set { this.name=value; }
        }

        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public List<Card> Hand
        {
            get { return this.hand; }
            set { this.hand = value; }
        }

        public int Score
        {
            get
            {
                int score = 0;
                foreach (Card card in hand)
                {
                    score += card.Value;
                }
                return score;
            }
        }

    }
}
