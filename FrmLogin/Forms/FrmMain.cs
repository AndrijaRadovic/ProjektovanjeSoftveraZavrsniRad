using Common.Domain;
using FrmLogin.GUIControllers;
using FrmLogin.UserControls;
using FrmLogin.UserControls.UCProizvod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.Forms
{
    public partial class FrmMain : Form
    {
        public Uloga uloga;


        public FrmMain(Uloga uloga)
        {
            InitializeComponent();
            this.uloga = uloga;

            // Prodavci

            kreirajNalogProdavcaToolStripMenuItem.Click += (s, e) =>
                MainCoordinator.Instance.ShowProdavacPanel(UCMode.Create);
            izmeniProdavcaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPretragaProdavca();
            promeniSifruToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPromenaSifre();
            odjaviSeToolStripMenuItem.Click += (s, e) => Odjava();

            // Proizvodi

            kreirajProizvodToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowProizvodPanel(UCMode.Create);
            prikaziProizvodeToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPrikazProizvodaPanel();

            // Racuni

            kreirajRacunToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowRacunPanel(UCMode.Create);
            prikaziRacuneToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPrikazRacunaPanel();


            if (uloga != Uloga.Administrator)
            {
                kreirajNalogProdavcaToolStripMenuItem.Visible = false;
                izmeniProdavcaToolStripMenuItem.Visible = false;
                kreirajProizvodToolStripMenuItem.Visible = false;
                //prikaziProizvodeToolStripMenuItem.Visible = false;
            }
        }

        private void Odjava()
        {
            Communication.Instance.Close();

            Process.Start(Process.GetCurrentProcess().MainModule.FileName);

            Environment.Exit(0);
        }

        internal void ChangePanel(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
            pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        internal void ChangePanelProizvoda(Control control)
        {
            ((UCProizvod)(pnlMain.Controls[0])).pnlTip.Controls.Clear();
            ((UCProizvod)(pnlMain.Controls[0])).pnlTip.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void prodavacToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kreirajNalogProdavcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void izmeniProdavcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void kreirajProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
