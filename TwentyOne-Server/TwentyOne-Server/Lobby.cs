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
        bool ready;
        List<Player> players;
        public Lobby(int startMoney, int maxPlayer = 3)
        {
            this.players = new List<Player>(maxPlayer);
            this.startMoney = startMoney;
            this.ready = false;
        }

        public int AddPlayer(Player player)
        {
            players.Add(player);
            return players.Count;
        }

        public int RemovePlayer(long id)
        {
            int index = players.FindIndex(p => p.Id == id);
            players.RemoveAt(index);
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
    }
}
