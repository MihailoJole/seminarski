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

namespace View
{
    public partial class FrmMain : Form
    {
        MainController mainController = new MainController();
        public FrmMain()
        {
            InitializeComponent();
            
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dodajUčesnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCSaveUcesnik(this);
        }
        public void SetPanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Parent = pnlMain;
            userControl.Dock = DockStyle.Fill;
        }

        private void promeniUčesnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUpdateUcesnik(this);
        }

        private void obrišiUčesnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCDeleteUcesnik(this);
        }

        private void dodajTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAddTim(this);

        }

        private void promeniTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCUpdateTim(this);
        }

        private void obrišiTimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCDeleteTim(this);
        }

        private void prikažiTakmicenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCGetTakmicenje(this);

        }

        private void dodajTakmicenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCSaveTakmicenje(this);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
