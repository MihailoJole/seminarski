using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.TakmicenjeSO
{
    public class ZapamtiTakmicenje : SystemOperationBase
    {

        protected override void ExecuteOperation(IEntity entity)
        {
            //repository.Save(entity);

            Takmicenje h = (Takmicenje)entity;
            repository.Save(entity);
            int id = repository.GetNewId(new Takmicenje());
            foreach (Statistika s in h.Statistika)
            {
                s.Takmicenje.ID = id;
                repository.Save(s);
            }
            
        }
    }
}
