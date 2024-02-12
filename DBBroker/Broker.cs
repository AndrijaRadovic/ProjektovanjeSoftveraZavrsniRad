using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        DBConnection connection;
        public Broker()
        {
            connection = new DBConnection();
        }
        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public IEntity GetEntityById(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select * from {entity.TableName} where {entity.GetByIdQuery()}";
            SqlDataReader reader = cmd.ExecuteReader();
            entity = entity.GetReaderResult(reader);
            reader.Close();
            cmd.Dispose();
            return entity;
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        public void Rollback()
        {
            connection.Rollback();
        }
    }
}
