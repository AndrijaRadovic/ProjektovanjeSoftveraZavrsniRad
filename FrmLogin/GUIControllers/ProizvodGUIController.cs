using Common.Communication;
using Common.Domain;
using FrmLogin.Forms;
using FrmLogin.UserControls;
using FrmLogin.UserControls.UCProdavac;
using FrmLogin.UserControls.UCProizvod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.GUIControllers
{
    internal class ProizvodGUIController
    {
        private UCProizvod ucProizvod;
        private UCAlat ucAlat;
        private UCFarba ucFarba;
        private UCPlocice ucPlocice;
        private TipProizvoda? izabraniTip = null;
        private UCPrikazProizvoda ucPrikazProizvoda;

        private BindingList<Proizvod> listaProizvoda;

        internal Control CreateUCProizvod(UCMode mode, Proizvod proizvod = null)
        {
            ucProizvod = new UCProizvod();
            PrepareFormProizvod(mode);

            if (mode == UCMode.Create)
            {
                ucProizvod.btnNazad.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
                ucProizvod.btnSacuvaj.Click += SacuvajProizvod;
                ucProizvod.cbTip.SelectedIndexChanged += ZameniUCProizvoda;
            }
            else if (mode == UCMode.Update) { }

            return ucProizvod;
        }

        private void ZameniUCProizvoda(object sender, EventArgs e)
        {

            MainCoordinator.Instance.ShowOdgovarajuciProizvodPanel((TipProizvoda)Enum.Parse(typeof(TipProizvoda), ucProizvod.cbTip.SelectedItem.ToString()));
        }

        private void SacuvajProizvod(object sender, EventArgs e)
        {
            if (!ValidationProizvod()) return;

            if (izabraniTip == TipProizvoda.Plocice)
            {
                Plocice plocice = new Plocice
                {
                    Cena = double.Parse(ucProizvod.txtCena.Text),
                    NazivProizvoda = ucProizvod.txtNaziv.Text,
                    Materijal = ucPlocice.txtMaterijalPlocice.Text,
                    Duzina = double.Parse(ucPlocice.txtDuzinaPlocice.Text),
                    Sirina = double.Parse(ucPlocice.txtSirinaPlocice.Text)
                };

                Response response = Communication.Instance.DodajProizvod(plocice);
                MessageBox.Show(response.Message);

                ucPlocice.txtMaterijalPlocice.BackColor = Color.White;
                ucPlocice.txtMaterijalPlocice.Clear();
                ucPlocice.txtDuzinaPlocice.BackColor = Color.White;
                ucPlocice.txtDuzinaPlocice.Clear();
                ucPlocice.txtSirinaPlocice.BackColor = Color.White;
                ucPlocice.txtSirinaPlocice.Clear();
            }
            else if (izabraniTip == TipProizvoda.Farba)
            {
                Farba farba = new Farba
                {
                    NazivProizvoda = ucProizvod.txtNaziv.Text,
                    Cena = double.Parse(ucProizvod.txtCena.Text),
                    Boja = ucFarba.txtBojaFarbe.Text,
                    VelicinaPakovanja = double.Parse(ucFarba.txtVelicinaPakovanja.Text)
                };
                Response response = Communication.Instance.DodajProizvod(farba);
                MessageBox.Show(response.Message);

                ucFarba.txtBojaFarbe.Clear();
                ucFarba.txtBojaFarbe.BackColor = Color.White;
                ucFarba.txtVelicinaPakovanja.Clear();
                ucFarba.txtVelicinaPakovanja.BackColor = Color.White;
            }
            else if (izabraniTip == TipProizvoda.Alat)
            {
                Alat alat = new Alat
                {
                    NazivProizvoda = ucProizvod.txtNaziv.Text,
                    Cena = double.Parse(ucProizvod.txtCena.Text),
                    TipAlata = (TipAlata)ucAlat.cbTipAlata.SelectedItem
                };
                Response response = Communication.Instance.DodajProizvod(alat);
                MessageBox.Show(response.Message);

                ucAlat.cbTipAlata.BackColor = Color.White;
                ucAlat.cbTipAlata.SelectedIndex = -1;
            }

            ResetForm();
        }

        private void ResetForm()
        {
            ucProizvod.txtNaziv.Clear();
            ucProizvod.txtNaziv.BackColor = Color.White;
            ucProizvod.txtNaziv.Focus();
            ucProizvod.txtCena.Clear();
            ucProizvod.txtCena.BackColor = Color.White;
        }

        private bool ValidationProizvod()
        {
            List<string> errors = new List<string>();
            List<Control> controls = new List<Control>();

            ucProizvod.txtNaziv.BackColor = Color.White;
            ucProizvod.cbTip.BackColor = Color.White;

            if (string.IsNullOrEmpty(ucProizvod.txtNaziv.Text))
            {
                errors.Add("Morate uneti naziv proizvoda");
                controls.Add(ucProizvod.txtNaziv);
            }

            if (ucProizvod.cbTip.SelectedIndex < 0)
            {
                errors.Add("Morate izabrati tip proizvoda");
                controls.Add(ucProizvod.cbTip);
            }

            if (!double.TryParse(ucProizvod.txtCena.Text, out double a) || a <= 0)
            {
                errors.Add("Cena mora biti broj veći od 0");
                controls.Add(ucProizvod.txtCena);
            }

            if (izabraniTip == TipProizvoda.Plocice)
            {
                ucPlocice.txtDuzinaPlocice.BackColor = Color.White;
                ucPlocice.txtSirinaPlocice.BackColor = Color.White;
                ucPlocice.txtMaterijalPlocice.BackColor = Color.White;

                if (!(double.TryParse(ucPlocice.txtDuzinaPlocice.Text, out a)))
                {
                    errors.Add("Duzina plocice mora biti broj");
                    controls.Add(ucPlocice.txtDuzinaPlocice);
                }
                if (!(double.TryParse(ucPlocice.txtSirinaPlocice.Text, out a)))
                {
                    errors.Add("Sirina plocice mora biti broj");
                    controls.Add(ucPlocice.txtSirinaPlocice);
                }
                if (string.IsNullOrEmpty(ucPlocice.txtMaterijalPlocice.Text))
                {
                    errors.Add("Morate uneti materijal plocice");
                    controls.Add(ucPlocice.txtMaterijalPlocice);
                }

            }

            if (izabraniTip == TipProizvoda.Farba)
            {
                ucFarba.txtBojaFarbe.BackColor = Color.White;
                ucFarba.txtVelicinaPakovanja.BackColor = Color.White;

                if (string.IsNullOrEmpty(ucFarba.txtBojaFarbe.Text))
                {
                    errors.Add("Morate uneti boju farbe");
                    controls.Add(ucFarba.txtBojaFarbe);
                }
                if (!double.TryParse(ucFarba.txtVelicinaPakovanja.Text, out a))
                {
                    errors.Add("Velicina pakovanja mora biti broj");
                    controls.Add(ucFarba.txtVelicinaPakovanja);
                }
            }

            if (izabraniTip == TipProizvoda.Alat)
            {
                ucAlat.cbTipAlata.BackColor = Color.White;

                if (ucAlat.cbTipAlata.SelectedIndex < 0)
                {
                    errors.Add("Morate izabrati tip alata");
                    controls.Add(ucAlat.cbTipAlata);
                }
            }

            if (errors.Count > 0)
            {
                ShowErors(errors, controls);
                return false;
            }

            return true;
        }

        private void ShowErors(List<string> errors, List<Control> controls)
        {

            string message = "";
            for (int i = 0; i < errors.Count; i++)
            {
                message += errors[i] + "\n";
                controls[i].BackColor = Color.LightSalmon;
            }

            MessageBox.Show(message, "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void PrepareFormProizvod(UCMode mode, Proizvod proizvod = null)
        {
            ucProizvod.cbTip.DataSource = Enum.GetValues(typeof(TipProizvoda));

            if (mode == UCMode.Create)
            {
                ucProizvod.cbTip.SelectedIndex = -1;
            }
            else if (mode == UCMode.Update)
            {
                ucProizvod.txtNaziv.Text = proizvod.NazivProizvoda;
            }
        }


        //Mozda dodaj mod poziva kao parametar zbog update-a kasnije
        internal Control createUCTipProizvoda(TipProizvoda tipProizvoda)
        {
            switch (tipProizvoda)
            {
                case TipProizvoda.Plocice:
                    ucPlocice = new UCPlocice();
                    izabraniTip = TipProizvoda.Plocice;
                    return ucPlocice;

                case TipProizvoda.Farba:
                    ucFarba = new UCFarba();
                    izabraniTip = TipProizvoda.Farba;
                    return ucFarba;

                case TipProizvoda.Alat:
                    ucAlat = new UCAlat();
                    izabraniTip = TipProizvoda.Alat;
                    ucAlat.cbTipAlata.DataSource = Enum.GetValues(typeof(TipAlata));
                    ucAlat.cbTipAlata.SelectedIndex = -1;
                    return ucAlat;
            }

            return null;
        }

        internal Control createUCPrikazProizvoda(Uloga uloga)
        {
            ucPrikazProizvoda = new UCPrikazProizvoda();

            if (uloga == Uloga.Prodavac)
            {
                ucPrikazProizvoda.btnIzmeni.Visible = false;
                ucPrikazProizvoda.btnObrisi.Visible = false;
            }

            ucPrikazProizvoda.Load += UcitajProizvode;
            ucPrikazProizvoda.Load += prepareCbTip;
            ucPrikazProizvoda.btnNazad.Click
                += (s, e) => MainCoordinator.Instance.ShowDefault();
            ucPrikazProizvoda.btnIzmeni.Click += PrikaziFormuZaIzmenu;
            ucPrikazProizvoda.btnObrisi.Click += ObrisiProizvod;
            ucPrikazProizvoda.btnPretraga.Click += PretraziPoNazivu;
            ucPrikazProizvoda.cbTip.SelectedIndexChanged += FiltrirajProizvode;

            return ucPrikazProizvoda;
        }

        private void prepareCbTip(object sender, EventArgs e)
        {
            List<TipProizvoda> cbLista = new List<TipProizvoda>();
            cbLista.AddRange(Enum.GetValues(typeof(TipProizvoda)).Cast<TipProizvoda>().ToList());
            cbLista.Insert(0, (TipProizvoda)(-1));

            ucPrikazProizvoda.cbTip.DataSource = cbLista;
            ucPrikazProizvoda.cbTip.Format += CbTipFormat;

            //ucPrikazProizvoda.cbTip.DataSource = Enum.GetValues(typeof(TipProizvoda));
            ucPrikazProizvoda.cbTip.SelectedIndex = 0;
        }

        private void FiltrirajProizvode(object sender, EventArgs e)
        {
            if (ucPrikazProizvoda.cbTip.SelectedIndex == 0)
            {
                ucPrikazProizvoda.dgvProizvodi.DataSource = listaProizvoda;
                return;
            }

            ucPrikazProizvoda.dgvProizvodi.DataSource = listaProizvoda.Where(p => p.TipProizvoda == (TipProizvoda)ucPrikazProizvoda.cbTip.SelectedItem).ToList();
        }

        private void PretraziPoNazivu(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ucPrikazProizvoda.txtPretraga.Text))
            {
                //List<Korisnik> korisnici = Communication.Instance.PretraziKorisnikePoImenu(ucIzmeniProdavca.txtPretraga.Text);
                //if (korisnici == null || korisnici.Count == 0)
                //{
                //    MessageBox.Show("Ne postoje korisnici sa tim imenom");
                //    return;
                //}
                //else prepareDgv(korisnici);
            }
            else
            {
                UcitajProizvode(sender, e);
            }
        }

        private void ObrisiProizvod(object sender, EventArgs e)
        {
            if (ucPrikazProizvoda.dgvProizvodi.SelectedRows.Count != 1)
            {
                MessageBox.Show("Mora biti izabran tacno jedan proizvod", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Da li ste sigurni da zelite da obrisete izabrani proizvod?", "Brisanje proizvoda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Proizvod izabraniProizvod = (Proizvod)ucPrikazProizvoda.dgvProizvodi.SelectedRows[0].DataBoundItem;
            Response response = Communication.Instance.ObrisiProizvod(izabraniProizvod);
            ucPrikazProizvoda.btnPretraga.PerformClick();
            MessageBox.Show(response.Message);
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nije implementirano");
        }

        private void PrikaziFormuZaIzmenu(object sender, EventArgs e)
        {
            MessageBox.Show("Nije implementirano");
        }

        private void UcitajProizvode(object sender, EventArgs e)
        {
            List<Proizvod> proizvodi = Communication.Instance.VratiSveProizvode();
            listaProizvoda = new BindingList<Proizvod>(proizvodi);
            prepareDgv(proizvodi);
        }

        private void CbTipFormat(object sender, ListControlConvertEventArgs e)
        {
            if ((int)e.Value == -1)
            {
                e.Value = "Sve";
            }
        }

        private void prepareDgv(List<Proizvod> proizvodi)
        {
            ucPrikazProizvoda.dgvProizvodi.DataSource = proizvodi;

            ucPrikazProizvoda.dgvProizvodi.Columns["SifraProizvoda"].Visible = false;
            ucPrikazProizvoda.dgvProizvodi.Columns["TableName"].Visible = false;
            ucPrikazProizvoda.dgvProizvodi.Columns["DisplayValue"].Visible = false;
            ucPrikazProizvoda.dgvProizvodi.Columns["PrimaryKey"].Visible = false;
            ucPrikazProizvoda.dgvProizvodi.Columns["IdColumn"].Visible = false;
        }
    }
}
