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
        public static Uloga uloga;


        public FrmMain(Uloga uloga)
        {
            InitializeComponent();
            FrmMain.uloga = uloga;

            //prodavci
            kreirajNalogProdavcaToolStripMenuItem.Click += (s, e) =>
                MainCoordinator.Instance.ShowProdavacPanel(UCMode.Create);
            izmeniProdavcaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPretragaProdavca();
            promeniSifruToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPromenaSifre();
            odjaviSeToolStripMenuItem.Click += (s, e) => Odjava();

            //proizvodi
            kreirajProizvodToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowProizvodPanel(UCMode.Create);



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
