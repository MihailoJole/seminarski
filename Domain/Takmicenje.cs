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
    public class Takmicenje:IEntity
    {
        //[Browsable(false)]
        public int ID { get; set; }
        public String Nivo { get; set; }
        public DateTime DatumO { get; set; }
       // public List<Tim> Timovi { get; set; }
        public List<Statistika> Statistika{ get; set; } 
        [Browsable(false)]
        public string TableName => "Takmicenje";
        [Browsable(false)]
        public string InsertValues => $"'{Nivo}','{DatumO}'";
        [Browsable(false)]
        public string IdName => "id";
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
        
        public string Uslov;
        [Browsable(false)]
        public string GeneralCondition => $"{Uslov}";
        [Browsable(false)]
        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Takmicenje
                {
                    ID = (int)reader[0],
                    DatumO=(DateTime)reader[2],
                    Nivo= (string)reader[1]
                });
            }
            return result;
        }
        public override string ToString()
        {
            return Nivo;
        }
    }
}
