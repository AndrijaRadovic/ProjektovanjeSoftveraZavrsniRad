using Common.Communication;
using Common.Domain;
using FrmLogin.UserControls;
using FrmLogin.UserControls.UCRacun;
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
    internal class RacunGUIController
    {
        private UCRacun ucRacun;

        private BindingList<StavkaRacuna> stavkeRacuna = new BindingList<StavkaRacuna>();
        private int trenutniIndeks = 1;
        private double ukupnaCena;

        internal Control createUCRacun(UCMode mode, Racun racun)
        {
            ucRacun = new UCRacun();

            prepareFormRacun(mode, racun);

            ucRacun.cbProizvod.SelectedIndexChanged += ZameniCenuProizvoda;

            if (mode == UCMode.Create)
            {
                ucRacun.btnNazad.Click += (s, e) => MainCoordinator.Instance.ShowDefault();
                ucRacun.btnDodajStavku.Click += DodajStavkuRacuna;
                ucRacun.btnObrisiStavku.Click += ObrisiStavkuRacuna;
                ucRacun.btnSacuvajRacun.Click += SacuvajRacun;
            }

            if (mode == UCMode.Update)
            {

            }

            return ucRacun;
        }

        private void ZameniCenuProizvoda(object sender, EventArgs e)
        {
            if (ucRacun.cbProizvod.SelectedIndex == -1)
                return;

            ucRacun.txtCenaStavke.Text = ((Proizvod)ucRacun.cbProizvod.SelectedItem).Cena.ToString();
        }

        private void SacuvajRacun(object sender, EventArgs e)
        {
            if(stavkeRacuna.Count == 0)
            {
                MessageBox.Show("Nije moguce kreirati prazan racun");
                return;
            }

            Racun racun = new Racun
            {
                DatumVreme = DateTime.Now,
                UkupnaCenaRacuna = ukupnaCena,
                Korisnik = MainCoordinator.Instance.Korisnik,
                StavkeRacuna = stavkeRacuna.ToList()
            };

            foreach (StavkaRacuna sr in racun.StavkeRacuna)
                sr.Racun = racun;

            Response response = Communication.Instance.DodajRacun(racun);
            MessageBox.Show(response.Message);

            ResetForm();
        }

        private void ResetForm()
        {
            ucRacun.cbProizvod.SelectedIndex = -1;
            ucRacun.txtCenaStavke.Clear();
            ucRacun.txtUkupnaCena.Clear();
            stavkeRacuna.Clear();
            trenutniIndeks = 1;
            ukupnaCena = 0;
        }

        private void ObrisiStavkuRacuna(object sender, EventArgs e)
        {
            if (ucRacun.dgvStavkeRacuna.SelectedRows.Count != 1)
            {
                MessageBox.Show("Morate izabrati neku od stavki iz tabele!");
                return;
            }

            StavkaRacuna stavkaZaBrisanje = (StavkaRacuna)ucRacun.dgvStavkeRacuna.SelectedRows[0].DataBoundItem;

            ukupnaCena -= stavkaZaBrisanje.UkupnaCenaStavke;
            ucRacun.txtUkupnaCena.Text = ukupnaCena.ToString();

            stavkeRacuna.Remove(stavkaZaBrisanje);
            for (int i = 0; i < stavkeRacuna.Count; i++)
                stavkeRacuna[i].RedniBroj = i + 1;

            trenutniIndeks--;
        }

        private void DodajStavkuRacuna(object sender, EventArgs e)
        {
            if (!ValidacijaForme()) return;

            StavkaRacuna stavka = new StavkaRacuna
            {
                Proizvod = (Proizvod)ucRacun.cbProizvod.SelectedItem,
                RedniBroj = trenutniIndeks++,
                Kolicina = (int)ucRacun.numKolicina.Value,
                UkupnaCenaStavke = ((Proizvod)ucRacun.cbProizvod.SelectedItem).Cena * (double)ucRacun.numKolicina.Value
            };
            stavkeRacuna.Add(stavka);
            ukupnaCena += stavka.UkupnaCenaStavke;
            ucRacun.txtUkupnaCena.Text = ukupnaCena.ToString();

            ucRacun.cbProizvod.BackColor = Color.White;
        }

        private bool ValidacijaForme()
        {
            List<string> errors = new List<string>();
            List<Control> controls = new List<Control>();

            if (ucRacun.cbProizvod.SelectedIndex == -1)
            {
                errors.Add("Morate izabrati proizvod");
                controls.Add(ucRacun.cbProizvod);
            }

            if (errors.Count == 0)
                return true;

            ShowErrors(errors, controls);
            return false;
        }

        private void ShowErrors(List<string> errors, List<Control> controls)
        {
            ucRacun.cbProizvod.BackColor = Color.White;

            string message = "";

            for (int i = 0; i < errors.Count; i++)
            {
                message += errors[i] + "\n";
                controls[i].BackColor = Color.LightSalmon;
            }

            MessageBox.Show(message);
        }

        private void prepareFormRacun(UCMode mode, Racun racun)
        {
            ucRacun.cbProizvod.DataSource = Communication.Instance.VratiSveProizvode();

            if (mode == UCMode.Create)
            {
                ucRacun.cbProizvod.SelectedIndex = -1;
                ucRacun.txtUkupnaCena.Text = "0.00";
            }

            if (mode == UCMode.Update)
            {
                stavkeRacuna = new BindingList<StavkaRacuna>(racun.StavkeRacuna);
            }

            prepareDgv();
        }

        private void prepareDgv()
        {
            ucRacun.dgvStavkeRacuna.DataSource = stavkeRacuna;

            ucRacun.dgvStavkeRacuna.Columns["Racun"].Visible = false;
            ucRacun.dgvStavkeRacuna.Columns["TableName"].Visible = false;
            ucRacun.dgvStavkeRacuna.Columns["DisplayValue"].Visible = false;
            ucRacun.dgvStavkeRacuna.Columns["PrimaryKey"].Visible = false;
            ucRacun.dgvStavkeRacuna.Columns["IdColumn"].Visible = false;

            ucRacun.dgvStavkeRacuna.Columns["RedniBroj"].HeaderText = "Redni broj";
            ucRacun.dgvStavkeRacuna.Columns["UkupnaCenaStavke"].HeaderText = "Ukupna cena stavke";

            ucRacun.dgvStavkeRacuna.Columns["UkupnaCenaStavke"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

        }
    }
}
