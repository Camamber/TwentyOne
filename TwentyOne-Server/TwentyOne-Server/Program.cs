using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    class Program
    {
        static Server server;
        static void Main(string[] args)
        {
            server = new Server("127.0.0.1", 8888);
            Thread thread = new Thread(server.Start);
            thread.Start();
        }
    }
}
