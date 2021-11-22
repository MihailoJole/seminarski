using ControllerC;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.ControllerC;
using View.Exceptions;

namespace View
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController= new LoginController();

        public FrmLogin()
        {
            InitializeComponent();
            txtKorisnickoIme.Text = "test123";
            txtSifra.Text = "123123123";
        }
        public FrmLogin(LoginController loginController)
        {
            this.loginController = loginController;
            InitializeComponent();
          
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (loginController.Connect()) {
                try
                {
                    loginController.Login(txtKorisnickoIme, txtSifra, this);

                }
                catch (SystemNotFoundException ex)
                {

                    MessageBox.Show(ex.Message);
                }               
                // this.Visible = false;
               // FrmMain frmMain = new FrmMain();
               // frmMain.ShowDialog();
            }
            //this.Visible = true;
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
