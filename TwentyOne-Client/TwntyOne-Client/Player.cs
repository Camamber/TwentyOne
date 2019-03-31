using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwentyOne_Client
{
   
    class Player
    {
        long id;
        string name;
        Client client;
        bool ready, active;
        int balance, minBet;

        public Player(long id, string name)
        {
            this.id = id;
            this.name = name;
            this.ready = false;
            this.active = false;
        }

        public string Connect(string ip, int port)
        {
            client = new Client(ip, port, this);
            var response = client.Connect();
            if (response.status == 200)
            {
                dynamic lobby = JValue.Parse(response.data);
                balance = lobby.StartMoney;
                minBet = lobby.MinBet;
            }

            return string.Format("({0}) {1}", response.status, response.data);
        }

        public void Disconnect()
        {
            if(client != null)
                client.Disconnect();
        }

        public bool Ready
        {
            get { return this.ready; }
            set
            {
                Structures.Response response;
                if (value)                        
                    response = client.SendCommand("ready", "");               
                else
                    response = client.SendCommand("unready", "");

                if (response.status == 200)
                {
                    this.ready = value;
                }
            }
        } 

        public bool Start()
        {
            Structures.Response response = client.SendCommand("start", "");
            return response.status == 200;
        }

        public bool Update()
        {
            Structures.Response response = client.SendCommand("start", "");

            dynamic lobby = JValue.Parse(response.data);
            

            return response.status == 200;
        }

        public void Bet()
        {

        }

        public void More()
        {

        }

        public void Done()
        {

        }

        public long Id
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public int MinBet
        {
            get { return this.minBet; }
            set { this.minBet = value; }
        }


    }
}
