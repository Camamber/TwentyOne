using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    class Lobby
    {
        int startMoney;
        int minBet;
        bool ready;
        long leaderId;
        List<Player> players;
        public Lobby(int startMoney, int minBet, int maxPlayer = 3)
        {
            this.players = new List<Player>(maxPlayer);
            this.startMoney = startMoney;
            this.minBet = minBet;
            this.ready = false;
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
                    break;
                }
            }
            return ready;
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
