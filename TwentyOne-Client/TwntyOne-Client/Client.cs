using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Client
{
    class Client
    {
        TcpClient client;
        private NetworkStream stream;

        public Client()
        {
        }
        public Structures.Response Connect(string address, int port, string name)
        {
            try
            {
                client = new TcpClient(address, port);
                stream = client.GetStream();
                Structures.Response response = SendCommand("connect", name);
                if (response.status != 200)
                {
                    stream.Close();
                    client.Close();
                }
                return response;
            }
            catch (Exception ex)
            {
                 return new Structures.Response { status = 500, data = ex.Message };
            }
        }

        public void Disconnect()
        {
            SendCommand("exit", "");
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
        }


        public Structures.Response SendCommand(string command, string data)
        {
            Structures.Request request = new Structures.Request {command = command, data = data };      
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(request));
                stream.Write(bytes, 0, bytes.Length);
                return RecieveMsg();
            }
            catch
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
                return new Structures.Response{ status=500, data="Cant`t reach server" };
            }
        }

        private Structures.Response RecieveMsg()
        {
            byte[] data = new byte[10*1024];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);

            return JsonConvert.DeserializeObject<Structures.Response>(builder.ToString());
        }
    }
}
