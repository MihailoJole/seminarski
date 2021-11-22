using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.CommunicationFolder;
using View.Exceptions;
using View.Helpers;

namespace View.ControllerC
{
    public class LoginController
    {
        internal void Login(TextBox txtKorisnickoIme, TextBox txtSifra, FrmLogin frmLogin)
        {
            if (!UserControlHelpers.
                EmptyFieldValidation(txtKorisnickoIme)
                | !UserControlHelpers.EmptyFieldValidation(txtSifra))
            {
                return;
            }
            try
            {
                Administrator a = Communication.Instance.Login(txtKorisnickoIme.Text, txtSifra.Text);
               
                if (a != null)
                {
                    if (a.StatusUlogavan)
                    {
                        throw new SystemNotFoundException("Administrator je već ulogovan!");
                    }
                    FrmMain frmMain = new FrmMain();
                    MessageBox.Show($"Administrator {a.Ime} {a.Prezime} se uspešno prijavio!");
                    frmMain.FormBorderStyle = FormBorderStyle.FixedDialog;
                    frmLogin.Visible = false;
                    //MainCoordinator.Instance.OpenMainForm();
                    frmMain.ShowDialog();
                    //frmLogin.Visible = true;
                       //frmLogin.Dispose(); 
                }
                else throw new  SystemNotFoundException();
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal bool Connect()
        {
            try
            {
                Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom!");
                return false;
            }
        }
    }
}
