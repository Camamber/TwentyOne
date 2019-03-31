using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Client
{
    public class Structures
    {
        public class Request
        {
            public long id;
            public string command;
            public string data;
        }

        public class Response
        {
            public int status;
            public string data;
        }
    }
}
