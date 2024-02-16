namespace FrmLogin.Forms
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prodavacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajNalogProdavcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiProdavcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajProizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiProizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pronadjiProizvodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajRacunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pronadjiRacuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stornirajRacunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prodavacToolStripMenuItem,
            this.proizvodToolStripMenuItem,
            this.racunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prodavacToolStripMenuItem
            // 
            this.prodavacToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajNalogProdavcaToolStripMenuItem,
            this.obrisiProdavcaToolStripMenuItem});
            this.prodavacToolStripMenuItem.Name = "prodavacToolStripMenuItem";
            this.prodavacToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.prodavacToolStripMenuItem.Text = "Prodavac";
            this.prodavacToolStripMenuItem.Click += new System.EventHandler(this.prodavacToolStripMenuItem_Click);
            // 
            // kreirajNalogProdavcaToolStripMenuItem
            // 
            this.kreirajNalogProdavcaToolStripMenuItem.Name = "kreirajNalogProdavcaToolStripMenuItem";
            this.kreirajNalogProdavcaToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.kreirajNalogProdavcaToolStripMenuItem.Text = "Kreiraj prodavca";
            // 
            // obrisiProdavcaToolStripMenuItem
            // 
            this.obrisiProdavcaToolStripMenuItem.Name = "obrisiProdavcaToolStripMenuItem";
            this.obrisiProdavcaToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.obrisiProdavcaToolStripMenuItem.Text = "Obrisi prodavca";
            // 
            // proizvodToolStripMenuItem
            // 
            this.proizvodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajProizvodToolStripMenuItem,
            this.obrisiProizvodToolStripMenuItem,
            this.pronadjiProizvodeToolStripMenuItem});
            this.proizvodToolStripMenuItem.Name = "proizvodToolStripMenuItem";
            this.proizvodToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.proizvodToolStripMenuItem.Text = "Proizvod";
            // 
            // kreirajProizvodToolStripMenuItem
            // 
            this.kreirajProizvodToolStripMenuItem.Name = "kreirajProizvodToolStripMenuItem";
            this.kreirajProizvodToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.kreirajProizvodToolStripMenuItem.Text = "Kreiraj proizvod";
            // 
            // obrisiProizvodToolStripMenuItem
            // 
            this.obrisiProizvodToolStripMenuItem.Name = "obrisiProizvodToolStripMenuItem";
            this.obrisiProizvodToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.obrisiProizvodToolStripMenuItem.Text = "Obrisi proizvod";
            // 
            // pronadjiProizvodeToolStripMenuItem
            // 
            this.pronadjiProizvodeToolStripMenuItem.Name = "pronadjiProizvodeToolStripMenuItem";
            this.pronadjiProizvodeToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.pronadjiProizvodeToolStripMenuItem.Text = "Pronadji proizvode";
            // 
            // racunToolStripMenuItem
            // 
            this.racunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajRacunToolStripMenuItem,
            this.pronadjiRacuneToolStripMenuItem,
            this.stornirajRacunToolStripMenuItem});
            this.racunToolStripMenuItem.Name = "racunToolStripMenuItem";
            this.racunToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.racunToolStripMenuItem.Text = "Racun";
            // 
            // kreirajRacunToolStripMenuItem
            // 
            this.kreirajRacunToolStripMenuItem.Name = "kreirajRacunToolStripMenuItem";
            this.kreirajRacunToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.kreirajRacunToolStripMenuItem.Text = "Kreiraj racun";
            // 
            // pronadjiRacuneToolStripMenuItem
            // 
            this.pronadjiRacuneToolStripMenuItem.Name = "pronadjiRacuneToolStripMenuItem";
            this.pronadjiRacuneToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.pronadjiRacuneToolStripMenuItem.Text = "Pronadji racune";
            // 
            // stornirajRacunToolStripMenuItem
            // 
            this.stornirajRacunToolStripMenuItem.Name = "stornirajRacunToolStripMenuItem";
            this.stornirajRacunToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.stornirajRacunToolStripMenuItem.Text = "Storniraj racun";
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 422);
            this.pnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prodavacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajNalogProdavcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiProdavcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajProizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiProizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pronadjiProizvodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajRacunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pronadjiRacuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stornirajRacunToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
    }
}