using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ClientHandler
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;

        private Korisnik prijavljeniKorisnik;

        public ClientHandler(Socket client)
        {
            this.socket = client;
            sender = new Sender(client);
            receiver = new Receiver(client);
        }

        internal void Close()
        {
            socket?.Close();
        }

        internal void HandleClient()
        {
            try
            {
                while (true)
                {
                    Request request = (Request)receiver.Receive();
                    Response response = ProcessRequest(request);
                    sender.Send(response);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.Login:
                        {
                            response.Result = ServerController.Instance.Login((Korisnik)request.Argument);
                            this.prijavljeniKorisnik = (Korisnik)response.Result;
                        }
                        break;

                    case Operation.DodajProdavca:
                        {
                            ServerController.Instance.DodajProdavca((Korisnik)request.Argument);
                            response.Message = "Prodavac je uspesno dodat";
                        }
                        break;

                    case Operation.VratiSveProdavce:
                        {
                            response.Result = ServerController.Instance.VratiSveProdavce();
                        }
                        break;

                    case Operation.PretraziKorisnikePoImenu:
                        {
                            response.Result = ServerController.Instance.PretraziKorisnikePoImenu((string)request.Argument);
                        }
                        break;

                    case Operation.ObrisiKorisnika:
                        {
                            ServerController.Instance.ObrisiKorisnika((Korisnik)request.Argument);
                            response.Message = "Korisnik je uspesno obrisan!";
                        }
                        break;

                    case Operation.NadjiKorisnikaPoId:
                        {
                            response.Result = ServerController.Instance.NadjiKorisnikaPoId((int)request.Argument);
                        }
                        break;

                    case Operation.UpdateKorisnika:
                        {
                            ServerController.Instance.UpdateKorisnika((Korisnik)request.Argument);
                            response.Message = "Korisnik je uspesno izmenjen";
                        }
                        break;

                    case Operation.PromeniSifru:
                        {
                            if (((string[])request.Argument)[0] == prijavljeniKorisnik.Password)
                            {
                                prijavljeniKorisnik.Password = ((string[])request.Argument)             [1];
                                ServerController.Instance.PromeniSifru(prijavljeniKorisnik);
                                response.IsSuccessful = true;
                                response.Message = "Lozinka je uspešno promenjena";
                            }
                            else
                            {
                                response.IsSuccessful = false;
                                response.Message = "Stara lozinka se ne poklapa sa unetom";
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
                //response.IsSuccessful = false;
                response.Message = ex.Message;
            }
            //response.IsSuccessful = true;

            return response;
        }
    }
}
