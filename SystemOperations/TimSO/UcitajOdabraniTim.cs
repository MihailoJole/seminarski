using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.TimSO
{
   public  class UcitajOdabraniTim:SystemOperationBase
    {
        public Tim Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Tim>().ToList()[0];
        }
    }
}
