﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.UcesnikSO
{
    public class SacuvajIzmeneUcesnika : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Update(entity);
        }
    }
}
