using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    class Lobby
    {
        Random rnd = new Random();
        int startMoney;
        int minBet;
        Player player;
        List<Card> deck;
        public Lobby(int startMoney, int minBet, Player player)
        {
            this.player = player;
            this.deck = FillDeck();
            this.startMoney = startMoney;
            this.minBet = minBet;
            this.player.Balance = startMoney;
        }

        public List<Card> FillDeck()
        {
            List<Card> tmp = new List<Card>();
            for (int i = 0; i < 9; i++)
            {
                tmp.Add(new Card(Suit.Club, i + i < 6 ? 6 : -4));
                tmp.Add(new Card(Suit.Diamond, i + i < 6 ? 6 : -4));
                tmp.Add(new Card(Suit.Heart, i + i < 6 ? 6 : -4));
                tmp.Add(new Card(Suit.Spade, i + i < 6 ? 6 : -4));
            }
            return tmp;
        }
    
        public bool Start()
        {
           GiveCard(player);                    
           return true;
        }

        public void GiveCard(Player player)
        {
            int cardIndex = rnd.Next(0, deck.Count);
            player.AddToHand(deck.ElementAt(cardIndex));
            deck.RemoveAt(cardIndex);
        }

        public void Close()
        {
            player = null;
            deck.Clear();
        }

        public int StartMoney
        {
            get { return startMoney; }
        }

        public int MinBet
        {
            get { return minBet; }
        }

        public Player GetPlayer
        {
            get { return player; }
        }
    }
}
