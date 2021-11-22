using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.UcesnikSO
{
    public class VratiListuUcesnika : SystemOperationBase
    {
        public List<Ucesnik> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Ucesnik()).Cast<Ucesnik>().ToList();
        }
    }
}
