using DatabaseBroker;
using Domain;
using Storage;
using Storage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.AdministratorSO;
using SystemOperations.SeloSO;
using SystemOperations.TakmicenjeSO;
using SystemOperations.MestoSO;
using SystemOperations.TimSO;
using SystemOperations.UcesnikSO;

namespace ControllerC
{
    public class Controller
    {
         private IGenericRepository repository;
        //private IStorageAdministrator storageAdministrator;
        public Administrator Administrator { get; set; }

      //  #region singleton
        private static Controller instance;

        private static object _lock = new object();
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }
        private Controller() {
            repository = new GenericRepository();
        }

        public Administrator Login(Administrator administrator)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(administrator);
            return so.Result;         
        }

        public void SaveTakmicenje(Takmicenje takmicenje)
        {
            ZapamtiTakmicenje so = new ZapamtiTakmicenje();
            so.ExecuteTemplate(takmicenje);
           
        }
        public List<Mesto> GetMesto() {
            VratiListuMesta so = new VratiListuMesta();
            so.ExecuteTemplate(new Mesto());
            return so.Result;
        }
        public void SaveUcesnik(Ucesnik ucesnik) {
            ZapamtiUcesnika so = new ZapamtiUcesnika();
            so.ExecuteTemplate(ucesnik);
        }

        public object GetSelo()
        {
            VratiListuSela so = new VratiListuSela();
            so.ExecuteTemplate(new Selo());
            return so.Result;
        }

        public object GetTim()
        {
            VratiListuTimova so = new VratiListuTimova();
            so.ExecuteTemplate(new Tim());
            return so.Result;
        }

        public void SaveTim(Tim tim)
        {
            ZapamtiTim so = new ZapamtiTim();
            so.ExecuteTemplate(tim);
        }

        public object GetUcesnik()
        {
            VratiListuUcesnika so = new VratiListuUcesnika();
            so.ExecuteTemplate(new Ucesnik());
            return so.Result;
        }

        public void DeleteUcesnik(Ucesnik ucesnik)
        {
            ObrisiOdabranogUcesnika so = new ObrisiOdabranogUcesnika();
            so.ExecuteTemplate(ucesnik);
        }

        public void DeleteTim(Tim tim)
        {
            ObrisiOdabraniTim so = new ObrisiOdabraniTim();
            so.ExecuteTemplate(tim);
        }

        public void UpdateUcesnik(Ucesnik ucesnik)
        {
            SacuvajIzmeneUcesnika so = new SacuvajIzmeneUcesnika();
            so.ExecuteTemplate(ucesnik);
        }

        public void UpdateTim(Tim tim)
        {
            SacuvajIzmeneTima so = new SacuvajIzmeneTima();
            so.ExecuteTemplate(tim);
        }

        public object GetUcesnikWithCondition(Ucesnik u)
        {
            PretraziUcesnike so = new PretraziUcesnike();
            so.ExecuteTemplate(u);
            return so.Result;
        }

        public object GetTimWithCondition(Tim t)
        {
            PretraziTim so = new PretraziTim();
            so.ExecuteTemplate(t);
            return so.Result;
        }

        public object GetTakmicenjeWithCondition(Takmicenje t)
        {
            PretraziTakmicenje so = new PretraziTakmicenje();
            so.ExecuteTemplate(t);
            return so.Result;
        }

        public object GetOneTakmicenjeWithCondition(Takmicenje t)
        {
          UcitajOdabranoTakmicenje so = new UcitajOdabranoTakmicenje();
            so.ExecuteTemplate(t);
            return so.Result;
        }

        public object GetOneTimWithCondition(Tim t)
        {
            UcitajOdabraniTim so = new UcitajOdabraniTim();
            so.ExecuteTemplate(t);
            return so.Result;
        }

        public object GetOneUcesnikWithCondition(Ucesnik u)
        {
            UcitajOdabranogUcesnika so = new UcitajOdabranogUcesnika();
            so.ExecuteTemplate(u);
            return so.Result;
        }

 
    }
}
