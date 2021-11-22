using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.SeloSO
{
    public class VratiListuSela : SystemOperationBase
    {
        public List<Selo> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Selo()).Cast<Selo>().ToList();
        }
    }
}
