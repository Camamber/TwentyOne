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
        string name;
        Client client;
        int balance;
        //List<Card> hand;

        public Player(string name)
        {
            this.name = name;          
        }

        public void SetClient(Client client)
        {
            this.client = client;
        }
     
        public void Bet(int bet)
        {
            client.SendCommand("bet", bet.ToString());
        }

        public void More()
        {
            client.SendCommand("up", "");
        }

        public void Enough()
        {
            client.SendCommand("enough", "");
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

    }
}
