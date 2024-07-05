using Common.Domain;
using FrmLogin.Forms;
using FrmLogin.UserControls;
using FrmLogin.UserControls.UCRacun;
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
        public Korisnik Korisnik { get; set; }
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

        private FrmMain frmMain;
        private KorisnikGUIController korisnikGUIController;
        private ProizvodGUIController proizvodGUIController;
        private RacunGUIController racunGUIController;

        public MainCoordinator()
        {
            //instancirati sve GUI kontrolere osim logina
            korisnikGUIController = new KorisnikGUIController();
            proizvodGUIController = new ProizvodGUIController();
            racunGUIController = new RacunGUIController();
        }
        internal void ShowFrmMain(Korisnik korisnik)
        {
            Korisnik = korisnik;
            frmMain = new FrmMain(korisnik.Uloga);
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

        internal void ShowProizvodPanel(UCMode mode, Proizvod proizvod = null)
        {
            frmMain.ChangePanel(proizvodGUIController.CreateUCProizvod(mode, proizvod));
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

        internal void ShowPrikazProizvodaPanel()
        {
            frmMain.ChangePanel(proizvodGUIController.createUCPrikazProizvoda(frmMain.uloga));
        }

        internal void ShowRacunPanel(UCMode mode, Racun racun = null)
        {
            frmMain.ChangePanel(racunGUIController.createUCRacun(mode, racun));
        }
    }
}
