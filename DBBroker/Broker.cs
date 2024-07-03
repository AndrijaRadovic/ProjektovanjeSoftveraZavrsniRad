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

        public void Add(IEntity entity, bool parent = false)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into {entity.GetTableName(parent)} values({entity.GetParameters(parent)})";
            entity.PrepareCommand(command, parent);
            command.ExecuteNonQuery();
            command.Dispose();
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

        public List<IEntity> GetAllByFilter(IEntity entity, string filter)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"Select {entity.GetSearchAttributes()} from {entity.TableName} where {entity.GetFilterQuery(filter)}";
            SqlDataReader reader = cmd.ExecuteReader();
            List<IEntity> entities = entity.ReadAllSearch(reader);
            reader.Close();
            cmd.Dispose();
            return entities;
        }

        public IEntity GetEntityById(IEntity entity, string use = "")
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select * from {entity.TableName} where {entity.GetByIdQuery(use)}";
            SqlDataReader reader = cmd.ExecuteReader();
            entity = entity.GetReaderResult(reader);
            reader.Close();
            cmd.Dispose();
            return entity;
        }

        public void Delete(IEntity entity, bool parent = false)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"Delete from {entity.GetTableName(parent)} where {entity.GetByIdQuery()}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Update(IEntity entity, string field = "")
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"Update {entity.TableName} set {entity.UpdateQuery(field)} where {entity.GetByIdQuery()}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"Select {entity.GetSearchAttributes()} from {entity.GetTableName()} {entity.JoinQuery()}";
            SqlDataReader reader = cmd.ExecuteReader();
            List<IEntity> entities = entity.ReadAllSearch(reader);
            reader.Close();
            cmd.Dispose();
            return entities;
        }

        public int GetLastId(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"Select max({entity.IdColumn}) from {entity.GetTableName(true)}";
            int maxId = (int) cmd.ExecuteScalar();
            cmd.Dispose();
            return maxId;
        }
    }
}
