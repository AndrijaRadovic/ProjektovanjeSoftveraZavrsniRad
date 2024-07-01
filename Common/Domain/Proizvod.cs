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

        public string DisplayValue => NazivProizvoda;

        public string PrimaryKey => SifraProizvoda.ToString();

        public object IdColumn => "sifraProizvoda";

        public string GetByIdQuery()
        {
            throw new NotImplementedException();
        }

        public string GetFilterQuery(string filter)
        {
            throw new NotImplementedException();
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

        public string GetSearchAttributes()
        {
            throw new NotImplementedException();
        }

        public virtual string GetTableName(bool parent = false)
        {
            return TableName;
        }

        public string JoinQuery()
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

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public string UpdateQuery()
        {
            throw new NotImplementedException();
        }
    }
}
