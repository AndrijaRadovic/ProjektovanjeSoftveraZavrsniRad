using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Korisnik : IEntity
    {
        public int SifraKorisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Pol Pol { get; set; }
        public Uloga Uloga { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Jmbg { get; set; }

        public string TableName => "Korisnik1";

        public string DisplayValue => Username;

        public string PrimaryKey => SifraKorisnika.ToString();

        public string GetByIdQuery()
        {
            return $"username='{Username}' and password='{Password}'";
        }

        public string GetFilterQuery()
        {
            throw new NotImplementedException();
        }

        public string GetParameters()
        {
            return "@ime, @prezime, @pol, @uloga, @username, @password, @jmbg";
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity GetReaderResult(SqlDataReader reader)
        {
            if (reader.Read())
            {
                Korisnik korisnik = new Korisnik()
                {
                    SifraKorisnika = (int)reader["sifraKorisnika"],
                    Ime = (string)reader["ime"],
                    Prezime = (string)reader["prezime"],
                    Pol = (Pol)Enum.Parse(typeof(Pol), (string)reader["pol"]),
                    Uloga = (Uloga)Enum.Parse(typeof(Uloga), (string)reader["uloga"]),
                    Username = (string)reader["username"],
                    Password = (string)reader["password"],
                    Jmbg = (string)reader["jmbg"]
                };
                return korisnik;
            }
            return null;
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
            command.Parameters.AddWithValue("@ime", Ime);
            command.Parameters.AddWithValue("@prezime", Prezime);
            command.Parameters.AddWithValue("@pol", Pol.ToString());
            command.Parameters.AddWithValue("@uloga", Uloga.ToString());
            command.Parameters.AddWithValue("@username", Username);
            command.Parameters.AddWithValue("@password", Password);
            command.Parameters.AddWithValue("@jmbg", Jmbg);
        }

        public List<IEntity> ReadAllSearch()
        {
            throw new NotImplementedException();
        }

        public string UpdateQuery()
        {
            throw new NotImplementedException();
        }
    }
}
