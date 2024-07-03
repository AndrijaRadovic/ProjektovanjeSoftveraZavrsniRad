using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Proizvod : IEntity
    {
        public int SifraProizvoda { get; set; }
        public string NazivProizvoda { get; set; }
        public double Cena { get; set; }
        public string TableName => "Proizvod";
        public TipProizvoda TipProizvoda { get; set; }
        public string DisplayValue => NazivProizvoda;

        public string PrimaryKey => SifraProizvoda.ToString();

        public object IdColumn => "sifraProizvoda";

        public string GetByIdQuery()
        {
            return $"sifraProizvoda = {SifraProizvoda}";
        }

        public string GetByIdQuery(string use = "")
        {
            throw new NotImplementedException();
        }

        public string GetFilterQuery(string filter)
        {
            return $"lower(nazivProizvoda) like concat('%',lower('{filter}'),'%')";
        }

        public virtual string GetParameters(bool parent = false)
        {
            return "@nazivProizvoda, @cena";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public virtual string GetSearchAttributes()
        {
            throw new NotImplementedException();
        }

        public virtual string GetTableName(bool parent = false)
        {
            return TableName;
        }

        public virtual string JoinQuery()
        {
            throw new NotImplementedException();
        }

        public string LoginQuery()
        {
            throw new NotImplementedException();
        }

        public virtual void PrepareCommand(SqlCommand command, bool parent = false)
        {
            command.Parameters.AddWithValue("@nazivProizvoda", NazivProizvoda);
            command.Parameters.AddWithValue("@cena", Cena);
        }

        public virtual List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string UpdateQuery(string field = "")
        {
            throw new NotImplementedException();
        }
    }
}
