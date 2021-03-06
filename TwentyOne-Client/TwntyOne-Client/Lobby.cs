﻿using Newtonsoft.Json;
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
        Player banker;

        public Lobby(Player player)
        {    
            client = new Client();
            this.player = player;
            this.banker = new Player("banker");

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

        public bool Continue()
        {
            Structures.Response response = client.SendCommand("continue", "");
            return response.status == 200;
        }

        public string Update()
        {
            Structures.Response response = client.SendCommand("info", "");
            Lobby tmp = JsonConvert.DeserializeObject<Lobby>(response.data);
            minBet = tmp.MinBet;
            startMoney = tmp.StartMoney;

            tmp.player.SetClient(client);
            player = tmp.player;
            banker = tmp.banker;
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
            set { player = value; }
        }

        public Player Banker
        {
            get { return banker; }
            set { banker = value; }
        }
    }
}
