using Common.Communication;
using Common.Domain;
using FrmLogin.UserControls;
using FrmLogin.UserControls.UCProdavac;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.GUIControllers
{
    internal class KorisnikGUIController
    {
        private UCProdavci ucProdavac;
        private UCIzmeniProdavca ucIzmeniProdavca;
        private UCPromeniSifru ucPromenaSifre;

        private Korisnik korisnikZaIzmenu;
        internal Control CreateUCProdavac(UCMode mode, Korisnik korisnik = null)
        {
            ucProdavac = new UCProdavci();

            PrepareFormProdavac(mode, korisnik);

            if (mode == UCMode.Create)
            {
                ucProdavac.btnDodajProdavca.Click += DodajProdavca;
                ucProdavac.btnOdustani.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
            }
            else if (mode == UCMode.Update)
            {
                korisnikZaIzmenu = korisnik;
                ucProdavac.btnOdustani.Text = "Nazad";
                ucProdavac.btnDodajProdavca.Click += SacuvajIzmene;
                ucProdavac.btnOdustani.Click += (s, e) => MainCoordinator.Instance.ShowPretragaProdavca();
            }
            else if (mode == UCMode.Delete)
            {

            }

            return ucProdavac;
        }

        private void SacuvajIzmene(object sender, EventArgs e)
        {
            if (!ValidationDodajProdavca()) return;

            Korisnik korisnik = new Korisnik()
            {
                SifraKorisnika = korisnikZaIzmenu.SifraKorisnika,
                Ime = ucProdavac.txtIme.Text.Trim(),
                Prezime = ucProdavac.txtPrezime.Text.Trim(),
                Pol = (Pol)ucProdavac.cbPol.SelectedItem,
                Uloga = Uloga.Prodavac,
                Username = ucProdavac.txtUsername.Text.Trim(),
                Password = ucProdavac.txtPassword.Text.Trim(),
                Jmbg = ucProdavac.txtJmbg.Text.Trim()
            };
            Response res = Communication.Instance.UpdateKorisnika(korisnik);
            MessageBox.Show(res.Message);
        }

        private void DodajProdavca(object sender, EventArgs e)
        {
            if (!ValidationDodajProdavca()) return;

            //Dodaj hash za sifru
            Korisnik korisnik = new Korisnik()
            {
                Ime = ucProdavac.txtIme.Text.Trim(),
                Prezime = ucProdavac.txtPrezime.Text.Trim(),
                Pol = (Pol)ucProdavac.cbPol.SelectedItem,
                Uloga = Uloga.Prodavac,
                Username = ucProdavac.txtUsername.Text.Trim(),
                Password = ucProdavac.txtPassword.Text.Trim(),
                Jmbg = ucProdavac.txtJmbg.Text.Trim()
            };

            Response response = Communication.Instance.DodajProdavca(korisnik);
            MessageBox.Show(response.Message);

            ResetForm();
        }

        private void ResetForm()
        {
            ucProdavac.txtIme.BackColor = Color.White;
            ucProdavac.txtIme.Clear();
            ucProdavac.txtPrezime.BackColor = Color.White;
            ucProdavac.txtPrezime.Clear();
            ucProdavac.cbPol.BackColor = Color.White;
            ucProdavac.cbPol.SelectedIndex = -1;
            ucProdavac.txtUsername.BackColor = Color.White;
            ucProdavac.txtUsername.Clear();
            ucProdavac.txtPassword.BackColor = Color.White;
            ucProdavac.txtPassword.Clear();
            ucProdavac.txtJmbg.BackColor = Color.White;
            ucProdavac.txtJmbg.Clear();
        }

        private bool ValidationDodajProdavca()
        {
            List<string> errors = new List<string>();
            List<Control> controls = new List<Control>();

            if (string.IsNullOrEmpty(ucProdavac.txtIme.Text) || ucProdavac.txtIme.Text.Length < 2 || !ucProdavac.txtIme.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errors.Add("Ime mora imati bar 2 karaktera i to isključivo slova!");
                controls.Add(ucProdavac.txtIme);
            }

            if (string.IsNullOrEmpty(ucProdavac.txtPrezime.Text) || ucProdavac.txtPrezime.Text.Length < 2 || !ucProdavac.txtPrezime.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errors.Add("Prezime mora imati bar 2 karaktera i to isključivo slova!");
                controls.Add(ucProdavac.txtPrezime);
            }

            if (ucProdavac.cbPol.SelectedIndex < 0)
            {
                errors.Add("Pol mora biti izabran!");
                controls.Add(ucProdavac.cbPol);
            }

            if (string.IsNullOrEmpty(ucProdavac.txtUsername.Text) || ucProdavac.txtUsername.Text.Length < 2 || !ucProdavac.txtUsername.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || char.IsDigit(c) || c == '_'))
            {
                errors.Add("Username mora imati bar 2 karaktera i to isključivo slova i brojeve");
                controls.Add(ucProdavac.txtUsername);
            }

            //Mozda dodati neki regex uslov i/ili hash
            if (string.IsNullOrEmpty(ucProdavac.txtPassword.Text) || ucProdavac.txtPassword.Text.Length < 8)
            {
                errors.Add("Uneta šifra mora imati bar 8 karaktera!");
                controls.Add(ucProdavac.txtPassword);
            }

            if (string.IsNullOrEmpty(ucProdavac.txtJmbg.Text) || ucProdavac.txtJmbg.Text.Length != 13 || !ucProdavac.txtJmbg.Text.All(c => char.IsDigit(c)))
            {
                errors.Add("JMBG nije ispravno unet!");
                controls.Add(ucProdavac.txtJmbg);
            }

            if (errors.Count > 0)
            {
                ShowErrors(errors, controls);
                return false;
            }

            return true;
        }

        private void ShowErrors(List<string> errors, List<Control> controls)
        {
            ucProdavac.txtIme.BackColor = Color.White;
            ucProdavac.txtPrezime.BackColor = Color.White;
            ucProdavac.cbPol.BackColor = Color.White;
            ucProdavac.txtUsername.BackColor = Color.White;
            ucProdavac.txtPassword.BackColor = Color.White;
            ucProdavac.txtJmbg.BackColor = Color.White;

            string message = "";
            for (int i = 0; i < errors.Count; i++)
            {
                message += errors[i] + "\n";
                controls[i].BackColor = Color.LightSalmon;
            }

            MessageBox.Show(message, "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PrepareFormProdavac(UCMode mode, Korisnik korisnik)
        {
            ucProdavac.cbPol.DataSource = Enum.GetValues(typeof(Pol));
            if (mode == UCMode.Create)
            {
                //Dodaj naslov na formu

                ucProdavac.cbPol.SelectedIndex = -1;

            }
            else if(mode == UCMode.Update)
            {
                ucProdavac.txtIme.Text = korisnik.Ime;
                ucProdavac.txtPrezime.Text = korisnik.Prezime;
                ucProdavac.txtJmbg.Text = korisnik.Jmbg;
                ucProdavac.txtPassword.Text = korisnik.Password;
                ucProdavac.txtUsername.Text = korisnik.Username;
                ucProdavac.cbPol.SelectedIndex = (int)korisnik.Pol;

                ucProdavac.txtJmbg.Enabled = false;
                ucProdavac.cbPol.Enabled = false;
                
            }
        }

        internal Control CreateUCIzmeniProdavca()
        {
            ucIzmeniProdavca = new UCIzmeniProdavca();
            ucIzmeniProdavca.Load += UcitajProdavce;
            ucIzmeniProdavca.btnPretraga.Click += PretraziPoImenu;
            ucIzmeniProdavca.btnOdustani.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
            ucIzmeniProdavca.btnIzmeni.Click += PrikaziFormuZaIzmenu;
            ucIzmeniProdavca.btnObrisi.Click += ObrisiProdavca;

            return ucIzmeniProdavca;
        }

        private void ObrisiProdavca(object sender, EventArgs e)
        {
            if(ucIzmeniProdavca.dgvKorisnici.SelectedRows.Count != 1)
            {
                MessageBox.Show("Mora biti izabran tacno jedan korisnik", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranog korisnika?", "Brisanje korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Korisnik izabraniKorisnik = (Korisnik)ucIzmeniProdavca.dgvKorisnici.SelectedRows[0].DataBoundItem;
            Response response = Communication.Instance.ObrisiKorisnika(izabraniKorisnik);
            ucIzmeniProdavca.btnPretraga.PerformClick();
            MessageBox.Show(response.Message);
        }

        private void PrikaziFormuZaIzmenu(object sender, EventArgs e)
        {
            Korisnik korisnik = (Korisnik)ucIzmeniProdavca.dgvKorisnici.SelectedRows[0].DataBoundItem;
            korisnik = Communication.Instance.PretraziKorisnikePoId(korisnik.SifraKorisnika);
            MainCoordinator.Instance.ShowProdavacPanel(UCMode.Update, korisnik);
        }

        private void PretraziPoImenu(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ucIzmeniProdavca.txtPretraga.Text))
            {
                List<Korisnik> korisnici = Communication.Instance.PretraziKorisnikePoImenu(ucIzmeniProdavca.txtPretraga.Text);
                if (korisnici == null || korisnici.Count == 0)
                {
                    MessageBox.Show("Ne postoje korisnici sa tim imenom");
                    return;
                }
                else prepareDgv(korisnici);
            }
            else
            {
                UcitajProdavce(sender, e);
            }
        }

        private void UcitajProdavce(object sender, EventArgs e)
        {
            List<Korisnik> korisnici = Communication.Instance.PretraziSveProdavce();
            prepareDgv(korisnici);
        }

        private void prepareDgv(List<Korisnik> korisnici)
        {
            ucIzmeniProdavca.dgvKorisnici.DataSource = korisnici;

            ucIzmeniProdavca.dgvKorisnici.Columns["Pol"].Visible = false;
            ucIzmeniProdavca.dgvKorisnici.Columns["Username"].Visible = false;
            ucIzmeniProdavca.dgvKorisnici.Columns["Password"].Visible = false;
            ucIzmeniProdavca.dgvKorisnici.Columns["Jmbg"].Visible = false;
            ucIzmeniProdavca.dgvKorisnici.Columns["TableName"].Visible = false;
            ucIzmeniProdavca.dgvKorisnici.Columns["DisplayValue"].Visible = false;
            ucIzmeniProdavca.dgvKorisnici.Columns["PrimaryKey"].Visible = false;

            //ucIzmeniProdavca.dgvKorisnici.Rows.Clear();
            //ucIzmeniProdavca.dgvKorisnici.Columns.Add("id", "ID");
            //ucIzmeniProdavca.dgvKorisnici.Columns.Add("ime", "Ime");
            //ucIzmeniProdavca.dgvKorisnici.Columns.Add("prezime", "Prezime");
            //ucIzmeniProdavca.dgvKorisnici.Columns.Add("uloga", "Uloga");

            //if (korisnici != null && korisnici.Count >= 1)
            //{
            //    foreach (Korisnik k in korisnici)
            //    {
            //        ucIzmeniProdavca.dgvKorisnici.Rows.Add(k.SifraKorisnika.ToString(), k.Ime, k.Prezime, k.Uloga.ToString());
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Neuspesna pretraga korisnika");
            //}

        }

        internal Control createUCPromenaSifre()
        {
            ucPromenaSifre = new UCPromeniSifru();
            ucPromenaSifre.btnOdustani.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
            ucPromenaSifre.btnPotvrdi.Click += PromeniSifru;

            return ucPromenaSifre;
        }

        private void PromeniSifru(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ucPromenaSifre.txtNovaSifra.Text) || ucPromenaSifre.txtNovaSifra.Text.Length < 8)
            {
                MessageBox.Show("Uneta šifra mora imati bar 8 karaktera!", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Response response = Communication.Instance.PromeniSifru(ucPromenaSifre.txtStaraSifra.Text, ucPromenaSifre.txtNovaSifra.Text);
            MessageBox.Show(response.Message, (response.IsSuccessful?"asd":"dsa"));
        }
    }
}
