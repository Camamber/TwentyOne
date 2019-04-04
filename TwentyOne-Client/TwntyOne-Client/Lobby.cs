using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Client
{
    class Lobby
    {
        int startMoney;
        int minBet;
        Client client;
        Player player;

        public Lobby(Player player)
        {    
            client = new Client();
            this.player = player;

        }
        public string Connect(string ip, int port)
        {
            
            var response = client.Connect(ip, port, player.Name);
            if (response.status == 200)
            {
                dynamic lobby = JValue.Parse(response.data);
                startMoney = lobby.StartMoney;
                minBet = lobby.MinBet;
                player.SetClient(client);
            }

            return string.Format("({0}) {1}", response.status, response.data);
        }

        public void Disconnect()
        {
            if (client != null)
                client.Disconnect();
        }

        public bool Start()
        {
            Structures.Response response = client.SendCommand("start", "");
            return response.status == 200;
        }

        public string Update()
        {
            Structures.Response response = client.SendCommand("info", "");

            dynamic json = JObject.Parse(response.data);
            minBet = json.MinBet;
            startMoney = json.StartMoney;
            return response.data;//response.status == 200;
        }

        public int StartMoney
        {
            get { return startMoney; }
            set { startMoney = value; }
        }

        public int MinBet
        {
            get { return minBet; }
            set { minBet = value; }
        }

        public Player Player
        {
            get { return player; }
        }
    }
}
