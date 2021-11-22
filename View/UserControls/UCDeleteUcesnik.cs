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
    public partial class UCDeleteUcesnik : UserControl
    {
        MainController mainController = new MainController();
        public UCDeleteUcesnik()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.GetUcesnikWithCondition(txtFilter, dgvUcesnici);

        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.GetOneUcesnikWithCondition(dgvUcesnici, txtJMBG, txtIme, txtPrezime, txtKontakt, txtDatumRodjenja, cmbMesto, cmbTim);
            btnDelete.Enabled = true;
        }

        private void UCDeleteUcesnik_Load(object sender, EventArgs e)
        {
            /* mainController.GetMesto(cmbMesto);
             mainController.GetTim(cmbTim);*/
            mainController.LoadComboBox(cmbTim, cmbMesto);
            mainController.LoadTabelaUcesnik(dgvUcesnici);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mainController.DeleteUcesnik(dgvUcesnici);
        }
    }
}
