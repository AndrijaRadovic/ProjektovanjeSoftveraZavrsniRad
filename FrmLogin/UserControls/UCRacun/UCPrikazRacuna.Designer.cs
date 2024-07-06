namespace FrmLogin.UserControls.UCRacun
{
    partial class UCPrikazRacuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbRacuni = new System.Windows.Forms.ComboBox();
            this.dtpDatumRacuna = new System.Windows.Forms.DateTimePicker();
            this.pnlStavkeRacuna = new System.Windows.Forms.Panel();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlStavkeRacuna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(13, 18);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(119, 38);
            this.lblNaslov.TabIndex = 25;
            this.lblNaslov.Text = "Računi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Račun";
            // 
            // cbRacuni
            // 
            this.cbRacuni.FormattingEnabled = true;
            this.cbRacuni.Location = new System.Drawing.Point(79, 82);
            this.cbRacuni.Name = "cbRacuni";
            this.cbRacuni.Size = new System.Drawing.Size(403, 24);
            this.cbRacuni.TabIndex = 0;
            // 
            // dtpDatumRacuna
            // 
            this.dtpDatumRacuna.Location = new System.Drawing.Point(488, 83);
            this.dtpDatumRacuna.Name = "dtpDatumRacuna";
            this.dtpDatumRacuna.Size = new System.Drawing.Size(247, 22);
            this.dtpDatumRacuna.TabIndex = 1;
            // 
            // pnlStavkeRacuna
            // 
            this.pnlStavkeRacuna.Controls.Add(this.dgvStavkeRacuna);
            this.pnlStavkeRacuna.Location = new System.Drawing.Point(20, 137);
            this.pnlStavkeRacuna.Name = "pnlStavkeRacuna";
            this.pnlStavkeRacuna.Size = new System.Drawing.Size(757, 232);
            this.pnlStavkeRacuna.TabIndex = 29;
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AllowUserToAddRows = false;
            this.dgvStavkeRacuna.AllowUserToDeleteRows = false;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(0, 0);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.ReadOnly = true;
            this.dgvStavkeRacuna.RowHeadersWidth = 51;
            this.dgvStavkeRacuna.RowTemplate.Height = 24;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(757, 232);
            this.dgvStavkeRacuna.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Stavke računa";
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(20, 375);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(120, 44);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorniraj.Location = new System.Drawing.Point(657, 375);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(120, 44);
            this.btnStorniraj.TabIndex = 4;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(342, 375);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(120, 44);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::FrmLogin.Properties.Resources.reload;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(741, 82);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 24);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // UCPrikazRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlStavkeRacuna);
            this.Controls.Add(this.dtpDatumRacuna);
            this.Controls.Add(this.cbRacuni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaslov);
            this.Name = "UCPrikazRacuna";
            this.Size = new System.Drawing.Size(800, 422);
            this.pnlStavkeRacuna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker dtpDatumRacuna;
        private System.Windows.Forms.Panel pnlStavkeRacuna;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cbRacuni;
        internal System.Windows.Forms.DataGridView dgvStavkeRacuna;
        internal System.Windows.Forms.Button btnNazad;
        internal System.Windows.Forms.Button btnStorniraj;
        internal System.Windows.Forms.Button btnIzmeni;
        internal System.Windows.Forms.Button btnRefresh;
    }
}
