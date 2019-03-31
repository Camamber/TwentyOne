using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    class Player
    {
        long id;
        string name;
        int balance;
        bool ready;
        public Player(long id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
            this.ready = false;
        }

        public long Id
        {
            get { return this.id; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public bool Ready
        {
            get { return this.ready; }
            set { this.ready = value; }
        }
    }
}
