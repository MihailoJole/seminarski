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
    public class Statistika : IEntity
    {
        public Takmicenje Takmicenje { get; set; }
        public Tim Tim { get; set; }
        public int BacanjeKamena { get; set; }
        public int ObaranjeRuku { get; set; }
        public int NadvlacenjeStapa { get; set; }
        public int VucaKonopca { get; set; }
        public int UkupnoBodovi { get; set; }
        public int OsvojenoMesto { get; set; }
        [Browsable(false)]
        public string TableName => "Statistika";
        [Browsable(false)]
        public string InsertValues => $"{Takmicenje.ID},{Tim.ID},{BacanjeKamena},{ObaranjeRuku},{NadvlacenjeStapa},{VucaKonopca},{UkupnoBodovi},{OsvojenoMesto}";
        [Browsable(false)]
        public string IdName => "id";
        [Browsable(false)] 
        public string JoinCondition => "on (tak.Id=s.IdTakmicenja) join tim t on (t.Id=s.IdTima)";
        [Browsable(false)]
        public string JoinTable => "join takmicenje tak";
        [Browsable(false)]
        public string TableAlias => "s";
        [Browsable(false)]        
        public object SelectValues => "s.BacanjeKamena,s.ObaranjeRuku,s.NadvlacenjeStapa,s.VucaKonopca,s.UkupnoBodovi,s.OsvojenoMesto,tak.id,tak.DatumO,tak.Nivo,t.id,t.ImeTima";
        [Browsable(false)]
        public string WhereCondition => "";
        [Browsable(false)]
        public string GetUpdateValues => "";
        public string uslov;
        [Browsable(false)]
        public string GeneralCondition => $"{uslov}";
        [Browsable(false)]

        public List<IEntity> GetEntities(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                result.Add(new Statistika
                {
                    BacanjeKamena = (int)reader[0],
                    ObaranjeRuku = (int)reader[1],
                    NadvlacenjeStapa = (int)reader[2],
                    VucaKonopca = (int)reader[3],
                    UkupnoBodovi = (int)reader[4],
                    OsvojenoMesto = (int)reader[5],
                    Takmicenje= new Takmicenje { ID=(int)reader[6],DatumO=(DateTime)reader[7],Nivo=(string)reader[8]},
                    Tim= new Tim { ID=(int)reader[9],ImeTima=(string)reader[10]}

                });
            }
            return result;
        }
    }
}
