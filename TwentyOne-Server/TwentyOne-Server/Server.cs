using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TwentyOne_Server
{
    class Server
    {
        string ip;
        int port;
        static TcpListener listener;
        List<TcpClient> clients;

        public Server(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
            listener = new TcpListener(IPAddress.Parse(ip), port);
            clients = new List<TcpClient>();
        }

        public void Start()
        {
            try
            {
                listener.Start();
                Console.WriteLine("Server is up. Waiting for clients...");
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    clients.Add(client);
                    ClientObject clientObject = new ClientObject(client);

                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();

                    List<TcpClient> cl = clients.FindAll(x => x.Connected == false);
                    foreach (TcpClient c in cl)
                        clients.Remove(c);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (listener != null)
                listener.Stop();

            if (clients.Count > 0)
            {
                foreach (TcpClient c in clients)
                {
                    if (c.Connected)
                        c.Close();
                }
            }
            clients.Clear();
        }      
    }
}
