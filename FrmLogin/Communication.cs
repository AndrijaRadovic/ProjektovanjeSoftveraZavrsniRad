using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                if (socket == null || !socket.Connected)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
                    sender = new Sender(socket);
                    receiver = new Receiver(socket);
                }
            }
            catch (SocketException)
            {

                MessageBox.Show("Greska sa povezivanjem!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

            try
            {
                Request request = new Request(Operation.Login, korisnik);
                if (sender != null)
                {
                    sender.Send(request);
                    return (Korisnik)((Response)receiver.Receive()).Result;
                }

                return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Greska sa povezivanjem!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return null;
            }
        }

        internal Response DodajProdavca(Korisnik korisnik)
        {
            Request request = new Request(Operation.DodajProdavca, korisnik);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal List<Korisnik> VratiSveProdavce()
        {
            Request request = new Request(Operation.VratiSveProdavce, null);
            sender.Send(request);
            return (List<Korisnik>)((Response)receiver.Receive()).Result;
        }

        internal List<Korisnik> PretraziKorisnikePoImenu(string text)
        {
            Request request = new Request(Operation.PretraziKorisnikePoImenu, text);
            sender.Send(request);
            return (List<Korisnik>)((Response)receiver.Receive()).Result;
        }

        internal Response ObrisiKorisnika(Korisnik izabraniKorisnik)
        {
            Request request = new Request(Operation.ObrisiKorisnika, izabraniKorisnik);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal Korisnik PretraziKorisnikePoId(int sifraKorisnika)
        {
            Request request = new Request(Operation.NadjiKorisnikaPoId, sifraKorisnika);
            sender.Send(request);
            return (Korisnik)((Response)receiver.Receive()).Result;
        }

        internal Response UpdateKorisnika(Korisnik korisnik)
        {
            Request request = new Request(Operation.UpdateKorisnika, korisnik);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal Response PromeniSifru(string staraSifra, string novaSifra)
        {
            Request request = new Request(Operation.PromeniSifru, new string[] { staraSifra, novaSifra });
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal Response DodajProizvod(Proizvod proizvod)
        {
            Request request = new Request(Operation.DodajProizvod, proizvod);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal List<Proizvod> VratiSveProizvode()
        {
            Request request = new Request(Operation.VratiSveProizvode, null);
            sender.Send(request);
            return (List<Proizvod>)((Response)receiver.Receive()).Result;
        }

        internal Response ObrisiProizvod(Proizvod izabraniProizvod)
        {
            Request request = new Request(Operation.ObrisiProizvod, izabraniProizvod);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal List<Proizvod> PretraziProizvodePoNazivu(string text)
        {
            Request request = new Request(Operation.PretraziProizvodePoNazivu, text);
            sender.Send(request);
            return (List<Proizvod>)((Response)receiver.Receive()).Result;
        }
    }
}
