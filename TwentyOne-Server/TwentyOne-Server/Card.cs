using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    enum Suit { Heart, Diamond, Club, Spade};
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
        }
    }
}
