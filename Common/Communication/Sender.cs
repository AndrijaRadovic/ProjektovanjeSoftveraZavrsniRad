using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Communication
{
    public class Sender
    {
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Sender(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public void Send(Object message)
        {
            try
            {
                formatter.Serialize(stream, message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri komunikaciji sa serverom");
                Debug.WriteLine(">>> " + ex.Message);
                Environment.Exit(0);
            }

        }
    }
}
