using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.AdministratorSO
{
    public class LoginSO:SystemOperationBase
    {
        public Administrator Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Administrator a = (Administrator)entity;
            foreach (Administrator ad in repository.GetAll(new Administrator()))
            {
                if (ad.KorisnickoIme == a.KorisnickoIme && ad.Sifra == a.Sifra) {
                    a.Ime = ad.Ime;
                    a.Prezime = ad.Prezime;
                    Result = a;
                }

            }
        }
    }
}
