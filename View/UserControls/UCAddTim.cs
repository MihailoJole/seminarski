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
    public partial class UCAddTim : UserControl
    {
        MainController mainController = new MainController();
        public UCAddTim()
        {
            InitializeComponent();
        }

        private void UCAddTim_Load(object sender, EventArgs e)
        {
            mainController.LoadComboBox(cmbSelo); 
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            mainController.SaveTim(txtImeTima, cmbSelo);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbFakultet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtImeTima_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
