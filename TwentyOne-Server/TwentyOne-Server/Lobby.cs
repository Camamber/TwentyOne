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
        bool ready;
        long leaderId;
        List<Player> players;
        List<Card> deck;
        public Lobby(int startMoney, int minBet, int maxPlayer = 3)
        {
            this.players = new List<Player>(maxPlayer);
            this.deck = FillDeck();
            this.startMoney = startMoney;
            this.minBet = minBet;
            this.ready = false;
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

        public int AddPlayer(Player player)
        {
            if (players.Capacity == 0)
                leaderId = player.Id;
            players.Add(player);
            return players.Count;
        }

        public int RemovePlayer(long id)
        {
            int index = players.FindIndex(p => p.Id == id);
            players.RemoveAt(index);
            if (leaderId == id && players.Count > 0)
                leaderId = players[0].Id;
            return players.Count;
        }

        public bool Start()
        {
            ready = true;
            foreach(Player player in players)
            {
                if (!player.Ready)
                {
                    ready = false;
                    return ready;
                }
            }

           foreach (Player player in players)
                GiveCard(player);
            players[0].Active = true;
                       
            return ready;
        }

        void GiveCard(Player player)
        {
            int cardIndex = rnd.Next(0, deck.Count);
            player.AddToHand(deck.ElementAt(cardIndex));
            deck.RemoveAt(cardIndex);
        }

        public int StartMoney
        {
            get { return startMoney; }
        }

        public int MinBet
        {
            get { return minBet; }
        }
    }
}
