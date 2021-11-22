using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.MestoSO
{
    public class VratiListuMesta : SystemOperationBase
    {
        public List<Mesto> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Mesto()).Cast<Mesto>().ToList();
        }
    }
}
