using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    internal class Communication
    {
        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                    instance = new Communication();
                return instance;
            }
        }

        public Communication()
        {

        }

        Socket socket;
        Sender sender;
        Receiver receiver;

        public void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
                sender = new Sender(socket);
                receiver = new Receiver(socket);
            }
        }

        public void Close()
        {
            socket?.Close();
        }

        public Korisnik Login(string username, string password)
        {
            Korisnik korisnik = new Korisnik()
            {
                Username = username,
                Password = password
            };

            Request request = new Request(Operation.Login, korisnik);
            sender.Send(request);

            return (Korisnik)((Response)receiver.Receive()).Result;
        }

        internal Response DodajProdavca(Korisnik korisnik)
        {
            Request request = new Request(Operation.DodajProdavca, korisnik);
            sender.Send(request);
            return (Response)receiver.Receive();
        }
    }
}
