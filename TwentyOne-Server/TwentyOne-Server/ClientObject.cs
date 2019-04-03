using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        Lobby lobby;

        public ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
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
                    
                    if (lobby == null)
                    {
                        Console.WriteLine("{0}: {1}", message.data, message.command);
                        if (message.command.Equals("connect"))
                        {
                            lobby = new Lobby(100, 5, new Player(message.data));
                            Console.WriteLine(lobby.GetPlayer.Name + " connected!");
                            response.data = JsonConvert.SerializeObject(lobby);
                        }
                        else
                        {
                            response.status = 401;
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0}: {1}", lobby.GetPlayer.Name, message.command);
                        switch (message.command)
                        {
                            case "info":                                
                                response.data = JsonConvert.SerializeObject(lobby);
                                break;                          
                            case "start":               
                                response.status = lobby.Start() ? 200 : 403;                             
                                break;
                            case "bet":
                              
                                break;
                            case "up":
                                lobby.GiveCard(lobby.GetPlayer);                                
                                break;
                            case "end":
                                loop = false;
                                response.data = "Goodbye";
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
                if (lobby != null)
                {
                    Console.WriteLine(lobby.GetPlayer.Name  + " disconnected!");
                    lobby.Close();                 
                }
            }
        }
    }
}
