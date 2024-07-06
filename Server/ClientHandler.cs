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

                    case Operation.PretraziKorisnike:
                        {
                            response.Result = ServerController.Instance.PretraziKorisnike((string[])request.Argument);
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
                                prijavljeniKorisnik.Password = ((string[])request.Argument)[1];
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

                    case Operation.DodajProizvod:
                        {
                            ServerController.Instance.DodajProizvod((Proizvod)request.Argument);
                            response.Message = "Proizvod je uspesno dodat";
                        }
                        break;

                    case Operation.VratiSveProizvode:
                        {
                            response.Result = ServerController.Instance.VratiSveProizvode();
                        }
                        break;

                    case Operation.ObrisiProizvod:
                        {
                            ServerController.Instance.ObrisiProizvod((Proizvod)request.Argument);
                            response.Message = "Proizvod je uspesno obrisan";
                        }
                        break;

                    case Operation.PretraziProizvodePoNazivu:
                        {
                            response.Result = ServerController.Instance.PretraziProizvodePoNazivu((string)request.Argument);
                        }
                        break;

                    case Operation.UpdateProizvod:
                        {
                            ServerController.Instance.UpdateProizvod((Proizvod)request.Argument);
                            response.Message = "Proizvod je uspesno izmenjen";
                        }
                        break;

                    case Operation.NadjiProizvodPoId:
                        {
                            response.Result = ServerController.Instance.NadjiProizvodPoId((int)request.Argument);
                        }
                        break;

                    case Operation.DodajRacun:
                        {
                            ServerController.Instance.DodajRacun((Racun)request.Argument);
                            response.Message = "Racun je uspesno dodat";
                        }
                        break;

                    case Operation.VratiSveRacune:
                        {
                            response.Result = ServerController.Instance.VratiSveRacune();
                        }
                        break;

                    case Operation.StornirajRacun:
                        {
                            ServerController.Instance.StornirajRacun((Racun)request.Argument);
                            response.Message = "Racun je uspesno storniran";
                        }
                        break;

                    case Operation.PretraziRacunePoDatumu:
                        {
                            response.Result = ServerController.Instance.PretraziRacunePoDatumu((DateTime)request.Argument);
                        }
                        break;

                    case Operation.NadjiRacunPoId:
                        {
                            response.Result = ServerController.Instance.NadjiRacunPoId((int)request.Argument);
                        }
                        break;

                    case Operation.UpdateRacun:
                        {
                            ServerController.Instance.UpdateRacun((Racun)request.Argument);
                            response.Message = "Racun je uspesno azuriran";
                        }
                        break;
                }
                response.IsSuccessful = true;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(">>> " + ex.Message);
                response.IsSuccessful = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
