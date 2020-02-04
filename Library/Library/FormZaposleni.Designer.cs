namespace Library
{
    partial class FormZaposleni
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
            this.btnSveKnjige = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtImePisca = new System.Windows.Forms.TextBox();
            this.btnPisca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKnjiga = new System.Windows.Forms.TextBox();
            this.btnNaslovKnjige = new System.Windows.Forms.Button();
            this.rbRoman = new System.Windows.Forms.RadioButton();
            this.rbBeletristika = new System.Windows.Forms.RadioButton();
            this.rbPublicistika = new System.Windows.Forms.RadioButton();
            this.rbDomaciAutori = new System.Windows.Forms.RadioButton();
            this.btnZanr = new System.Windows.Forms.Button();
            this.rbPsihologija = new System.Windows.Forms.RadioButton();
            this.rbDecjeKnjige = new System.Windows.Forms.RadioButton();
            this.rbKlasici = new System.Windows.Forms.RadioButton();
            this.rbPoezija = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClanovi = new System.Windows.Forms.Button();
            this.cbClanovi = new System.Windows.Forms.ComboBox();
            this.btnIzdavanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSveKnjige
            // 
            this.btnSveKnjige.Location = new System.Drawing.Point(23, 27);
            this.btnSveKnjige.Name = "btnSveKnjige";
            this.btnSveKnjige.Size = new System.Drawing.Size(75, 23);
            this.btnSveKnjige.TabIndex = 0;
            this.btnSveKnjige.Text = "Sve knjige";
            this.btnSveKnjige.UseVisualStyleBackColor = true;
            this.btnSveKnjige.Click += new System.EventHandler(this.btnSveKnjige_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(786, 232);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtImePisca
            // 
            this.txtImePisca.Location = new System.Drawing.Point(276, 43);
            this.txtImePisca.Name = "txtImePisca";
            this.txtImePisca.Size = new System.Drawing.Size(100, 20);
            this.txtImePisca.TabIndex = 2;
            // 
            // btnPisca
            // 
            this.btnPisca.Location = new System.Drawing.Point(276, 69);
            this.btnPisca.Name = "btnPisca";
            this.btnPisca.Size = new System.Drawing.Size(75, 23);
            this.btnPisca.TabIndex = 3;
            this.btnPisca.Text = "Pronadji";
            this.btnPisca.UseVisualStyleBackColor = true;
            this.btnPisca.Click += new System.EventHandler(this.btnPisca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime pisca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naslov knjige:";
            // 
            // txtKnjiga
            // 
            this.txtKnjiga.Location = new System.Drawing.Point(122, 43);
            this.txtKnjiga.Name = "txtKnjiga";
            this.txtKnjiga.Size = new System.Drawing.Size(100, 20);
            this.txtKnjiga.TabIndex = 6;
            // 
            // btnNaslovKnjige
            // 
            this.btnNaslovKnjige.Location = new System.Drawing.Point(122, 69);
            this.btnNaslovKnjige.Name = "btnNaslovKnjige";
            this.btnNaslovKnjige.Size = new System.Drawing.Size(75, 23);
            this.btnNaslovKnjige.TabIndex = 7;
            this.btnNaslovKnjige.Text = "Pronadji";
            this.btnNaslovKnjige.UseVisualStyleBackColor = true;
            this.btnNaslovKnjige.Click += new System.EventHandler(this.btnNaslovKnjige_Click);
            // 
            // rbRoman
            // 
            this.rbRoman.AutoSize = true;
            this.rbRoman.Location = new System.Drawing.Point(453, 25);
            this.rbRoman.Name = "rbRoman";
            this.rbRoman.Size = new System.Drawing.Size(61, 17);
            this.rbRoman.TabIndex = 8;
            this.rbRoman.TabStop = true;
            this.rbRoman.Text = "Romani";
            this.rbRoman.UseVisualStyleBackColor = true;
            // 
            // rbBeletristika
            // 
            this.rbBeletristika.AutoSize = true;
            this.rbBeletristika.Location = new System.Drawing.Point(453, 48);
            this.rbBeletristika.Name = "rbBeletristika";
            this.rbBeletristika.Size = new System.Drawing.Size(76, 17);
            this.rbBeletristika.TabIndex = 9;
            this.rbBeletristika.TabStop = true;
            this.rbBeletristika.Text = "Beletristika";
            this.rbBeletristika.UseVisualStyleBackColor = true;
            // 
            // rbPublicistika
            // 
            this.rbPublicistika.AutoSize = true;
            this.rbPublicistika.Location = new System.Drawing.Point(453, 75);
            this.rbPublicistika.Name = "rbPublicistika";
            this.rbPublicistika.Size = new System.Drawing.Size(78, 17);
            this.rbPublicistika.TabIndex = 10;
            this.rbPublicistika.TabStop = true;
            this.rbPublicistika.Text = "Publicistika";
            this.rbPublicistika.UseVisualStyleBackColor = true;
            // 
            // rbDomaciAutori
            // 
            this.rbDomaciAutori.AutoSize = true;
            this.rbDomaciAutori.Location = new System.Drawing.Point(453, 98);
            this.rbDomaciAutori.Name = "rbDomaciAutori";
            this.rbDomaciAutori.Size = new System.Drawing.Size(90, 17);
            this.rbDomaciAutori.TabIndex = 11;
            this.rbDomaciAutori.TabStop = true;
            this.rbDomaciAutori.Text = "Domaci autori";
            this.rbDomaciAutori.UseVisualStyleBackColor = true;
            // 
            // btnZanr
            // 
            this.btnZanr.Location = new System.Drawing.Point(453, 121);
            this.btnZanr.Name = "btnZanr";
            this.btnZanr.Size = new System.Drawing.Size(75, 23);
            this.btnZanr.TabIndex = 12;
            this.btnZanr.Text = "Pronadji";
            this.btnZanr.UseVisualStyleBackColor = true;
            this.btnZanr.Click += new System.EventHandler(this.btnZanr_Click);
            // 
            // rbPsihologija
            // 
            this.rbPsihologija.AutoSize = true;
            this.rbPsihologija.Location = new System.Drawing.Point(541, 25);
            this.rbPsihologija.Name = "rbPsihologija";
            this.rbPsihologija.Size = new System.Drawing.Size(75, 17);
            this.rbPsihologija.TabIndex = 13;
            this.rbPsihologija.TabStop = true;
            this.rbPsihologija.Text = "Psihologija";
            this.rbPsihologija.UseVisualStyleBackColor = true;
            // 
            // rbDecjeKnjige
            // 
            this.rbDecjeKnjige.AutoSize = true;
            this.rbDecjeKnjige.Location = new System.Drawing.Point(541, 48);
            this.rbDecjeKnjige.Name = "rbDecjeKnjige";
            this.rbDecjeKnjige.Size = new System.Drawing.Size(84, 17);
            this.rbDecjeKnjige.TabIndex = 14;
            this.rbDecjeKnjige.TabStop = true;
            this.rbDecjeKnjige.Text = "Decje knjige";
            this.rbDecjeKnjige.UseVisualStyleBackColor = true;
            // 
            // rbKlasici
            // 
            this.rbKlasici.AutoSize = true;
            this.rbKlasici.Location = new System.Drawing.Point(541, 72);
            this.rbKlasici.Name = "rbKlasici";
            this.rbKlasici.Size = new System.Drawing.Size(55, 17);
            this.rbKlasici.TabIndex = 15;
            this.rbKlasici.TabStop = true;
            this.rbKlasici.Text = "Klasici";
            this.rbKlasici.UseVisualStyleBackColor = true;
            // 
            // rbPoezija
            // 
            this.rbPoezija.AutoSize = true;
            this.rbPoezija.Location = new System.Drawing.Point(541, 98);
            this.rbPoezija.Name = "rbPoezija";
            this.rbPoezija.Size = new System.Drawing.Size(59, 17);
            this.rbPoezija.TabIndex = 16;
            this.rbPoezija.TabStop = true;
            this.rbPoezija.Text = "Poezija";
            this.rbPoezija.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Zanr:";
            // 
            // btnClanovi
            // 
            this.btnClanovi.Location = new System.Drawing.Point(688, 12);
            this.btnClanovi.Name = "btnClanovi";
            this.btnClanovi.Size = new System.Drawing.Size(89, 38);
            this.btnClanovi.TabIndex = 18;
            this.btnClanovi.Text = "Ucitaj clanove";
            this.btnClanovi.UseVisualStyleBackColor = true;
            this.btnClanovi.Click += new System.EventHandler(this.btnIzdavanje_Click);
            // 
            // cbClanovi
            // 
            this.cbClanovi.FormattingEnabled = true;
            this.cbClanovi.Location = new System.Drawing.Point(688, 68);
            this.cbClanovi.Name = "cbClanovi";
            this.cbClanovi.Size = new System.Drawing.Size(121, 21);
            this.cbClanovi.TabIndex = 19;
            this.cbClanovi.Click += new System.EventHandler(this.cbClanovi_Click);
            // 
            // btnIzdavanje
            // 
            this.btnIzdavanje.Location = new System.Drawing.Point(688, 109);
            this.btnIzdavanje.Name = "btnIzdavanje";
            this.btnIzdavanje.Size = new System.Drawing.Size(89, 35);
            this.btnIzdavanje.TabIndex = 20;
            this.btnIzdavanje.Text = "Izdavanje";
            this.btnIzdavanje.UseVisualStyleBackColor = true;
            this.btnIzdavanje.Click += new System.EventHandler(this.btnIzdavanje_Click_1);
            // 
            // FormZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 405);
            this.Controls.Add(this.btnIzdavanje);
            this.Controls.Add(this.cbClanovi);
            this.Controls.Add(this.btnClanovi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbPoezija);
            this.Controls.Add(this.rbKlasici);
            this.Controls.Add(this.rbDecjeKnjige);
            this.Controls.Add(this.rbPsihologija);
            this.Controls.Add(this.btnZanr);
            this.Controls.Add(this.rbDomaciAutori);
            this.Controls.Add(this.rbPublicistika);
            this.Controls.Add(this.rbBeletristika);
            this.Controls.Add(this.rbRoman);
            this.Controls.Add(this.btnNaslovKnjige);
            this.Controls.Add(this.txtKnjiga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPisca);
            this.Controls.Add(this.txtImePisca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSveKnjige);
            this.Name = "FormZaposleni";
            this.Text = "FormZaposleni";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSveKnjige;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtImePisca;
        private System.Windows.Forms.Button btnPisca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKnjiga;
        private System.Windows.Forms.Button btnNaslovKnjige;
        private System.Windows.Forms.RadioButton rbRoman;
        private System.Windows.Forms.RadioButton rbBeletristika;
        private System.Windows.Forms.RadioButton rbPublicistika;
        private System.Windows.Forms.RadioButton rbDomaciAutori;
        private System.Windows.Forms.Button btnZanr;
        private System.Windows.Forms.RadioButton rbPsihologija;
        private System.Windows.Forms.RadioButton rbDecjeKnjige;
        private System.Windows.Forms.RadioButton rbKlasici;
        private System.Windows.Forms.RadioButton rbPoezija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClanovi;
        private System.Windows.Forms.ComboBox cbClanovi;
        private System.Windows.Forms.Button btnIzdavanje;
    }
}