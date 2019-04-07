using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    enum State { Bet, Play, Enough, Win, Lose}
    class Player
    {
        string name;
        int balance;
        int bet;
        State state;
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

        public void ClearHand()
        {
            hand.Clear();
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

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public int Bet
        {
            get { return this.bet; }
            set {
                this.balance -= value;
                this.bet = value;
            }
        }

        public List<Card> Hand
        {
            get { return this.hand; }
        }
    }
}
