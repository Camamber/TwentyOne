using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Client
{
    public class Client
    {
        TcpClient client;
        private NetworkStream stream;
        private int port;
        string address;
        private string username;
        private long id;

        public Client(string address, int port, long id, string username)
        {
            this.address = address;
            this.port = port;
            this.id = id;
            this.username = username;

        }
        public string Connect()
        {
            try
            {
                client = new TcpClient(address, port);
                stream = client.GetStream();
                Structures.Response response = SendCommand("connect", username);
                if (response.data != "connected")
                {
                    stream.Close();
                    client.Close();
                }
                return String.Format("({0}){1}",response.status, response.data);
            }
            catch (Exception ex)
            {
                return ex.Message;
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
            Structures.Request request = new Structures.Request { id = id, command = command, data = data };      
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
                return new Structures.Response(){ status=500, data="Cant`t reach server" };
            }
        }

        private Structures.Response RecieveMsg()
        {
            // получаем ответ
            byte[] data = new byte[10*1024]; // буфер для получаемых данных
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

        public string Username
        {
            get { return username; }
        }
    }
}
