using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.SORacun
{
    internal class StornirajRacunSO : SystemOperationBase
    {
        private Racun racun;

        public StornirajRacunSO(Racun racun)
        {
            this.racun = racun;
        }

        public override void ExecuteConcreteOperation()
        {
            int id = broker.AddWithId(racun);

            foreach (StavkaRacuna sr in racun.StavkeRacuna)
            {
                sr.Racun.SifraRacuna = id;
                broker.Add(sr);
            }

            // Druga opcija (ako mora ovde da se stornira)

            //List<StavkaRacuna> noveStavke = new List<StavkaRacuna>(racun.StavkeRacuna);

            //foreach (StavkaRacuna stavka in noveStavke)
            //{
            //    stavka.Kolicina *= -1;
            //    stavka.UkupnaCenaStavke *= -1;
            //}

            //Racun stornoRacun = new Racun
            //{
            //    DatumVreme = DateTime.Now,
            //    UkupnaCenaRacuna = racun.UkupnaCenaRacuna * -1,
            //    // Korisnik = racun.Instance.Korisnik,           // Korisnik bi svakako morao da se podesi na frontu
            //    StavkeRacuna = noveStavke
            //};
        }
    }
}
