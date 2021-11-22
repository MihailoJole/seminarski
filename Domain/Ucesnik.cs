using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{[Serializable]
    public class Ucesnik : IEntity
    {

        public String Ime { get; set; }
        public String Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public String JMBG { get; set; }
        public String Kontakt { get; set; }
       // [Browsable(false)]
        public int ID { get; set; }
        public Mesto Mesto { get; set; }
        public Tim Tim { get; set; }
        [Browsable(false)]

        public string TableName => "Ucesnik";
        [Browsable(false)]

        public string InsertValues => $"{Tim.ID},{Mesto.ID},'{JMBG}','{Ime}','{Prezime}','{Kontakt}','{DatumRodjenja}'";
        [Browsable(false)]

        public string IdName => "id";
        [Browsable(false)]

        public string JoinCondition => "on (m.id=u.IdMesta) join tim t on (t.id=u.IdTima)";
        [Browsable(false)]

        public string JoinTable => $"join mesto m";
        [Browsable(false)]

        public string TableAlias => "u";
        [Browsable(false)]

        public object SelectValues => "u.JMBG,u.Ime,u.Prezime,u.Kontakt,u.DatumRodjenja,m.id,m.NazivMesta,m.PTTBroj,t.id,t.ImeTima,u.ID";
        [Browsable(false)]

        public string WhereCondition => $"id={ID}";
        [Browsable(false)]

        public string GetUpdateValues => $"IdMesta={Mesto.ID},IdTima={Tim.ID},JMBG='{JMBG}',Ime='{Ime}',Prezime='{Prezime}',Kontakt='{Kontakt}',DatumRodjenja='{DatumRodjenja}'";
        

        public string Uslov;
        [Browsable(false)]
        public string GeneralCondition => $"{Uslov}";
        [Browsable(false)]

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Ucesnik
                {
                    ID=(int)reader[10],
                    JMBG=(string)reader[0],
                    Ime=(string)reader[1],
                    Prezime=(string)reader[2],
                    Kontakt=(string)reader[3],
                    DatumRodjenja=(DateTime)reader[4],
                    Mesto= new Mesto { ID=(int)reader[5],NazivMesta=(string)reader[6],PTTBroj=(int)reader[7]},
                    Tim= new Tim { ID=(int)reader[8],ImeTima=(string)reader[9]}
                });
            }
            return result;
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime} {DatumRodjenja.ToString("dd.MM.yyyy.")}";
        }
    }
}
