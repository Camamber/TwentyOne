using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Client
{
    enum Suit { hearts, diamonds, clubs, spades };
    class Card
    {
        Suit suit;
        int value;
        public Card(Suit suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public Suit Suit
        {
            get { return suit; }
            set { this.suit = value; }
        }
    }
}
