namespace FrmLogin.UserControls.UCProdavac
{
    partial class UCPromeniSifru
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaraSifra = new System.Windows.Forms.TextBox();
            this.txtNovaSifra = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 38);
            this.label7.TabIndex = 15;
            this.label7.Text = "Promena šifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Stara šifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nova šifra";
            // 
            // txtStaraSifra
            // 
            this.txtStaraSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaraSifra.Location = new System.Drawing.Point(121, 105);
            this.txtStaraSifra.Name = "txtStaraSifra";
            this.txtStaraSifra.Size = new System.Drawing.Size(197, 27);
            this.txtStaraSifra.TabIndex = 18;
            // 
            // txtNovaSifra
            // 
            this.txtNovaSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSifra.Location = new System.Drawing.Point(121, 146);
            this.txtNovaSifra.Name = "txtNovaSifra";
            this.txtNovaSifra.Size = new System.Drawing.Size(197, 27);
            this.txtNovaSifra.TabIndex = 19;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(32, 223);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(119, 47);
            this.btnOdustani.TabIndex = 20;
            this.btnOdustani.Text = "Nazad";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.Location = new System.Drawing.Point(199, 223);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(119, 47);
            this.btnPotvrdi.TabIndex = 21;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            // 
            // UCPromeniSifru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtNovaSifra);
            this.Controls.Add(this.txtStaraSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "UCPromeniSifru";
            this.Size = new System.Drawing.Size(373, 477);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtStaraSifra;
        internal System.Windows.Forms.TextBox txtNovaSifra;
        internal System.Windows.Forms.Button btnOdustani;
        internal System.Windows.Forms.Button btnPotvrdi;
    }
}
