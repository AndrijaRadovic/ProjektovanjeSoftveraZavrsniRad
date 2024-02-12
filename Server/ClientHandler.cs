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
                            //response.IsSuccessful = true;
                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(">>> " + ex.Message);
                //response.IsSuccessful = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
