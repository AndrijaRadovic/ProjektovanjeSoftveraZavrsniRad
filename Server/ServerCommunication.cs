using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class ServerCommunication
    {
        private Socket socket;
        public static List<ClientHandler> clients = new List<ClientHandler>();

        public ServerCommunication()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void StartServer()
        {
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));

            socket.Bind(iPEndPoint);
            socket.Listen(5);

            Thread thread = new Thread(AcceptClient);
            thread.Start();
        }

        public void AcceptClient()
        {
            try
            {
                while (true)
                {
                    Socket client = socket.Accept();
                    ClientHandler handler = new ClientHandler(client);
                    clients.Add(handler);
                    Thread klijentskaNit = new Thread(handler.HandleClient);
                    klijentskaNit.Start();
                }
            }
            catch (Exception ex)
            {
                // Nzm sto imam ovaj throw
                //throw ex;
                Debug.WriteLine(">>> " + ex.Message);
            }
        }

        public void StopServer()
        {
            foreach (ClientHandler ch in clients) ch.Close();
            clients.Clear();
            socket?.Close();
        }
    }
}
