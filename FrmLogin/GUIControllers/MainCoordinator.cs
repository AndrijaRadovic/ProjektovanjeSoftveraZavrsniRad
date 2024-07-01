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
            korisnikGUIController = new KorisnikGUIController();
            proizvodGUIController = new ProizvodGUIController();
        }

        private FrmMain frmMain;
        private KorisnikGUIController korisnikGUIController;
        private ProizvodGUIController proizvodGUIController;

        internal void ShowFrmMain(Uloga uloga)
        {
            frmMain = new FrmMain(uloga);
            frmMain.AutoSize = true;
            //ShowDefault();
            frmMain.ShowDialog();
        }

        internal void ShowProdavacPanel(UCMode mode, Korisnik korisnik = null)
        {
            frmMain.ChangePanel(korisnikGUIController.CreateUCProdavac(mode, korisnik));
        }

        internal void ShowDefault()
        {
            UCDefaultMain main = new UCDefaultMain();
            //Dodati neku funkcionalnost ako zatreba
            frmMain.ChangePanel(main);
        }

        internal void ShowProizvodPanel(UCMode mode)
        {
            frmMain.ChangePanel(proizvodGUIController.CreateUCProizvod(UCMode.Create));
        }

        internal void ShowPretragaProdavca()
        {
            frmMain.ChangePanel(korisnikGUIController.CreateUCIzmeniProdavca());
        }

        internal void ShowPromenaSifre()
        {
            frmMain.ChangePanel(korisnikGUIController.createUCPromenaSifre());
        }

        internal void ShowOdgovarajuciProizvodPanel(TipProizvoda tipProizvoda)
        {
            frmMain.ChangePanelProizvoda(proizvodGUIController.createUCTipProizvoda(tipProizvoda));
        }
    }
}
