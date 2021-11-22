using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Exceptions
{
   public class SystemOperationException:Exception
    {
        public SystemOperationException() : base("Server ne može da obradi zahtev!")
        {
        }
        public SystemOperationException(string message) : base(message)
        {
        }
    }
}
