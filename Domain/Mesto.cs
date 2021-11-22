using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Mesto : IEntity
    {
        public int ID { get; set; }
        public String NazivMesta { get; set; }
        public int PTTBroj { get; set; }
        public string TableName => "Mesto";

        public string InsertValues => $"'{NazivMesta}',{PTTBroj}";

        public string IdName => "";

        public string JoinCondition => "";

        public string JoinTable => "";

        public string TableAlias => "";

        public object SelectValues => "*";

        public string WhereCondition => "";

        public string GetUpdateValues => "";

        public string GeneralCondition => "";

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Mesto
                {
                    ID = (int)reader[0],
                    NazivMesta = (string)reader[1],
                    PTTBroj=(int)reader[2]
                });
            }
            return result;
        }
        public override string ToString()
        {
            return NazivMesta;
        }
    }
}
