namespace FrmLogin.UserControls.UCProdavac
{
    partial class UCIzmeniProdavca
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretragaIme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cbPretraga = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 38);
            this.label7.TabIndex = 15;
            this.label7.Text = "Korisnici";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.Location = new System.Drawing.Point(256, 112);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(210, 27);
            this.txtPretraga.TabIndex = 16;
            // 
            // btnPretragaIme
            // 
            this.btnPretragaIme.BackgroundImage = global::FrmLogin.Properties.Resources.search;
            this.btnPretragaIme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPretragaIme.Location = new System.Drawing.Point(472, 112);
            this.btnPretragaIme.Name = "btnPretragaIme";
            this.btnPretragaIme.Size = new System.Drawing.Size(56, 27);
            this.btnPretragaIme.TabIndex = 17;
            this.btnPretragaIme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pretraga";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvKorisnici);
            this.panel1.Location = new System.Drawing.Point(32, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 223);
            this.panel1.TabIndex = 19;
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(0, 0);
            this.dgvKorisnici.MultiSelect = false;
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 24;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(738, 223);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(32, 407);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(135, 50);
            this.btnOdustani.TabIndex = 20;
            this.btnOdustani.Text = "Nazad";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(350, 407);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(135, 50);
            this.btnIzmeni.TabIndex = 21;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(635, 407);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(135, 50);
            this.btnObrisi.TabIndex = 22;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // cbPretraga
            // 
            this.cbPretraga.FormattingEnabled = true;
            this.cbPretraga.Location = new System.Drawing.Point(129, 115);
            this.cbPretraga.Name = "cbPretraga";
            this.cbPretraga.Size = new System.Drawing.Size(121, 24);
            this.cbPretraga.TabIndex = 23;
            // 
            // UCIzmeniProdavca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPretraga);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretragaIme);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label7);
            this.Name = "UCIzmeniProdavca";
            this.Size = new System.Drawing.Size(800, 472);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnPretragaIme;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnOdustani;
        internal System.Windows.Forms.Button btnIzmeni;
        internal System.Windows.Forms.Button btnObrisi;
        internal System.Windows.Forms.DataGridView dgvKorisnici;
        internal System.Windows.Forms.ComboBox cbPretraga;
    }
}
