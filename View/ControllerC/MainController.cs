using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.CommunicationFolder;
using View.Exceptions;
using View.Helpers;
using View.UserControls;

namespace View.ControllerC
{
    public class MainController
    {
        private BindingList<Statistika> bindingItems = new BindingList<Statistika>();
        

        public void AddStatistika(ComboBox cmbTim,TextBox txtBacanjeKamena,TextBox txtObaranjeRuku,TextBox txtNavlacenjeStapa,TextBox txtVucaKonopca,DataGridView dgvStatistika) {
            if (timovi.Count == 0) {
                MessageBox.Show("Uneti su svi timovi!");
                return;
            }
            if (!UserControlHelpers.IntValidation(txtBacanjeKamena) | !UserControlHelpers.IntValidation(txtObaranjeRuku) | !UserControlHelpers.IntValidation(txtNavlacenjeStapa) | 
                !UserControlHelpers.IntValidation(txtVucaKonopca)  | !UserControlHelpers.ComboBoxValidation(cmbTim) |
                !UserControlHelpers.BoundaryNumber(txtBacanjeKamena,0,5) | !UserControlHelpers.BoundaryNumber(txtObaranjeRuku, 0, 5) | !UserControlHelpers.BoundaryNumber(txtNavlacenjeStapa, 0, 5)
                | !UserControlHelpers.BoundaryNumber(txtVucaKonopca, 0, 5) | !UserControlHelpers.BoundaryNumber(txtNavlacenjeStapa, 0, 5)) {
                MessageBox.Show("Greška!");
                return;
            }         
            Statistika s = new Statistika() { 
            Takmicenje= new Takmicenje(),
            Tim=(Tim)cmbTim.SelectedItem,
            BacanjeKamena=int.Parse(txtBacanjeKamena.Text),
            ObaranjeRuku= int.Parse(txtObaranjeRuku.Text),
            NadvlacenjeStapa= int.Parse(txtNavlacenjeStapa.Text),
            VucaKonopca=int.Parse(txtVucaKonopca.Text),
            UkupnoBodovi= int.Parse(txtBacanjeKamena.Text)+ int.Parse(txtObaranjeRuku.Text)+ int.Parse(txtNavlacenjeStapa.Text)+ int.Parse(txtVucaKonopca.Text),            
            };
            bindingItems.Add(s);
            timovi.RemoveAt(cmbTim.SelectedIndex);            
            cmbTim.DataSource = null;            
            cmbTim.DataSource = timovi;                        
        }

        internal void LoadTabelaTakmicenje(DataGridView dgvTakmicenje)
        {
            Takmicenje tak = new Takmicenje();
            tak.Uslov = "Nivo like '%' ";
            dgvTakmicenje.DataSource = new BindingList<Takmicenje>(Communication.Instance.GetTakmicenjeWithCondition(tak).ToList());

        }

        internal void LoadTabelaUcesnik(DataGridView dgvUcesnici)
        {
            dgvUcesnici.DataSource = new BindingList<Ucesnik>((List<Ucesnik>)Communication.Instance.GetUcesnik());

        }

        internal void LoadTabelaTim(DataGridView dgvTim)
        {
            dgvTim.DataSource = new BindingList<Tim>((List<Tim>)Communication.Instance.GetTim());
        }

        List<Tim> timovi = new List<Tim>();
        internal void LoadComboBoxTim(ComboBox cmbTim)
        {
            GetTim(cmbTim);
            cmbTim.SelectedIndex = -1;
            cmbTim.Text = "Izaberite tim";
        }

        internal void LoadComboBox(ComboBox cmbSelo)
        {            
            GetSelo(cmbSelo);
            cmbSelo.SelectedIndex = -1;          
            cmbSelo.Text = "Izaberite selo";
        }

        internal void LoadComboBox(ComboBox cmbTim, ComboBox cmbMesto)
        {
            GetMesto(cmbMesto);
            GetTim(cmbTim);
            cmbTim.SelectedIndex = -1;
            cmbMesto.SelectedIndex = -1;
            cmbTim.Text = "Izaberite tim";
            cmbMesto.Text = "Izaberite mesto";
        }

        internal void ClearUCSaveUcesnik(TextBox txtJMBG, TextBox txtIme, TextBox txtPrezime, TextBox txtKontakt, TextBox txtDatumRodjenja, ComboBox cmbMesto, ComboBox cmbTim)
        {
            txtJMBG.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtKontakt.Text = "";
            txtDatumRodjenja.Text = "";
            cmbMesto.Text = "Izaberite mesto";
            cmbTim.Text = "Izaberite tim";
        }

