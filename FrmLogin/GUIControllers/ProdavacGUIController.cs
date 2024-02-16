using Common.Communication;
using Common.Domain;
using FrmLogin.UserControls;
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
    internal class ProdavacGUIController
    {
        private UCProdavac ucProdavac;
        internal Control CreateUCProdavac(UCMode mode, Korisnik korisnik = null)
        {
            ucProdavac = new UCProdavac();
            PrepareFormProdavac(mode, korisnik);
            
            if(mode == UCMode.Create)
            {
                ucProdavac.btnDodajProdavca.Click += DodajProdavca;
                ucProdavac.btnOdustani.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
            }
            else if(mode == UCMode.Update)
            {
                //Azuriraj korisnika uc
            }

            return ucProdavac;
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
            ucProdavac.txtPrezime.BackColor = Color.White;
            ucProdavac.cbPol.BackColor = Color.White;
            ucProdavac.txtUsername.BackColor = Color.White;
            ucProdavac.txtPassword.BackColor = Color.White;
            ucProdavac.txtJmbg.BackColor = Color.White;
            ucProdavac.cbPol.SelectedIndex = -1;
        }

        private bool ValidationDodajProdavca()
        {
            List<string> errors = new List<string>();
            List<Control> controls = new List<Control>();

            if(string.IsNullOrEmpty(ucProdavac.txtIme.Text) || ucProdavac.txtIme.Text.Length<2 || !ucProdavac.txtIme.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errors.Add("Ime mora imati bar 2 karaktera i to isključivo slova!");
                controls.Add(ucProdavac.txtIme);
            }

            if (string.IsNullOrEmpty(ucProdavac.txtPrezime.Text) || ucProdavac.txtPrezime.Text.Length < 2 || !ucProdavac.txtPrezime.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errors.Add("Prezime mora imati bar 2 karaktera i to isključivo slova!");
                controls.Add(ucProdavac.txtPrezime);
            }

            if(ucProdavac.cbPol.SelectedIndex < 0)
            {
                errors.Add("Pol mora biti izabran!");
                controls.Add(ucProdavac.cbPol);
            }

            if (string.IsNullOrEmpty(ucProdavac.txtUsername.Text) || ucProdavac.txtUsername.Text.Length < 2 || !ucProdavac.txtUsername.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || char.IsDigit(c)))
            {
                errors.Add("Prezime mora imati bar 2 karaktera i to isključivo slova i brojeve");
                controls.Add(ucProdavac.txtPrezime);
            }

            //Mozda dodati neki regex uslov i/ili hash
            if (string.IsNullOrEmpty(ucProdavac.txtPassword.Text) || ucProdavac.txtPassword.Text.Length < 8)
            {
                errors.Add("Uneta šifra mora imati bar 8 karaktera!");
                controls.Add(ucProdavac.txtPassword);
            }

            if(string.IsNullOrEmpty(ucProdavac.txtJmbg.Text) || ucProdavac.txtJmbg.Text.Length != 13 || !ucProdavac.txtJmbg.Text.All( c => char.IsDigit(c)))
            {
                errors.Add("JMBG nije ispravno unet!");
                controls.Add(ucProdavac.txtJmbg);
            }

            if(errors.Count > 0)
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
            for(int i = 0; i < errors.Count; i++)
            {
                message += errors[i] + "\n";
                controls[i].BackColor = Color.LightSalmon;
            }

            MessageBox.Show(message, "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PrepareFormProdavac(UCMode mode, Korisnik korisnik)
        {
            ucProdavac.cbPol.DataSource = Enum.GetValues(typeof(Pol));
            if(mode == UCMode.Create)
            {
                //Dodaj naslov na formu

                ucProdavac.cbPol.SelectedIndex = -1;

            }
        }
    }
}
