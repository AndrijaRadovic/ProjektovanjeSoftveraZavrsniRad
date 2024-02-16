using Common.Domain;
using FrmLogin.Forms;
using FrmLogin.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin.GUIControllers
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        public MainCoordinator()
        {
            //instancirati sve GUI kontrolere osim logina
            prodavacGUIController = new ProdavacGUIController();
        }

        private FrmMain frmMain;
        private ProdavacGUIController prodavacGUIController;

        internal void ShowFrmMain(Uloga uloga)
        {
            frmMain = new FrmMain(uloga);
            frmMain.AutoSize = true;
            //ShowDefault();
            frmMain.ShowDialog();
        }

        internal void ShowProdavacPanel(UCMode mode, Korisnik korisnik = null)
        {
            frmMain.ChangePanel(prodavacGUIController.CreateUCProdavac(mode, korisnik));
        }

        internal void ShowDefault()
        {
            UCDefaultMain main = new UCDefaultMain();
            //Dodati neku funkcionalnost ako zatreba
            frmMain.ChangePanel(main);
        }
    }
}
