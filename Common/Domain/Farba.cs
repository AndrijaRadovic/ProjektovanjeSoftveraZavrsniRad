using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Farba : Proizvod
    {
        public new string TableName => "Farba";
        public string Boja { get; set; }
        public double VelicinaPakovanja { get; set; }
        public override string GetTableName(bool parent = false)
        {
            if (parent)
                return base.GetTableName();

            return this.TableName;
        }
        public override string GetParameters(bool parent = false)
        {
            if (parent)
                return base.GetParameters(parent);

            return "@sifraProizvoda, @boja, @velicinaPakovanja";
        }
        public override void PrepareCommand(SqlCommand command, bool parent = false)
        {
            if (parent)
                base.PrepareCommand(command, parent);

            else
            {
                command.Parameters.AddWithValue("@sifraProizvoda", SifraProizvoda);
                command.Parameters.AddWithValue("@boja", Boja);
                command.Parameters.AddWithValue("@velicinaPakovanja", VelicinaPakovanja);
            }
        }

        public override string GetSearchAttributes()
        {
            return "Proizvod.sifraProizvoda, nazivProizvoda, cena, boja, velicinaPakovanja";
        }
        public override string JoinQuery()
        {
            return " inner join Proizvod on Farba.sifraProizvoda = Proizvod.sifraProizvoda";
        }

        public override List<IEntity> ReadAllSearch(SqlDataReader reader)
        {
            List<IEntity> entities = new List<IEntity>();
            while (reader.Read())
            {
                Farba farba = new Farba
                {
                    SifraProizvoda = (int)reader["sifraProizvoda"],
                    Cena = (double)reader["cena"],
                    NazivProizvoda = (string)reader["nazivProizvoda"],
                    Boja = (string)reader["boja"],
                    VelicinaPakovanja = (double)reader["velicinaPakovanja"],
                    TipProizvoda = TipProizvoda.Farba
                };
                entities.Add(farba);
            }
            return entities;
        }
    }
}
