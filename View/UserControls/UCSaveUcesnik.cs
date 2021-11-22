using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.ControllerC;

namespace View.UserControls
{
    public partial class UCSaveUcesnik : UserControl
    {
        MainController mainController = new MainController();
        public UCSaveUcesnik()
        {
            InitializeComponent();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mainController.SaveUcesnik(txtJMBG, txtIme, txtPrezime, txtKontakt, txtDatumRodjenja, cmbMesto, cmbTim);
          //  mainController.ClearUCSaveUcesnik(txtJMBG, txtIme, txtPrezime, txtKontakt, txtDatumRodjenja, cmbMesto, cmbTim);
        }

        private void UCSaveUcesnik_Load(object sender, EventArgs e)
        {
            mainController.LoadComboBox(cmbTim,cmbMesto);
           /* mainController.GetMesto(cmbMesto);
            mainController.GetTim(cmbTim);*/
        }
    }
}
