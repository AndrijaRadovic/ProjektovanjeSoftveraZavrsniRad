namespace FrmLogin.UserControls.UCRacun
{
    partial class UCRacun
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNaslov = new System.Windows.Forms.Label();
            this.cbProizvod = new System.Windows.Forms.ComboBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.pnlStavke = new System.Windows.Forms.Panel();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.txtCenaStavke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnSacuvajRacun = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.pnlStavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(10, 16);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(256, 38);
            this.lblNaslov.TabIndex = 24;
            this.lblNaslov.Text = "Kreiranje računa";
            // 
            // cbProizvod
            // 
            this.cbProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProizvod.FormattingEnabled = true;
            this.cbProizvod.Location = new System.Drawing.Point(83, 5);
            this.cbProizvod.Name = "cbProizvod";
            this.cbProizvod.Size = new System.Drawing.Size(158, 28);
            this.cbProizvod.TabIndex = 25;
            // 
            // numKolicina
            // 
            this.numKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKolicina.Location = new System.Drawing.Point(549, 6);
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(58, 27);
            this.numKolicina.TabIndex = 26;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlStavke
            // 
            this.pnlStavke.Controls.Add(this.dgvStavkeRacuna);
            this.pnlStavke.Location = new System.Drawing.Point(17, 155);
            this.pnlStavke.Name = "pnlStavke";
            this.pnlStavke.Size = new System.Drawing.Size(767, 202);
            this.pnlStavke.TabIndex = 27;
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AllowUserToAddRows = false;
            this.dgvStavkeRacuna.AllowUserToDeleteRows = false;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvStavkeRacuna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(0, 0);
            this.dgvStavkeRacuna.MultiSelect = false;
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.ReadOnly = true;
            this.dgvStavkeRacuna.RowHeadersWidth = 51;
            this.dgvStavkeRacuna.RowTemplate.Height = 24;
            this.dgvStavkeRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(767, 202);
            this.dgvStavkeRacuna.TabIndex = 0;
            // 
            // txtCenaStavke
            // 
            this.txtCenaStavke.Enabled = false;
            this.txtCenaStavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenaStavke.Location = new System.Drawing.Point(310, 5);
            this.txtCenaStavke.Name = "txtCenaStavke";
            this.txtCenaStavke.Size = new System.Drawing.Size(111, 27);
            this.txtCenaStavke.TabIndex = 28;
            this.txtCenaStavke.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Proizvod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Količina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Stavke računa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDodajStavku);
            this.panel1.Controls.Add(this.cbProizvod);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numKolicina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCenaStavke);
            this.panel1.Location = new System.Drawing.Point(17, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 39);
            this.panel1.TabIndex = 33;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajStavku.Location = new System.Drawing.Point(628, 3);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(135, 33);
            this.btnDodajStavku.TabIndex = 34;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(17, 363);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(161, 47);
            this.btnNazad.TabIndex = 35;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            // 
            // btnSacuvajRacun
            // 
            this.btnSacuvajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajRacun.Location = new System.Drawing.Point(623, 363);
            this.btnSacuvajRacun.Name = "btnSacuvajRacun";
            this.btnSacuvajRacun.Size = new System.Drawing.Size(161, 47);
            this.btnSacuvajRacun.TabIndex = 36;
            this.btnSacuvajRacun.Text = "Sačuvaj Račun";
            this.btnSacuvajRacun.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ukupna cena";
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Enabled = false;
            this.txtUkupnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUkupnaCena.Location = new System.Drawing.Point(566, 125);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.Size = new System.Drawing.Size(161, 27);
            this.txtUkupnaCena.TabIndex = 35;
            this.txtUkupnaCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiStavku.Location = new System.Drawing.Point(328, 363);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(161, 35);
            this.btnObrisiStavku.TabIndex = 39;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "RSD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(733, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "RSD";
            // 
            // UCRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSacuvajRacun);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlStavke);
            this.Controls.Add(this.lblNaslov);
            this.Name = "UCRacun";
            this.Size = new System.Drawing.Size(800, 422);
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.pnlStavke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ComboBox cbProizvod;
        internal System.Windows.Forms.NumericUpDown numKolicina;
        internal System.Windows.Forms.Panel pnlStavke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnDodajStavku;
        internal System.Windows.Forms.Button btnNazad;
        internal System.Windows.Forms.Button btnSacuvajRacun;
        internal System.Windows.Forms.DataGridView dgvStavkeRacuna;
        internal System.Windows.Forms.TextBox txtCenaStavke;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtUkupnaCena;
        internal System.Windows.Forms.Button btnObrisiStavku;
        internal System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}
