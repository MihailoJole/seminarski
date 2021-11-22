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
    public partial class UCGetTakmicenje : UserControl
    {
        MainController mainController = new MainController();
        public UCGetTakmicenje()
        {
            InitializeComponent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.GetTakmicenjeWithCondition(txtFilter, dgvTakmicenje);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.GetOneTakmicenjeWithCondition(dgvTakmicenje, txtNivo, dgvStatistika,txtDatumOdrzavanja);
        }

        private void UCGetTakmicenje_Load(object sender, EventArgs e)
        {
            mainController.LoadTabelaTakmicenje(dgvTakmicenje);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
