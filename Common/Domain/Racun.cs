﻿using System;
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
            return "";
        }

        public string GetByIdQuery(string use = "")
        {
            throw new NotImplementedException();
        }

        public string GetFilterQuery(string filter, string field = "")
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
            return "*";
        }

        public string GetTableName(string use = "")
        {
            return TableName;
        }

        public string JoinQuery()
        {
            return " inner join Korisnik on Racun.sifraKorisnika = Korisnik.sifraKorisnika";
        }

        public void PrepareCommand(SqlCommand command, string use = "")
        {
            command.Parameters.AddWithValue("@datumVreme", DatumVreme);
            command.Parameters.AddWithValue("@ukupnaCenaRacuna", UkupnaCenaRacuna);
            command.Parameters.AddWithValue("@sifraKorisnika", Korisnik.SifraKorisnika);
        }

        public List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();

            while (reader.Read())
            {
                Racun racun = new Racun
                {
                    SifraRacuna = (int)reader["sifraRacuna"],
                    DatumVreme = (DateTime)reader["datumVreme"],
                    UkupnaCenaRacuna = (double)reader["ukupnaCenaRacuna"],
                    Korisnik = new Korisnik
                    {
                        SifraKorisnika = (int)reader["sifraKorisnika"],
                        Ime = (string)reader["ime"],
                        Prezime = (string)reader["prezime"],
                        Pol = (Pol)Enum.Parse(typeof(Pol), (string)reader["pol"]),
                        Uloga = (Uloga)Enum.Parse(typeof(Uloga), (string)reader["uloga"]),
                        Username = (string)reader["username"],
                        Password = null,
                        Jmbg = (string)reader["jmbg"]
                    }
                };
                entities.Add(racun);
            }

            return entities;
        }

        public string UpdateQuery(string field = "")
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return DatumVreme.ToString() + " " + Korisnik.Ime + " " + Korisnik.Prezime;
        }
    }
}