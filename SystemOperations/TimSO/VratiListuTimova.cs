using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.TimSO
{
    public class VratiListuTimova : SystemOperationBase
    {
        public List<Tim> Result { get; private set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Tim()).Cast<Tim>().ToList();
        }
    }
}
