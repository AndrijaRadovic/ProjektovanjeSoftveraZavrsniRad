using Common.Domain;
using FrmLogin.GUIControllers;
using FrmLogin.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.Forms
{
    public partial class FrmMain : Form
    {
        private Uloga uloga;


        public FrmMain(Uloga uloga)
        {
            InitializeComponent();
            this.uloga = uloga;

            //prodavci
            kreirajNalogProdavcaToolStripMenuItem.Click += (s, e) =>
                MainCoordinator.Instance.ShowProdavacPanel(UCMode.Create);
            izmeniProdavcaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPretragaProdavca();

            //proizvodi
            kreirajProizvodToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowProizvodPanel(UCMode.Create);



            if (uloga != Uloga.Administrator)
            {
                //prodavacToolStripMenuItem.Enabled = false;
                //kreirajProizvodToolStripMenuItem.Enabled = false;
                //obrisiProizvodToolStripMenuItem.Enabled = false;
                prodavacToolStripMenuItem.Visible = false;
                kreirajProizvodToolStripMenuItem.Visible = false;
                obrisiProizvodToolStripMenuItem.Visible = false;
            }
        }


        internal void ChangePanel(Control control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
            pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
    }
}
