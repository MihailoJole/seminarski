using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.UcesnikSO
{
    public class UcitajOdabranogUcesnika:SystemOperationBase
    {

        public Ucesnik Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Ucesnik>().ToList()[0];
        }
    }
}
