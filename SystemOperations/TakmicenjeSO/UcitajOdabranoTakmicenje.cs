using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.TakmicenjeSO
{
   public  class UcitajOdabranoTakmicenje:SystemOperationBase
    {
        public Takmicenje Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Takmicenje>().ToList()[0];
            Statistika s = new Statistika();
            s.uslov = $"s.IdTakmicenja={Result.ID}";            
            Result.Statistika=repository.GetAllWithCondition(s).Cast<Statistika>().ToList();
            //Result.Statistika = new List<Statistika> { new Statistika { DizajnPoeni = 1 } };
        }
    }
}
