using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.SOProizvod
{
    internal class KreirajPodredjeniProizvod : SystemOperationBase
    {
        private Proizvod proizvod;

        public KreirajPodredjeniProizvod(Proizvod proizvod)
        {
            this.proizvod = proizvod;
        }

        public override void ExecuteConcreteOperation()
        {
            proizvod.SifraProizvoda = broker.GetLastId(proizvod);
            broker.Add(proizvod, false);
        }
    }
}
