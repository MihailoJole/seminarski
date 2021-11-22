using Common;
using ControllerC;
using Domain;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerskaStrana
{
    internal class ClientHandler
    {
        private Socket client;
        private readonly BindingList<Administrator> administratori;
        private Administrator ulogovaniAdministrator;


        public ClientHandler(Socket client, BindingList<Administrator> administratori)
        {
            this.client = client;
            this.administratori = administratori;
        }

        internal void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(client);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.IsSuccessful = false;
                        response.Error = ex.Message;
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                administratori.Remove(ulogovaniAdministrator);

            }
            catch (SerializationException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
                administratori.Remove(ulogovaniAdministrator);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Doslo je do prekida veze");
                administratori.Remove(ulogovaniAdministrator);
            }

        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.IsSuccessful = true;
            switch (request.Operation)
            {
                case Operation.Login:
                    Administrator a= Controller.Instance.Login((Administrator)request.RequestObject);                  
                    if (a != null) {
                        a.StatusUlogavan = administratori.Any(aa => aa.Sifra == a.Sifra);
                        ulogovaniAdministrator = a;
                        administratori.Add(ulogovaniAdministrator);
                    }
                    response.Result = a;
                    //ulogovaniAdministrator = (Administrator)response.Result;
                    break;
                case Operation.SaveTakmicenje:
                    Controller.Instance.SaveTakmicenje((Takmicenje)request.RequestObject);
                    break;
                case Operation.SaveUcesnik:
                    Controller.Instance.SaveUcesnik((Ucesnik)request.RequestObject);
                    break;
                case Operation.GetMesto:
                    response.Result=Controller.Instance.GetMesto();                    
                    break;
                case Operation.GetSelo:
                    response.Result = Controller.Instance.GetSelo();
                    break;
                case Operation.GetTim:
                    response.Result = Controller.Instance.GetTim();
                    break;
                case Operation.SaveTim:
                    Controller.Instance.SaveTim((Tim)request.RequestObject);
                    break;
                case Operation.GetUcesnik:
                    response.Result = Controller.Instance.GetUcesnik();
                    break;
                case Operation.DeleteUcesnik:
                    Controller.Instance.DeleteUcesnik((Ucesnik)request.RequestObject);
                    break;
                case Operation.DeleteTim:
                    Controller.Instance.DeleteTim((Tim)request.RequestObject);
                    break;
                case Operation.UpdateUcesnik:
                    Controller.Instance.UpdateUcesnik((Ucesnik)request.RequestObject);
                    break;
                case Operation.UpdateTim:
                    Controller.Instance.UpdateTim((Tim)request.RequestObject);
                    break;
                case Operation.GetUcesnikWithCondition:
                    response.Result = Controller.Instance.GetUcesnikWithCondition((Ucesnik)request.RequestObject);
                    break;
                case Operation.GetTimkWithCondition:
                    response.Result = Controller.Instance.GetTimWithCondition((Tim)request.RequestObject);
                    break;
                case Operation.GetTakmicenjeWithCondition:
                    response.Result = Controller.Instance.GetTakmicenjeWithCondition((Takmicenje)request.RequestObject);
                    break;
                case Operation.GetOneTakmicenjekWithCondition:
                    response.Result = Controller.Instance.GetOneTakmicenjeWithCondition((Takmicenje)request.RequestObject);
                    break;
                case Operation.GetOneTimWithCondition:
                    response.Result = Controller.Instance.GetOneTimWithCondition((Tim)request.RequestObject);
                    break;
                case Operation.GetOneUcesnikWithCondition:
                    response.Result = Controller.Instance.GetOneUcesnikWithCondition((Ucesnik)request.RequestObject);
                    break;
            }
            return response;
        }

        internal void Stop()
        {
            client.Close();

        }
    }
}