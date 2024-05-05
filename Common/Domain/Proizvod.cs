using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    internal class Proizvod : IEntity
    {
        public int SifraProizvoda { get; set; }
        public string NazivProizvoda { get; set; }
        public double Cena { get; set; }
        public string TableName => "Proizvod";

        public string DisplayValue => NazivProizvoda;

        public string PrimaryKey => SifraProizvoda.ToString();

        public string GetByIdQuery()
        {
            throw new NotImplementedException();
        }

        public string GetFilterQuery(string filter)
        {
            throw new NotImplementedException();
        }

        public string GetParameters()
        {
            throw new NotImplementedException();
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

        public string JoinQuery()
        {
            throw new NotImplementedException();
        }

        public void PrepareCommand(SqlCommand command)
        {
            throw new NotImplementedException();
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
