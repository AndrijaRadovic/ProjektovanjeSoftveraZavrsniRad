using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Plocice : Proizvod
    {
        public new string TableName => "Plocice";
        public string Materijal { get; set; }
        public double Duzina { get; set; }
        public double Sirina { get; set; }
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

            return "@sifraProizvoda, @materijal, @duzina, @sirina";
        }
        public override void PrepareCommand(SqlCommand command, bool parent = false)
        {
            if(parent)
                base.PrepareCommand(command, parent);

            else
            {
                command.Parameters.AddWithValue("@sifraProizvoda", SifraProizvoda);
                command.Parameters.AddWithValue("@materijal", Materijal);
                command.Parameters.AddWithValue("@duzina", Duzina);
                command.Parameters.AddWithValue("@sirina", Sirina);
            }
        }
    }
}
