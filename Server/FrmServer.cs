using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        ServerCommunication server;

        public FrmServer()
        {
            InitializeComponent();
            server = new ServerCommunication();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

                server.StartServer();

                btnStart.Enabled = false;
                btnStop.Enabled = true;
                lblStatus.Text = "Pokrenut";
                lblStatus.ForeColor = Color.Green;

        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.Text = "Ugašen";
            lblStatus.ForeColor = Color.Red;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.StopServer();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.Text = "Ugašen";
            lblStatus.ForeColor = Color.Red;
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnStop_Click(sender, e);
            Environment.Exit(0);
        }
    }
}
