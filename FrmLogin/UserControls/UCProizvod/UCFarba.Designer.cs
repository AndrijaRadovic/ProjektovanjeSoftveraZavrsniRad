namespace FrmLogin.UserControls.UCProizvod
{
    partial class UCFarba
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBojaFarbe = new System.Windows.Forms.TextBox();
            this.txtVelicinaPakovanja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boja farbe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veličina pakovanja";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBojaFarbe
            // 
            this.txtBojaFarbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBojaFarbe.Location = new System.Drawing.Point(173, 40);
            this.txtBojaFarbe.Name = "txtBojaFarbe";
            this.txtBojaFarbe.Size = new System.Drawing.Size(100, 27);
            this.txtBojaFarbe.TabIndex = 0;
            // 
            // txtVelicinaPakovanja
            // 
            this.txtVelicinaPakovanja.BackColor = System.Drawing.SystemColors.Window;
            this.txtVelicinaPakovanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelicinaPakovanja.Location = new System.Drawing.Point(173, 96);
            this.txtVelicinaPakovanja.Name = "txtVelicinaPakovanja";
            this.txtVelicinaPakovanja.Size = new System.Drawing.Size(100, 27);
            this.txtVelicinaPakovanja.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "l";
            // 
            // UCFarba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVelicinaPakovanja);
            this.Controls.Add(this.txtBojaFarbe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCFarba";
            this.Size = new System.Drawing.Size(310, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtBojaFarbe;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtVelicinaPakovanja;
    }
}
