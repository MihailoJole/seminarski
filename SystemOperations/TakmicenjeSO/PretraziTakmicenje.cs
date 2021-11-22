using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.TakmicenjeSO
{
   public class PretraziTakmicenje:SystemOperationBase
    {
        public List<Takmicenje> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Takmicenje>().ToList();
        }
    }
}
