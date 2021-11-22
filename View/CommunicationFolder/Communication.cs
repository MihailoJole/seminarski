using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace View.CommunicationFolder
{
    public class Communication
    {
        private static Communication instance;

        private Socket socket;
        private CommunicationClient client;
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }
        private Communication()
        {

        }
        public void Connect()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9000);
            client = new CommunicationClient(socket);

        }
        //Takmicenje
        internal void SaveTakmicenje(Takmicenje tak)
        {
            Request request = new Request() { Operation = Operation.SaveTakmicenje, RequestObject = tak };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }

        internal List<Mesto> GetMesto()
        {
            Request request = new Request() { Operation = Operation.GetMesto};
            client.SendRequest(request);
           return (List<Mesto>)client.GetResponseResult();
        }

        internal void DeleteUcesnik(Ucesnik ucesnik)
        {
            Request request = new Request() { Operation = Operation.DeleteUcesnik,RequestObject=ucesnik};
            client.SendRequest(request);
            client.GetResponseResult();
        }
        internal void DeleteTim(Tim tim)
        {
            Request request = new Request() { Operation = Operation.DeleteTim, RequestObject = tim };
            client.SendRequest(request);
            client.GetResponseResult();
        }
        internal object GetUcesnik()
        {
            Request request = new Request() { Operation = Operation.GetUcesnik};
            client.SendRequest(request);
            return (List<Ucesnik>)client.GetResponseResult();
        }

        internal object GetTim()
        {
            Request request = new Request() { Operation = Operation.GetTim };
            client.SendRequest(request);
            return (List<Tim>)client.GetResponseResult();
        }

        internal List<Selo> GetSelo()
        {
            Request request = new Request() { Operation = Operation.GetSelo };
            client.SendRequest(request);
            return (List<Selo>)client.GetResponseResult();
        }

        internal void SaveTim(Tim t)
        {
            Request request = new Request() { Operation = Operation.SaveTim, RequestObject = t };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal Administrator Login(string korisnickoIme, string sifra)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                RequestObject = new Administrator{ KorisnickoIme= korisnickoIme, Sifra= sifra}
            };
            client.SendRequest(request);
            return (Administrator)client.GetResponseResult();
        }

        internal void UpdateUcesnik(Ucesnik u)
        {
            Request request = new Request() { Operation = Operation.UpdateUcesnik, RequestObject = u };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void SaveUcesnik(Ucesnik u)
        {
            Request request = new Request() { Operation = Operation.SaveUcesnik, RequestObject = u };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal void UpdateTim(Tim t)
        {
            Request request = new Request() { Operation = Operation.UpdateTim, RequestObject = t };
            client.SendRequest(request);
            client.GetResponseResult();
        }

        internal List<Ucesnik> GetUcesnikWithCondition(Ucesnik u)
        {
            Request request = new Request() { Operation = Operation.GetUcesnikWithCondition,RequestObject=u};
            client.SendRequest(request);
            return (List<Ucesnik>)client.GetResponseResult();
        }

        internal List<Tim> GetTimWithCondition(Tim t)
        {
            Request request = new Request() { Operation = Operation.GetTimkWithCondition, RequestObject = t };
            client.SendRequest(request);
            return (List<Tim>)client.GetResponseResult();
        }

        internal List<Takmicenje> GetTakmicenjeWithCondition(Takmicenje tak)
        {
            Request request = new Request() { Operation = Operation.GetTakmicenjeWithCondition, RequestObject = tak };
            client.SendRequest(request);
            return (List<Takmicenje>)client.GetResponseResult();
        }

        internal Takmicenje GetOneTakmicenjeWithCondition(Takmicenje tak)
        {
            Request request = new Request() { Operation = Operation.GetOneTakmicenjekWithCondition, RequestObject = tak };
            client.SendRequest(request);
            return (Takmicenje)client.GetResponseResult();
        }

        internal Tim GetOneTimWithCondition(Tim t)
        {
            Request request = new Request() { Operation = Operation.GetOneTimWithCondition, RequestObject = t };
            client.SendRequest(request);
            return (Tim)client.GetResponseResult();
        }

        internal Ucesnik GetOneUcesnikWithCondition(Ucesnik u)
        {
            Request request = new Request() { Operation = Operation.GetOneUcesnikWithCondition, RequestObject = u };
            client.SendRequest(request);
            return (Ucesnik)client.GetResponseResult();
        }
    }
}
