namespace Library
{
    partial class FormDodajKnjigu
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
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPovez = new System.Windows.Forms.Label();
            this.cbZanr = new System.Windows.Forms.ComboBox();
            this.cbPovez = new System.Windows.Forms.ComboBox();
            this.txtBrojStrana = new System.Windows.Forms.TextBox();
            this.lblBrojStrana = new System.Windows.Forms.Label();
            this.txtBrojPrimeraka = new System.Windows.Forms.TextBox();
            this.lblBrojPrimeraka = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzdavac.Location = new System.Drawing.Point(153, 116);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(173, 29);
            this.txtIzdavac.TabIndex = 27;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(153, 45);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(173, 29);
            this.txtAutor.TabIndex = 25;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaslov.Location = new System.Drawing.Point(153, 12);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(173, 29);
            this.txtNaslov.TabIndex = 24;
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.BackColor = System.Drawing.Color.Transparent;
            this.lblIzdavac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzdavac.ForeColor = System.Drawing.Color.Black;
            this.lblIzdavac.Location = new System.Drawing.Point(16, 119);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(73, 24);
            this.lblIzdavac.TabIndex = 23;
            this.lblIzdavac.Text = "Izdavac";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.BackColor = System.Drawing.Color.Transparent;
            this.lblZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZanr.ForeColor = System.Drawing.Color.Black;
            this.lblZanr.Location = new System.Drawing.Point(16, 83);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(49, 24);
            this.lblZanr.TabIndex = 22;
            this.lblZanr.Text = "Zanr";
            this.lblZanr.Click += new System.EventHandler(this.lblIzdavac_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.Black;
            this.lblAutor.Location = new System.Drawing.Point(16, 48);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 24);
            this.lblAutor.TabIndex = 21;
            this.lblAutor.Text = "Autor";
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.Black;
            this.lblNaslov.Location = new System.Drawing.Point(16, 14);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(67, 24);
            this.lblNaslov.TabIndex = 20;
            this.lblNaslov.Text = "Naslov";
            // 
            // lblPovez
            // 
            this.lblPovez.AutoSize = true;
            this.lblPovez.BackColor = System.Drawing.Color.Transparent;
            this.lblPovez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPovez.ForeColor = System.Drawing.Color.Black;
            this.lblPovez.Location = new System.Drawing.Point(16, 157);
            this.lblPovez.Name = "lblPovez";
            this.lblPovez.Size = new System.Drawing.Size(103, 24);
            this.lblPovez.TabIndex = 28;
            this.lblPovez.Text = "Tip poveza";
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
            this.cbZanr.Location = new System.Drawing.Point(153, 80);
            this.cbZanr.Name = "cbZanr";
            this.cbZanr.Size = new System.Drawing.Size(173, 32);
            this.cbZanr.TabIndex = 26;
            // 
            // cbPovez
            // 
            this.cbPovez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPovez.FormattingEnabled = true;
            this.cbPovez.Items.AddRange(new object[] {
            "tvrdi",
            "meki"});
            this.cbPovez.Location = new System.Drawing.Point(153, 149);
            this.cbPovez.Name = "cbPovez";
            this.cbPovez.Size = new System.Drawing.Size(173, 32);
            this.cbPovez.TabIndex = 28;
            // 
            // txtBrojStrana
            // 
            this.txtBrojStrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojStrana.Location = new System.Drawing.Point(153, 187);
            this.txtBrojStrana.MaxLength = 3;
            this.txtBrojStrana.Name = "txtBrojStrana";
            this.txtBrojStrana.Size = new System.Drawing.Size(173, 29);
            this.txtBrojStrana.TabIndex = 29;
            // 
            // lblBrojStrana
            // 
            this.lblBrojStrana.AutoSize = true;
            this.lblBrojStrana.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojStrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojStrana.ForeColor = System.Drawing.Color.Black;
            this.lblBrojStrana.Location = new System.Drawing.Point(16, 190);
            this.lblBrojStrana.Name = "lblBrojStrana";
            this.lblBrojStrana.Size = new System.Drawing.Size(98, 24);
            this.lblBrojStrana.TabIndex = 32;
            this.lblBrojStrana.Text = "Broj strana";
            // 
            // txtBrojPrimeraka
            // 
            this.txtBrojPrimeraka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojPrimeraka.Location = new System.Drawing.Point(153, 222);
            this.txtBrojPrimeraka.MaxLength = 3;
            this.txtBrojPrimeraka.Name = "txtBrojPrimeraka";
            this.txtBrojPrimeraka.Size = new System.Drawing.Size(173, 29);
            this.txtBrojPrimeraka.TabIndex = 30;
            // 
            // lblBrojPrimeraka
            // 
            this.lblBrojPrimeraka.AutoSize = true;
            this.lblBrojPrimeraka.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojPrimeraka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPrimeraka.ForeColor = System.Drawing.Color.Black;
            this.lblBrojPrimeraka.Location = new System.Drawing.Point(16, 225);
            this.lblBrojPrimeraka.Name = "lblBrojPrimeraka";
            this.lblBrojPrimeraka.Size = new System.Drawing.Size(131, 24);
            this.lblBrojPrimeraka.TabIndex = 34;
            this.lblBrojPrimeraka.Text = "Broj primeraka";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(20, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 100);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oznake";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(186, 65);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(83, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "decja knjiga";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(186, 42);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(75, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "psihologija";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(186, 19);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(52, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "proza";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(100, 65);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(59, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "poezija";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(100, 42);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(45, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "triler";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(100, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(68, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "komedija";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(14, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "strani autor";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "domaci Autor";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "roman";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Ivory;
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(85, 363);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(173, 43);
            this.btnDodaj.TabIndex = 31;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormDodajKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(347, 408);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox1);
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
            this.MaximizeBox = false;
            this.Name = "FormDodajKnjigu";
            this.ShowIcon = false;
            this.Text = "Dodavanje nove knjige";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPovez;
        private System.Windows.Forms.ComboBox cbZanr;
        private System.Windows.Forms.ComboBox cbPovez;
        private System.Windows.Forms.TextBox txtBrojStrana;
        private System.Windows.Forms.Label lblBrojStrana;
        private System.Windows.Forms.TextBox txtBrojPrimeraka;
        private System.Windows.Forms.Label lblBrojPrimeraka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnDodaj;
    }
}