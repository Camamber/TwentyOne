using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    class Lobby
    {
        Random rnd = new Random();
        int startMoney;
        int minBet;
        Player player;
        Player banker;
        List<Card> deck;
        Timer timer;
        public Lobby(int startMoney, int minBet, Player player)
        {
            this.player = player;
            this.banker = new Player("banker");
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
                tmp.Add(new Card(Suit.clubs, i + (i < 6 ? 6 : -4)));
                tmp.Add(new Card(Suit.diamonds, i + (i < 6 ? 6 : -4)));
                tmp.Add(new Card(Suit.hearts, i + (i < 6 ? 6 : -4)));
                tmp.Add(new Card(Suit.spades, i + (i < 6 ? 6 : -4)));
            }
            return tmp;
        }

        public bool Start()
        {
            if (player.Balance < minBet)
                return false;

            player.ClearHand();
            banker.ClearHand();

            GiveCard(player);
            GiveCard(banker);

            player.State = State.Bet;
            return true;
        }

        public void GiveCard(Player player)
        {
            if (deck.Count < 2)
            {
                deck.Clear();
                FillDeck();
            }
            int cardIndex = rnd.Next(0, deck.Count);
            player.AddToHand(deck.ElementAt(cardIndex));
            deck.RemoveAt(cardIndex);
        }

        public void BankerPlay()
        {
            TimerCallback timeCB = new TimerCallback(CheckBanker);
            timer = new Timer(timeCB, null, 2000, 3000);
        }

        public void CheckBanker(object state)
        {
            if (banker.Score < 17)
            {
                GiveCard(banker);
            }
            else
            {
                timer.Change(Timeout.Infinite, Timeout.Infinite);
                if(banker.Score > 21 || banker.Score < player.Score)
                {
                    player.Balance += player.Bet * 2;
                    player.State = State.Win;
                    banker.State = State.Lose;
                }
                else if (banker.Score == 21 || banker.Score > player.Score)
                {
                    player.State = State.Lose;
                    banker.State = State.Win;
                }
            }
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

        public Player Player
        {
            get { return player; }
        }

        public Player Banker
        {
            get { return banker; }
        }
    }
}