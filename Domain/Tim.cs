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
    public class Tim:IEntity
    {
     //   [Browsable(false)]
        public int ID { get; set; }
        public Selo Selo { get; set; }
        public String ImeTima { get; set; }
        [Browsable(false)]

        public string TableName => "Tim";
        [Browsable(false)]

        public string InsertValues => $"{Selo.ID},'{ImeTima}'";
        [Browsable(false)]

        public string IdName => "id";
        [Browsable(false)]

        public string JoinCondition => "on (t.IdSela=se.id)";
        [Browsable(false)]

        public string JoinTable => "join Selo se";
        [Browsable(false)]

        public string TableAlias => "t";
        [Browsable(false)]

        public object SelectValues => "t.Id, t.ImeTima, se.id, se.NazivSela";
        [Browsable(false)]

        public string WhereCondition => $"id={ID}";
        [Browsable(false)]

        public string GetUpdateValues => $"IdSela={Selo.ID},ImeTima='{ImeTima}'";
        [Browsable(false)]

        public string Uslov;
        [Browsable(false)]

        public string GeneralCondition => $"{Uslov}";
        [Browsable(false)]

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Tim
                {
                    ID= (int)reader[0],
                    ImeTima= (string)reader[1],
                    Selo= new Selo { ID=(int)reader[2],NazivSela=(string)reader[3]}
                });
            }
            return result;
        }
        public override string ToString()
        {
            return ImeTima;
        }
    }
}
