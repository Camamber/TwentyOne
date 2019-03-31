using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    

    class ClientObject
    {
        TcpClient client;
        Player player;
        Lobby lobby;

        public ClientObject(TcpClient tcpClient, Lobby lobby)
        {
            client = tcpClient;
            this.lobby = lobby;
        }

        public void Process()
        {
            NetworkStream stream = null;
            bool loop = true;
            byte[] data = new byte[10*1024];

            try
            {
                stream = client.GetStream();
                while (loop)
                {
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    Structures.Response response = new Structures.Response() { status = 200, data = ""};

                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string request = builder.ToString();
                    if (request == "")
                        continue;

                    Structures.Request message = JsonConvert.DeserializeObject<Structures.Request>(builder.ToString());
                    
                    if (player == null)
                    {
                        Console.WriteLine("{0}: {1}", message.id, message.command);
                        if (message.command.Equals("connect"))
                        {
                            player = new Player(message.id, message.data, lobby.StartMoney);
                            lobby.AddPlayer(player);
                            Console.WriteLine(player.Name + " connected!");
                            response.data = "connected";
                        }
                        else
                        {
                            response.status = 401;
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0}: {1}", player.Name, message.command);
                        switch (message.command)
                        {
                            case "ready":
                                player.Ready = true;
                                break;
                            case "unready":
                                player.Ready = false;
                                break;
                            case "start":
                                response.status = lobby.Start()?200:403;
                                break;
                            case "exit":
                                loop = false;
                                response.data = "Goodbye";
                                break;
                            default:
                                response.status = 404;
                                break;
                        }
                    }
                    
                    data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(response));
                    stream.Write(data, 0, data.Length);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
                if (player != null)
                {
                    Console.WriteLine(player.Name  + " disconnected!");
                    lobby.RemovePlayer(player.Id);
                }
            }
        }
    }
}
