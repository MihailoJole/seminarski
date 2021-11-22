using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ServerskaStrana
{
    public partial class FrmServer : Form
    {
        private Server s;
        private System.Windows.Forms.Timer t;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
                Thread thread = new Thread(s.Listen);
                thread.IsBackground = true;
                thread.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                txtStanjeServera.Text = "Server je pokrenut";
                txtStanjeServera.BackColor = Color.LightGreen;
                s.Administratori.ListChanged += Users_ListChanged;
            }
            catch (SocketException ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Neuspesno pokretanje servera! "+ ex.Message);
            }
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            txtStanjeServera.Text = "Server nije pokrenut";
            txtStanjeServera.BackColor=Color.LightCoral;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            s.Stop();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            txtStanjeServera.Text = "Server nije pokrenut";
            txtStanjeServera.BackColor = Color.LightCoral;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "Timer " + DateTime.Now.ToString("dd. MM. yyyy. HH:mm:ss");
        }

        private void Users_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvAdmin.Invoke(new Action(() => dgvAdmin.DataSource = s.Administratori.ToList()));
        }

    }
}
