﻿namespace FrmLogin.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prodavacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajNalogProdavcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniProdavcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promeniSifruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajProizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziProizvodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.racunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajRacunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziRacuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.izmeniProdavcaToolStripMenuItem,
            this.promeniSifruToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.prodavacToolStripMenuItem.Name = "prodavacToolStripMenuItem";
            this.prodavacToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.prodavacToolStripMenuItem.Text = "Korisnik";
            this.prodavacToolStripMenuItem.Click += new System.EventHandler(this.prodavacToolStripMenuItem_Click);
            // 
            // kreirajNalogProdavcaToolStripMenuItem
            // 
            this.kreirajNalogProdavcaToolStripMenuItem.Name = "kreirajNalogProdavcaToolStripMenuItem";
            this.kreirajNalogProdavcaToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.kreirajNalogProdavcaToolStripMenuItem.Text = "Kreiraj prodavca";
            this.kreirajNalogProdavcaToolStripMenuItem.Click += new System.EventHandler(this.kreirajNalogProdavcaToolStripMenuItem_Click);
            // 
            // izmeniProdavcaToolStripMenuItem
            // 
            this.izmeniProdavcaToolStripMenuItem.Name = "izmeniProdavcaToolStripMenuItem";
            this.izmeniProdavcaToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.izmeniProdavcaToolStripMenuItem.Text = "Prikaži prodavce";
            this.izmeniProdavcaToolStripMenuItem.Click += new System.EventHandler(this.izmeniProdavcaToolStripMenuItem_Click);
            // 
            // promeniSifruToolStripMenuItem
            // 
            this.promeniSifruToolStripMenuItem.Name = "promeniSifruToolStripMenuItem";
            this.promeniSifruToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.promeniSifruToolStripMenuItem.Text = "Promeni šifru";
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            // 
            // proizvodToolStripMenuItem
            // 
            this.proizvodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajProizvodToolStripMenuItem,
            this.prikaziProizvodeToolStripMenuItem});
            this.proizvodToolStripMenuItem.Name = "proizvodToolStripMenuItem";
            this.proizvodToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.proizvodToolStripMenuItem.Text = "Proizvod";
            // 
            // kreirajProizvodToolStripMenuItem
            // 
            this.kreirajProizvodToolStripMenuItem.Name = "kreirajProizvodToolStripMenuItem";
            this.kreirajProizvodToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.kreirajProizvodToolStripMenuItem.Text = "Kreiraj proizvod";
            this.kreirajProizvodToolStripMenuItem.Click += new System.EventHandler(this.kreirajProizvodToolStripMenuItem_Click);
            // 
            // prikaziProizvodeToolStripMenuItem
            // 
            this.prikaziProizvodeToolStripMenuItem.Name = "prikaziProizvodeToolStripMenuItem";
            this.prikaziProizvodeToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.prikaziProizvodeToolStripMenuItem.Text = "Prikaži proizvode";
            // 
            // racunToolStripMenuItem
            // 
            this.racunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajRacunToolStripMenuItem,
            this.prikaziRacuneToolStripMenuItem});
            this.racunToolStripMenuItem.Name = "racunToolStripMenuItem";
            this.racunToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.racunToolStripMenuItem.Text = "Račun";
            // 
            // kreirajRacunToolStripMenuItem
            // 
            this.kreirajRacunToolStripMenuItem.Name = "kreirajRacunToolStripMenuItem";
            this.kreirajRacunToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.kreirajRacunToolStripMenuItem.Text = "Kreiraj račun";
            // 
            // prikaziRacuneToolStripMenuItem
            // 
            this.prikaziRacuneToolStripMenuItem.Name = "prikaziRacuneToolStripMenuItem";
            this.prikaziRacuneToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.prikaziRacuneToolStripMenuItem.Text = "Prikaži račune";
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackgroundImage = global::FrmLogin.Properties.Resources.Kolor_Tim_Logo;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Kolor Tim";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prodavacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajNalogProdavcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniProdavcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajProizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziProizvodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem racunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajRacunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziRacuneToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem promeniSifruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
    }
}