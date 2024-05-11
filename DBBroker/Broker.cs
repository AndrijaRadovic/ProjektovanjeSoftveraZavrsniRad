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

        public void Add(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into {entity.TableName} values({entity.GetParameters()})";
            entity.PrepareCommand(command);
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

        public IEntity Login(Korisnik korisnik)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select * from {korisnik.TableName} where {korisnik.LoginQuery()}";
            SqlDataReader reader = cmd.ExecuteReader();
            korisnik = (Korisnik)korisnik.GetReaderResult(reader);
            reader.Close();
            cmd.Dispose();
            return korisnik;
        }

        public void Obrisi(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"Delete from {entity.TableName} where {entity.GetByIdQuery()}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        public void PromeniSifru(Korisnik prijavljeniKorisnik)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"Update {prijavljeniKorisnik.TableName} set {prijavljeniKorisnik.PromenaSifreQuery()} where {prijavljeniKorisnik.GetByIdQuery()}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Update(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"Update {entity.TableName} set {entity.UpdateQuery()} where {entity.GetByIdQuery()}";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public List<IEntity> VratiSve(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"Select {entity.GetSearchAttributes()} from {entity.TableName} {entity.JoinQuery()}";
            SqlDataReader reader = cmd.ExecuteReader();
            List<IEntity> entities = entity.ReadAllSearch(reader);
            reader.Close();
            cmd.Dispose();
            return entities;
        }
    }
}
