using Common.Domain;
using Server.SystemOperations.SOLogin;
using Server.SystemOperations.SOProdavac;
using Server.SystemOperations.SOProizvod;
using Server.SystemOperations.SORacun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerController
    {
        private static ServerController instance;
        public static ServerController Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServerController();
                return instance;
            }
        }

        internal void DodajProdavca(Korisnik korisnik)
        {
            KreirajProdavcaSO so = new KreirajProdavcaSO(korisnik);
            so.ExecuteTemplate();
        }

        internal void DodajProizvod(Proizvod proizvod)
        {
            KreirajNadredjeniProizvodSO nadredjeniSo = new KreirajNadredjeniProizvodSO(proizvod);
            nadredjeniSo.ExecuteTemplate();

            KreirajPodredjeniProizvod podredjeniSo = new KreirajPodredjeniProizvod(proizvod);
            podredjeniSo.ExecuteTemplate();
        }

        //Login
        internal object Login(Korisnik korisnik)
        {
            LoginSO loginSO = new LoginSO(korisnik);
            loginSO.ExecuteTemplate();
            return (Korisnik)loginSO.result;
        }

        internal Korisnik NadjiKorisnikaPoId(int id)
        {
            UcitajProdavcaSO so = new UcitajProdavcaSO(id);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal void ObrisiKorisnika(Korisnik izabraniKorisnik)
        {
            ObrisiProdavcaSO so = new ObrisiProdavcaSO(izabraniKorisnik);
            so.ExecuteTemplate();
        }

        internal List<Korisnik> PretraziKorisnikePoImenu(string ime)
        {
            PronadjiKorisnikeSO pretragaSO = new PronadjiKorisnikeSO(ime);
            pretragaSO.ExecuteTemplate();
            return pretragaSO.Result.Cast<Korisnik>().ToList();

        }

        internal void PromeniSifru(Korisnik prijavljeniKorisnik)
        {
            PromeniSifruSO so = new PromeniSifruSO(prijavljeniKorisnik);
            so.ExecuteTemplate();
        }

        internal void UpdateKorisnika(Korisnik korisnik)
        {
            IzmeniKorisnikaSO so = new IzmeniKorisnikaSO(korisnik);
            so.ExecuteTemplate();
        }

        internal List<Korisnik> VratiSveProdavce()
        {
            UcitajListuKorisnikaSO so = new UcitajListuKorisnikaSO();
            so.ExecuteTemplate();
            return so.result.Cast<Korisnik>().ToList();
        }
    }
}
