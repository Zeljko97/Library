namespace Library
{
    partial class FormAzurirajKnjigu
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
            this.txtBrojPrimeraka = new System.Windows.Forms.TextBox();
            this.lblBrojPrimeraka = new System.Windows.Forms.Label();
            this.txtBrojStrana = new System.Windows.Forms.TextBox();
            this.lblBrojStrana = new System.Windows.Forms.Label();
            this.cbPovez = new System.Windows.Forms.ComboBox();
            this.cbZanr = new System.Windows.Forms.ComboBox();
            this.lblPovez = new System.Windows.Forms.Label();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBrojPrimeraka
            // 
            this.txtBrojPrimeraka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojPrimeraka.Location = new System.Drawing.Point(149, 217);
            this.txtBrojPrimeraka.MaxLength = 3;
            this.txtBrojPrimeraka.Name = "txtBrojPrimeraka";
            this.txtBrojPrimeraka.Size = new System.Drawing.Size(173, 29);
            this.txtBrojPrimeraka.TabIndex = 46;
            this.txtBrojPrimeraka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojPrimeraka_KeyPress);
            // 
            // lblBrojPrimeraka
            // 
            this.lblBrojPrimeraka.AutoSize = true;
            this.lblBrojPrimeraka.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojPrimeraka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPrimeraka.ForeColor = System.Drawing.Color.Black;
            this.lblBrojPrimeraka.Location = new System.Drawing.Point(12, 220);
            this.lblBrojPrimeraka.Name = "lblBrojPrimeraka";
            this.lblBrojPrimeraka.Size = new System.Drawing.Size(131, 24);
            this.lblBrojPrimeraka.TabIndex = 48;
            this.lblBrojPrimeraka.Text = "Broj primeraka";
            // 
            // txtBrojStrana
            // 
            this.txtBrojStrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojStrana.Location = new System.Drawing.Point(149, 182);
            this.txtBrojStrana.MaxLength = 3;
            this.txtBrojStrana.Name = "txtBrojStrana";
            this.txtBrojStrana.Size = new System.Drawing.Size(173, 29);
            this.txtBrojStrana.TabIndex = 45;
            this.txtBrojStrana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojStrana_KeyPress);
            // 
            // lblBrojStrana
            // 
            this.lblBrojStrana.AutoSize = true;
            this.lblBrojStrana.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojStrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojStrana.ForeColor = System.Drawing.Color.Black;
            this.lblBrojStrana.Location = new System.Drawing.Point(12, 185);
            this.lblBrojStrana.Name = "lblBrojStrana";
            this.lblBrojStrana.Size = new System.Drawing.Size(98, 24);
            this.lblBrojStrana.TabIndex = 46;
            this.lblBrojStrana.Text = "Broj strana";
            // 
            // cbPovez
            // 
            this.cbPovez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPovez.FormattingEnabled = true;
            this.cbPovez.Items.AddRange(new object[] {
            "tvrdi",
            "meki"});
            this.cbPovez.Location = new System.Drawing.Point(149, 144);
            this.cbPovez.Name = "cbPovez";
            this.cbPovez.Size = new System.Drawing.Size(173, 32);
            this.cbPovez.TabIndex = 44;
            // 
            // cbZanr
            // 
            this.cbZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbZanr.FormattingEnabled = true;
            this.cbZanr.Items.AddRange(new object[] {
            "roman",
            "publicistika",
            "poezija",
            "klasika",
            "decja knjiga",
            "psihologija",
            "horror"});
            this.cbZanr.Location = new System.Drawing.Point(149, 75);
            this.cbZanr.Name = "cbZanr";
            this.cbZanr.Size = new System.Drawing.Size(173, 32);
            this.cbZanr.TabIndex = 42;
            // 
            // lblPovez
            // 
            this.lblPovez.AutoSize = true;
            this.lblPovez.BackColor = System.Drawing.Color.Transparent;
            this.lblPovez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPovez.ForeColor = System.Drawing.Color.Black;
            this.lblPovez.Location = new System.Drawing.Point(12, 152);
            this.lblPovez.Name = "lblPovez";
            this.lblPovez.Size = new System.Drawing.Size(103, 24);
            this.lblPovez.TabIndex = 43;
            this.lblPovez.Text = "Tip poveza";
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzdavac.Location = new System.Drawing.Point(149, 111);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(173, 29);
            this.txtIzdavac.TabIndex = 43;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(149, 40);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(173, 29);
            this.txtAutor.TabIndex = 41;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(149, 7);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(173, 29);
            this.txtNaslov.TabIndex = 40;
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.BackColor = System.Drawing.Color.Transparent;
            this.lblIzdavac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzdavac.ForeColor = System.Drawing.Color.Black;
            this.lblIzdavac.Location = new System.Drawing.Point(12, 114);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(73, 24);
            this.lblIzdavac.TabIndex = 39;
            this.lblIzdavac.Text = "Izdavac";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.BackColor = System.Drawing.Color.Transparent;
            this.lblZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZanr.ForeColor = System.Drawing.Color.Black;
            this.lblZanr.Location = new System.Drawing.Point(12, 78);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(49, 24);
            this.lblZanr.TabIndex = 38;
            this.lblZanr.Text = "Zanr";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.Black;
            this.lblAutor.Location = new System.Drawing.Point(12, 43);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 24);
            this.lblAutor.TabIndex = 37;
            this.lblAutor.Text = "Autor";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.Black;
            this.lblNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(67, 24);
            this.lblNaslov.TabIndex = 36;
            this.lblNaslov.Text = "Naslov";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Ivory;
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(86, 252);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(173, 43);
            this.btnDodaj.TabIndex = 47;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormAzurirajKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 305);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtBrojPrimeraka);
            this.Controls.Add(this.lblBrojPrimeraka);
            this.Controls.Add(this.txtBrojStrana);
            this.Controls.Add(this.lblBrojStrana);
            this.Controls.Add(this.cbPovez);
            this.Controls.Add(this.cbZanr);
            this.Controls.Add(this.lblPovez);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblIzdavac);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAzurirajKnjigu";
            this.Opacity = 0.97D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azuriranje knjige";
            this.Load += new System.EventHandler(this.FormAzurirajKnjigu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojPrimeraka;
        private System.Windows.Forms.Label lblBrojPrimeraka;
        private System.Windows.Forms.TextBox txtBrojStrana;
        private System.Windows.Forms.Label lblBrojStrana;
        private System.Windows.Forms.ComboBox cbPovez;
        private System.Windows.Forms.ComboBox cbZanr;
        private System.Windows.Forms.Label lblPovez;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnDodaj;
    }
}