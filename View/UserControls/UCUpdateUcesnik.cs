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
using Domain;

namespace View.UserControls
{
    public partial class UCUpdateUcesnik : UserControl
    {
        MainController mainController = new MainController();
        public UCUpdateUcesnik()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.GetUcesnikWithCondition(txtFilter, dgvUcesnici);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.GetOneUcesnikWithCondition(dgvUcesnici, txtJMBG, txtIme, txtPrezime, txtKontakt, txtDatumRodjenja, cmbMesto, cmbTim);
            btnUpdate.Enabled = true;
        }

        private void UCUpdateUcesnik_Load(object sender, EventArgs e)
        {
            mainController.LoadComboBox(cmbTim, cmbMesto);
            mainController.LoadTabelaUcesnik(dgvUcesnici);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mainController.UpdateUcesnik(txtJMBG, txtIme, txtPrezime, txtKontakt, txtDatumRodjenja, cmbMesto, cmbTim,dgvUcesnici);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