        //dodato
        public void InitDataGridView(DataGridView dgvStatistika)
        {
            dgvStatistika.DataSource = bindingItems;
            dgvStatistika.Columns["Takmicenje"].Visible = false;
           
        }
        public void SaveTakmicenje(TextBox txtDatumO, TextBox txtNivo)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtDatumO) | !UserControlHelpers.DataValidation(txtDatumO) | !UserControlHelpers.EmptyFieldValidation(txtNivo))
            {
                MessageBox.Show("Greska!");
                return;
            }
            try
            {
                Takmicenje tak = new Takmicenje
                {
                    //DatumO = DateTime.ParseExact(txtDatumO.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture),
                    DatumO = DateTime.ParseExact(txtDatumO.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture),
                    Nivo = txtNivo.Text
                };
                bindingItems = new BindingList<Statistika>(bindingItems.OrderBy(l => l.UkupnoBodovi).ToList());
                int pom = bindingItems.Count;
                for (int i = 0; i < bindingItems.Count; i++)
                {
                    bindingItems[i].OsvojenoMesto = pom--;
                }
                tak.Statistika = bindingItems.ToList();
                Communication.Instance.SaveTakmicenje(tak);
                MessageBox.Show("Uspešno ste sačuvali takmičenje!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void OpenUCGetTakmicenje(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCGetTakmicenje());
        }

        internal void OpenUCSaveTakmicenje(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCSaveTakmicenje());
        }

        internal void OpenUCDeleteTim(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCDeleteTim());

        }

        internal void OpenUCUpdateTim(FrmMain frmMain)
        {
            
            frmMain.SetPanel(new UCUpdateTim());

        }

        internal void OpenUCAddTim(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAddTim());
        }

        internal void OpenUCDeleteUcesnik(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCDeleteUcesnik());

        }

        internal void OpenUCUpdateUcesnik(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUpdateUcesnik());
        }

        internal void OpenUCSaveUcesnik(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCSaveUcesnik());

        }

        internal void GetMesto(ComboBox cmbMesto)
        {
            cmbMesto.DataSource= Communication.Instance.GetMesto();
            
        }
        internal void GetTim(ComboBox cmbTim)
        {
            cmbTim.DataSource = Communication.Instance.GetTim();
             timovi = (List<Tim>)Communication.Instance.GetTim();

        }

        internal void DeleteUcesnik(DataGridView dgvUcesnik)
        {   if (dgvUcesnik.SelectedRows.Count == 0) {
                MessageBox.Show("Morate odabrati učesnika!");
                return;
            }

            try
            {
                Communication.Instance.DeleteUcesnik((Ucesnik)dgvUcesnik.SelectedRows[0].DataBoundItem);
                MessageBox.Show("Uspešno ste obrisali učesnika!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        internal void DeleteTim(DataGridView dgvTim)
        {
            if (dgvTim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate odabrati tim!");
                return;
            }
            try
            {
                Communication.Instance.DeleteTim((Tim)dgvTim.SelectedRows[0].DataBoundItem);
                dgvTim.Refresh();
                MessageBox.Show("Uspešno ste obrisali tim!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("Ne možete da izbrišete ovaj tim!");
            }
        }

        public void UpdateUcesnik(TextBox txtJMBG, TextBox txtIme, TextBox txtPrezime, TextBox txtKontakt, TextBox txtDatumRodjenja, ComboBox cmbMesto, ComboBox cmbTim,DataGridView dgvUcesnik)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtDatumRodjenja) | !UserControlHelpers.DataValidation(txtDatumRodjenja) |
                 !UserControlHelpers.EmptyFieldValidation(txtIme) | !UserControlHelpers.EmptyFieldValidation(txtPrezime) | !UserControlHelpers.EmptyFieldValidation(txtKontakt) |
                 !UserControlHelpers.EmptyFieldValidation(txtJMBG) | !UserControlHelpers.ComboBoxValidation(cmbMesto) | !UserControlHelpers.ComboBoxValidation(cmbTim)
                 | !UserControlHelpers.AllNumberValidation(txtKontakt) | !UserControlHelpers.AllNumberValidation(txtJMBG))
            {
                MessageBox.Show("Greska!");
                return;
            }
            if (dgvUcesnik.SelectedRows.Count == 0) {
                MessageBox.Show("Morate odabrati učesnika!");
                return;
            }
            try
            {
                Ucesnik u = new Ucesnik
                {   ID=((Ucesnik)dgvUcesnik.SelectedRows[0].DataBoundItem).ID,
                    DatumRodjenja = DateTime.ParseExact(txtDatumRodjenja.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture),
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    JMBG = txtJMBG.Text,
                    Kontakt = txtKontakt.Text,
                    Mesto = (Mesto)cmbMesto.SelectedItem,
                    Tim = (Tim)cmbTim.SelectedItem

                };
                Communication.Instance.UpdateUcesnik(u);
                MessageBox.Show("Uspešno ste ažurirali podatke o učesniku!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateTim(TextBox txtImeTima, ComboBox cmbSelo, DataGridView dgvTim)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtImeTima) | !UserControlHelpers.ComboBoxValidation(cmbSelo))
            {
                MessageBox.Show("Greska!");
                return;
            }
            if (dgvTim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate odabrati učesnika!");
                return;
            }
            try
            {
                Tim t = new Tim
                {
                    ID=((Tim)dgvTim.SelectedRows[0].DataBoundItem).ID,
                    ImeTima=txtImeTima.Text,
                    Selo=(Selo)cmbSelo.SelectedItem
                };
                Communication.Instance.UpdateTim(t);
                MessageBox.Show("Uspešno ste ažurirali podatke o timu!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void GetUcesnikWithCondition(TextBox txtFilter, DataGridView dgvUcesnici)
        {
            Ucesnik u = new Ucesnik();
            u.Uslov= $" u.Ime like '{txtFilter.Text}%' or u.Prezime like '{ txtFilter.Text}%'";
            List<Ucesnik> lista = Communication.Instance.GetUcesnikWithCondition(u);

            if (lista.Count == 0)
            {
                MessageBox.Show("Traženi učesnici nisu pronađeni.");
                dgvUcesnici.DataSource = lista;
            }
            else
            {
                dgvUcesnici.DataSource = lista;
                MessageBox.Show("Učesnik ne može da se učita!");

            }
        }

        internal void GetOneUcesnikWithCondition(DataGridView dgvUcesnici, TextBox txtJMBG, TextBox txtIme, TextBox txtPrezime, TextBox txtKontakt, TextBox txtDatumRodjenja, ComboBox cmbMesto, ComboBox cmbTim)
        {
            if (dgvUcesnici.SelectedRows.Count == 0) {
                MessageBox.Show("Niste izabrali ni jednog učesnika!");
                return;
            }
            Ucesnik u = new Ucesnik();
            u.Uslov = $"JMBG='{((Ucesnik)dgvUcesnici.SelectedRows[0].DataBoundItem).JMBG}'";
            u = Communication.Instance.GetOneUcesnikWithCondition(u);

            if (u == null)
            {
                MessageBox.Show("Traženi učesnik nije pronađen!");
            }
            else
            {                
                MessageBox.Show("Traženi učesnik je pronađen!");
                txtJMBG.Text = u.JMBG;
                txtIme.Text = u.Ime;
                txtPrezime.Text = u.Prezime;
                txtKontakt.Text = u.Kontakt;
                txtDatumRodjenja.Text = u.DatumRodjenja.ToString("dd.MM.yyyy.");
                cmbMesto.SelectedIndex =cmbMesto.FindStringExact(u.Mesto.NazivMesta);
                cmbTim.SelectedIndex = cmbTim.FindStringExact(u.Tim.ImeTima);

            }
        }

        internal void GetOneTimWithCondition(DataGridView dgvTim, TextBox txtNazivTima,ComboBox cmbSelo)
        {
            if (dgvTim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali ni jedan tim!");
                return;
            }


            Tim t = new Tim();
            t.Uslov = $"ImeTima='{((Tim)dgvTim.SelectedRows[0].DataBoundItem).ImeTima}'";
            t= Communication.Instance.GetOneTimWithCondition(t);

            if (t == null)
            {
                MessageBox.Show("Traženi tim nije pronađen!");
            }
            else
            {
                MessageBox.Show("Traženi tim je pronađen!");
                txtNazivTima.Text = t.ImeTima;
                cmbSelo.SelectedIndex = cmbSelo.FindStringExact(t.Selo.NazivSela);

            }
        }
        internal void GetOneTakmicenjeWithCondition(DataGridView dgvTakmicenje, TextBox txtNivo, DataGridView dgvStatistika,TextBox txtDatumO)
        {
            if (dgvTakmicenje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste izabrali nijedno takmicenje!");
                return;
            }
            Takmicenje tak = new Takmicenje();
            tak.Uslov = $"id={((Takmicenje)dgvTakmicenje.SelectedRows[0].DataBoundItem).ID}";
            tak = Communication.Instance.GetOneTakmicenjeWithCondition(tak);

            if (tak == null)
            {
                MessageBox.Show("Traženo takmičenje nije pronađeno!");
            }
            else
            {
                MessageBox.Show("Traženo takmičenje je pronađeno!");
                txtNivo.Text = tak.Nivo;
                txtDatumO.Text = tak.DatumO.ToString("dd.MM.yyyy.");
                dgvStatistika.DataSource = tak.Statistika;
            }
        }

        internal void GetTimWithCondition(TextBox txtFilter, DataGridView dgvTim)
        {
            Tim t = new Tim();
            t.Uslov = $" t.ImeTima like '{txtFilter.Text}%' or se.NazivSela like '{txtFilter.Text}%'";
            List<Tim> lista = Communication.Instance.GetTimWithCondition(t);

            if (lista.Count == 0)
            {
                MessageBox.Show("Traženi timovi nisu pronađeni.");
                dgvTim.DataSource = lista;
            }
            else
            {
                dgvTim.DataSource = lista;
                MessageBox.Show("Traženi timovi su pronađeni!");

            }
        }

        internal void GetTakmicenjeWithCondition(TextBox txtFilter, DataGridView dgvTakmicenje)
        {
            Takmicenje tak = new Takmicenje();                        
            int.TryParse(txtFilter.Text, out int prom);
            tak.Uslov = $"Nivo like '{txtFilter.Text}%' or YEAR(DatumO)='{prom}' ";
            List<Takmicenje> lista = Communication.Instance.GetTakmicenjeWithCondition(tak);

            if (lista.Count == 0)
            {
                MessageBox.Show("Tražena takmičenja nisu pronađena!");
                dgvTakmicenje.DataSource = lista;

            }
            else
            {
                dgvTakmicenje.DataSource = lista;
                MessageBox.Show("Tražena takmičenja su pronađena!");

            }
        }

        internal void GetUcesnik(ComboBox cmbUcesnik)
        {
            cmbUcesnik.DataSource = Communication.Instance.GetUcesnik();
        }
        public void SaveTim(TextBox txtImeTima, ComboBox cmbSelo)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtImeTima) | !UserControlHelpers.ComboBoxValidation(cmbSelo))
            {
                MessageBox.Show("Greska!");
                return;
            }
            try
            {
                Tim t = new Tim
                {
                    ImeTima = txtImeTima.Text,
                    Selo = (Selo)cmbSelo.SelectedItem,

                };
                Communication.Instance.SaveTim(t);
                MessageBox.Show("Uspešno ste sačuvali tim!");
                txtImeTima.Text = "";
                cmbSelo.Text = "Izaberite selo";
                cmbSelo.SelectedIndex = -1;
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void GetSelo(ComboBox cmbSelo)
        {
            cmbSelo.DataSource = Communication.Instance.GetSelo();
        }

        public void SaveUcesnik(TextBox txtJMBG, TextBox txtIme,TextBox txtPrezime, TextBox txtKontakt, TextBox txtDatumRodjenja,ComboBox cmbMesto,ComboBox cmbTim)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtDatumRodjenja) | !UserControlHelpers.DataValidation(txtDatumRodjenja) |
                !UserControlHelpers.EmptyFieldValidation(txtIme) | !UserControlHelpers.EmptyFieldValidation(txtPrezime) | !UserControlHelpers.EmptyFieldValidation(txtKontakt)|
                !UserControlHelpers.EmptyFieldValidation(txtJMBG) | !UserControlHelpers.ComboBoxValidation(cmbMesto) | !UserControlHelpers.ComboBoxValidation(cmbTim)
                | !UserControlHelpers.AllNumberValidation(txtKontakt) | !UserControlHelpers.AllNumberValidation(txtJMBG))
            {
                MessageBox.Show("Ne možete da sačuvate učesnika!");
                return;
            }
           

            try
            {
                Ucesnik u = new Ucesnik
                {
                    DatumRodjenja = DateTime.ParseExact(txtDatumRodjenja.Text, "dd.MM.yyyy.", CultureInfo.InvariantCulture),
                    Ime = txtIme.Text,
                    Prezime=txtPrezime.Text,
                    JMBG=txtJMBG.Text,
                    Kontakt=txtKontakt.Text,
                    Mesto=(Mesto)cmbMesto.SelectedItem,
                    Tim= (Tim)cmbTim.SelectedItem                
            };
                Communication.Instance.SaveUcesnik(u);
                MessageBox.Show("Uspešno ste sačuvali učesnika!");
                txtJMBG.Text = "";
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtKontakt.Text = "";
                txtDatumRodjenja.Text = "";
                cmbMesto.Text = "Izaberite mesto";
                cmbTim.Text = "Izaberite tim";
                cmbMesto.SelectedIndex = -1;
                cmbTim.SelectedIndex = -1;
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
