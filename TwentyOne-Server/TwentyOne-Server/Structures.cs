﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    class Structures
    {
        public class Request
        {
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
