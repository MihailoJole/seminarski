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
    public partial class UCUpdateTim : UserControl
    {
        MainController mainController = new MainController();
        public UCUpdateTim()
        {
            InitializeComponent();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            mainController.GetOneTimWithCondition(dgvTim, txtImeTima, cmbSelo);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            mainController.GetTimWithCondition(txtFilter, dgvTim);
        }

        private void UCUpdateTim_Load(object sender, EventArgs e)
        {
            mainController.LoadComboBox(cmbSelo);
            mainController.LoadTabelaTim(dgvTim);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mainController.UpdateTim(txtImeTima, cmbSelo, dgvTim);
        }

        
    }
}
