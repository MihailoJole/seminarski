using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Administrator:IEntity
    {
        [Browsable(false)]
        public bool StatusUlogavan { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        [Browsable(false)]
        public String Sifra { get; set; }
        public String  KorisnickoIme { get; set; }
        [Browsable(false)]
        public string TableName => "Administrator";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string IdName => "Id";
        [Browsable(false)]
        public string JoinCondition => "";
        [Browsable(false)]
        public string JoinTable => "";
        [Browsable(false)]
        public string TableAlias => "";
        [Browsable(false)]
        public object SelectValues => "*";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdateValues => "";
        [Browsable(false)]
        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Administrator
                {
                    Ime  = reader[1].ToString(),
                    Prezime = reader[2].ToString(),
                    KorisnickoIme=reader[4].ToString(),
                    Sifra= reader[3].ToString()
                });
            }
            return result;
        }
    }
}
