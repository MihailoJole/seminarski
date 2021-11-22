using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{   [Serializable]
    public class Selo:IEntity
    {
        public int ID { get; set; }
        public String NazivSela { get; set; }

        public string TableName => "Selo";

        public string InsertValues => "";

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
                result.Add(new Selo
                {
                    ID = (int)reader[0],
                    NazivSela = (string)reader[1]
                });
            }
            return result;
        }
        public override string ToString()
        {
            return $"{NazivSela}";
        }
    }
}
