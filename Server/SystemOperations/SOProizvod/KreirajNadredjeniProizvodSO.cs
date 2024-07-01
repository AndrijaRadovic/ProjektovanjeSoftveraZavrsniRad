using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.SOProizvod
{
    internal class KreirajNadredjeniProizvodSO : SystemOperationBase
    {
        private Proizvod proizvod;

        public KreirajNadredjeniProizvodSO(Proizvod proizvod)
        {
            this.proizvod = proizvod;
        }

        public override void ExecuteConcreteOperation()
        {
            broker.Add(proizvod, true);
            //proizvod.SifraProizvoda = broker.GetLastId(proizvod);
            //broker.Add(proizvod, false);
        }
    }
}
