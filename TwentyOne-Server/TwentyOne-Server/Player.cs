using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    class Player
    {
        long id;
        string name;
        int balance;
        bool ready;
        bool active;
        List<Card> hand;
        public Player(long id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
            this.ready = false;
            this.active = false;
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

        public long Id
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public bool Ready
        {
            get { return this.ready; }
            set { this.ready = value; }
        }

        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }
    }
}
