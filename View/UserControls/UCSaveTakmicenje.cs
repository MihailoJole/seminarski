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
    public partial class UCSaveTakmicenje : UserControl
    {
        MainController mainController = new MainController();
        public UCSaveTakmicenje()
        {
            InitializeComponent();
            mainController.InitDataGridView(dgvStatistika);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mainController.AddStatistika(cmbTim, txtBacanjeKamena, txtObaranjeRuku, txtNavlacenjeStapa, txtVucaKonopca, dgvStatistika);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainController.SaveTakmicenje(txtDatumOdrzavanja, txtNivo);
        }

        private void UCSaveTakmicenje_Load(object sender, EventArgs e)
        {
            mainController.LoadComboBoxTim(cmbTim);
        }


    }
}
