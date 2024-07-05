using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class StavkaRacuna : IEntity
    {
        public Racun Racun { get; set; }
        public int RedniBroj { get; set; }
        public int Kolicina { get; set; }
        public double UkupnaCenaStavke { get; set; }
        public Proizvod Proizvod { get; set; }

        public string TableName => "StavkaRacuna";

        public string DisplayValue => RedniBroj.ToString();

        public string PrimaryKey => "redniBroj";

        public object IdColumn => "redniBroj";

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
            return "@sifraRacuna, @redniBroj, @kolicina, @ukupnaCenaStavke, @sifraProizvoda";
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
            return TableName;
        }

        public string JoinQuery()
        {
            throw new NotImplementedException();
        }

        public void PrepareCommand(SqlCommand command, string use = "")
        {
            
            command.Parameters.AddWithValue("@sifraRacuna", Racun.SifraRacuna);
            command.Parameters.AddWithValue("@redniBroj", RedniBroj);
            command.Parameters.AddWithValue("@kolicina", Kolicina);
            command.Parameters.AddWithValue("@ukupnaCenaStavke", UkupnaCenaStavke);
            command.Parameters.AddWithValue("@sifraProizvoda", Proizvod.SifraProizvoda);
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
