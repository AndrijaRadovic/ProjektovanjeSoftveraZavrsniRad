using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Racun : IEntity
    {
        public int SifraRacuna { get; set; }
        public DateTime DatumVreme { get; set; }
        public double UkupnaCenaRacuna { get; set; }
        public Korisnik Korisnik { get; set; }
        public List<StavkaRacuna> StavkeRacuna { get; set; }

        public string TableName => "Racun";
        public string DisplayValue => throw new NotImplementedException();

        public string PrimaryKey => "sifraRacuna";

        public object IdColumn => "sifraRacuna";

        public string AddColumn()
        {
            throw new NotImplementedException();
        }

        public string GetByIdQuery(string use = "")
        {
            throw new NotImplementedException();
        }

        public string GetFilterQuery(string filter)
        {
            throw new NotImplementedException();
        }

        public string GetParameters(string use = "")
        {
            return "@datumVreme, @ukupnaCenaRacuna, @sifraKorisnika";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string GetSearchAttributes()
        {
            throw new NotImplementedException();
        }

        public string GetTableName(string use = "")
        {
            throw new NotImplementedException();
        }

        public string JoinQuery()
        {
            throw new NotImplementedException();
        }

        public void PrepareCommand(SqlCommand command, string use = "")
        {
            command.Parameters.AddWithValue("@datumVreme", DatumVreme);
            command.Parameters.AddWithValue("@ukupnaCenaRacuna", UkupnaCenaRacuna);
            command.Parameters.AddWithValue("@sifraKorisnika", Korisnik.SifraKorisnika);
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string UpdateQuery(string field = "")
        {
            throw new NotImplementedException();
        }
    }
}
