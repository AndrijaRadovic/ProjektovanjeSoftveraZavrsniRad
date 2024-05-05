using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations.SOProdavac
{
    internal class PronadjiKorisnikeSO : SystemOperationBase
    {
        private string ime;
        public List<IEntity> Result { get; set; }

        public PronadjiKorisnikeSO(string ime)
        {
            this.ime = ime;
        }

        public override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllByFilter(new Korisnik(), ime);
        }
    }
}
