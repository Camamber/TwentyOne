using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    class Player
    {
        string name;
        int balance;
        int bet;
        List<Card> hand;

        public Player(string name)
        {

            this.name = name;
            this.hand = new List<Card>();
        }

        public void AddToHand(Card card)
        {
            hand.Add(card);
        }

        public int Score
        {
            get
            {
                int score = 0;
                foreach(Card card in hand)
                {
                    score += card.Value;
                }
                return score;
            }
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public int Bet
        {
            get { return this.bet; }
            set { this.bet = value; }
        }
    }
}
