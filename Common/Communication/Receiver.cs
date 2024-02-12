using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public class Receiver
    {
        private NetworkStream stream;
        private BinaryFormatter formatter;
        private Socket socket;

        public Receiver(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public Object Receive()
        {
            return formatter.Deserialize(stream);
        }
    }
}
