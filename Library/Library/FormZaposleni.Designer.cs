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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZaposleni));
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
            this.rbPsihologija = new System.Windows.Forms.RadioButton();
            this.rbDecjeKnjige = new System.Windows.Forms.RadioButton();
            this.rbKlasici = new System.Windows.Forms.RadioButton();
            this.rbPoezija = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClanovi = new System.Windows.Forms.Button();
            this.cbClanovi = new System.Windows.Forms.ComboBox();
            this.btnIzdavanje = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnUserPass = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUcitajZahteve = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ttPromena = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZanr = new System.Windows.Forms.Button();
            this.btnSveKnjige = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(17, 198);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(470, 189);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtImePisca
            // 
            this.txtImePisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePisca.Location = new System.Drawing.Point(142, 43);
            this.txtImePisca.Name = "txtImePisca";
            this.txtImePisca.Size = new System.Drawing.Size(100, 21);
            this.txtImePisca.TabIndex = 2;
            // 
            // btnPisca
            // 
            this.btnPisca.BackColor = System.Drawing.Color.Transparent;
            this.btnPisca.BackgroundImage = global::Library.Properties.Resources.find;
            this.btnPisca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPisca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPisca.Location = new System.Drawing.Point(154, 70);
            this.btnPisca.Name = "btnPisca";
            this.btnPisca.Size = new System.Drawing.Size(79, 45);
            this.btnPisca.TabIndex = 3;
            this.btnPisca.UseVisualStyleBackColor = false;
            this.btnPisca.Click += new System.EventHandler(this.btnPisca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime pisca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naslov knjige:";
            // 
            // txtKnjiga
            // 
            this.txtKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKnjiga.Location = new System.Drawing.Point(15, 43);
            this.txtKnjiga.Name = "txtKnjiga";
            this.txtKnjiga.Size = new System.Drawing.Size(100, 21);
            this.txtKnjiga.TabIndex = 6;
            // 
            // btnNaslovKnjige
            // 
            this.btnNaslovKnjige.BackColor = System.Drawing.Color.Transparent;
            this.btnNaslovKnjige.BackgroundImage = global::Library.Properties.Resources.find;
            this.btnNaslovKnjige.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNaslovKnjige.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaslovKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaslovKnjige.Location = new System.Drawing.Point(30, 70);
            this.btnNaslovKnjige.Name = "btnNaslovKnjige";
            this.btnNaslovKnjige.Size = new System.Drawing.Size(79, 45);
            this.btnNaslovKnjige.TabIndex = 7;
            this.btnNaslovKnjige.UseVisualStyleBackColor = false;
            this.btnNaslovKnjige.Click += new System.EventHandler(this.btnNaslovKnjige_Click);
            // 
            // rbRoman
            // 
            this.rbRoman.AutoSize = true;
            this.rbRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRoman.Location = new System.Drawing.Point(15, 22);
            this.rbRoman.Name = "rbRoman";
            this.rbRoman.Size = new System.Drawing.Size(67, 17);
            this.rbRoman.TabIndex = 8;
            this.rbRoman.TabStop = true;
            this.rbRoman.Text = "Romani";
            this.rbRoman.UseVisualStyleBackColor = true;
            // 
            // rbBeletristika
            // 
            this.rbBeletristika.AutoSize = true;
            this.rbBeletristika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBeletristika.Location = new System.Drawing.Point(15, 45);
            this.rbBeletristika.Name = "rbBeletristika";
            this.rbBeletristika.Size = new System.Drawing.Size(88, 17);
            this.rbBeletristika.TabIndex = 9;
            this.rbBeletristika.TabStop = true;
            this.rbBeletristika.Text = "Beletristika";
            this.rbBeletristika.UseVisualStyleBackColor = true;
            // 
            // rbPublicistika
            // 
            this.rbPublicistika.AutoSize = true;
            this.rbPublicistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPublicistika.Location = new System.Drawing.Point(15, 72);
            this.rbPublicistika.Name = "rbPublicistika";
            this.rbPublicistika.Size = new System.Drawing.Size(90, 17);
            this.rbPublicistika.TabIndex = 10;
            this.rbPublicistika.TabStop = true;
            this.rbPublicistika.Text = "Publicistika";
            this.rbPublicistika.UseVisualStyleBackColor = true;
            // 
            // rbDomaciAutori
            // 
            this.rbDomaciAutori.AutoSize = true;
            this.rbDomaciAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDomaciAutori.Location = new System.Drawing.Point(15, 95);
            this.rbDomaciAutori.Name = "rbDomaciAutori";
            this.rbDomaciAutori.Size = new System.Drawing.Size(103, 17);
            this.rbDomaciAutori.TabIndex = 11;
            this.rbDomaciAutori.TabStop = true;
            this.rbDomaciAutori.Text = "Domaci autori";
            this.rbDomaciAutori.UseVisualStyleBackColor = true;
            // 
            // rbPsihologija
            // 
            this.rbPsihologija.AutoSize = true;
            this.rbPsihologija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPsihologija.Location = new System.Drawing.Point(123, 22);
            this.rbPsihologija.Name = "rbPsihologija";
            this.rbPsihologija.Size = new System.Drawing.Size(86, 17);
            this.rbPsihologija.TabIndex = 13;
            this.rbPsihologija.TabStop = true;
            this.rbPsihologija.Text = "Psihologija";
            this.rbPsihologija.UseVisualStyleBackColor = true;
            // 
            // rbDecjeKnjige
            // 
            this.rbDecjeKnjige.AutoSize = true;
            this.rbDecjeKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDecjeKnjige.Location = new System.Drawing.Point(123, 45);
            this.rbDecjeKnjige.Name = "rbDecjeKnjige";
            this.rbDecjeKnjige.Size = new System.Drawing.Size(96, 17);
            this.rbDecjeKnjige.TabIndex = 14;
            this.rbDecjeKnjige.TabStop = true;
            this.rbDecjeKnjige.Text = "Decje knjige";
            this.rbDecjeKnjige.UseVisualStyleBackColor = true;
            // 
            // rbKlasici
            // 
            this.rbKlasici.AutoSize = true;
            this.rbKlasici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKlasici.Location = new System.Drawing.Point(123, 69);
            this.rbKlasici.Name = "rbKlasici";
            this.rbKlasici.Size = new System.Drawing.Size(62, 17);
            this.rbKlasici.TabIndex = 15;
            this.rbKlasici.TabStop = true;
            this.rbKlasici.Text = "Klasici";
            this.rbKlasici.UseVisualStyleBackColor = true;
            // 
            // rbPoezija
            // 
            this.rbPoezija.AutoSize = true;
            this.rbPoezija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPoezija.Location = new System.Drawing.Point(123, 95);
            this.rbPoezija.Name = "rbPoezija";
            this.rbPoezija.Size = new System.Drawing.Size(66, 17);
            this.rbPoezija.TabIndex = 16;
            this.rbPoezija.TabStop = true;
            this.rbPoezija.Text = "Poezija";
            this.rbPoezija.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Zanr:";
            // 
            // btnClanovi
            // 
            this.btnClanovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClanovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClanovi.Location = new System.Drawing.Point(17, 155);
            this.btnClanovi.Name = "btnClanovi";
            this.btnClanovi.Size = new System.Drawing.Size(121, 32);
            this.btnClanovi.TabIndex = 18;
            this.btnClanovi.Text = "Ucitaj clanove";
            this.btnClanovi.UseVisualStyleBackColor = true;
            this.btnClanovi.Click += new System.EventHandler(this.btnIzdavanje_Click);
            // 
            // cbClanovi
            // 
            this.cbClanovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbClanovi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClanovi.FormattingEnabled = true;
            this.cbClanovi.Location = new System.Drawing.Point(144, 159);
            this.cbClanovi.Name = "cbClanovi";
            this.cbClanovi.Size = new System.Drawing.Size(121, 28);
            this.cbClanovi.TabIndex = 19;
            this.cbClanovi.Click += new System.EventHandler(this.cbClanovi_Click);
            // 
            // btnIzdavanje
            // 
            this.btnIzdavanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzdavanje.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzdavanje.Location = new System.Drawing.Point(558, 352);
            this.btnIzdavanje.Name = "btnIzdavanje";
            this.btnIzdavanje.Size = new System.Drawing.Size(121, 35);
            this.btnIzdavanje.TabIndex = 20;
            this.btnIzdavanje.Text = "Izdavanje";
            this.btnIzdavanje.UseVisualStyleBackColor = true;
            this.btnIzdavanje.Click += new System.EventHandler(this.btnIzdavanje_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtKnjiga);
            this.panel1.Controls.Add(this.btnNaslovKnjige);
            this.panel1.Controls.Add(this.txtImePisca);
            this.panel1.Controls.Add(this.btnPisca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(135, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 126);
            this.panel1.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pretrazivanje";
            // 
            // btnUserPass
            // 
            this.btnUserPass.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUserPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserPass.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPass.Location = new System.Drawing.Point(17, 396);
            this.btnUserPass.Name = "btnUserPass";
            this.btnUserPass.Size = new System.Drawing.Size(165, 52);
            this.btnUserPass.TabIndex = 22;
            this.btnUserPass.Text = "Promeni Username/Password";
            this.ttPromena.SetToolTip(this.btnUserPass, "Mogucnost da se promeni username i password zaposlenog");
            this.btnUserPass.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(188, 396);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 52);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(332, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sektor";
            // 
            // btnUcitajZahteve
            // 
            this.btnUcitajZahteve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUcitajZahteve.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajZahteve.Location = new System.Drawing.Point(558, 157);
            this.btnUcitajZahteve.Name = "btnUcitajZahteve";
            this.btnUcitajZahteve.Size = new System.Drawing.Size(126, 35);
            this.btnUcitajZahteve.TabIndex = 26;
            this.btnUcitajZahteve.Text = "Ucitaj zahteve";
            this.btnUcitajZahteve.UseVisualStyleBackColor = true;
            this.btnUcitajZahteve.Click += new System.EventHandler(this.btnUcitajZahteve_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(493, 198);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 148);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.rbBeletristika);
            this.panel2.Controls.Add(this.rbRoman);
            this.panel2.Controls.Add(this.rbPublicistika);
            this.panel2.Controls.Add(this.rbDomaciAutori);
            this.panel2.Controls.Add(this.btnZanr);
            this.panel2.Controls.Add(this.rbPsihologija);
            this.panel2.Controls.Add(this.rbDecjeKnjige);
            this.panel2.Controls.Add(this.rbKlasici);
            this.panel2.Controls.Add(this.rbPoezija);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(400, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 126);
            this.panel2.TabIndex = 29;
            // 
            // btnZanr
            // 
            this.btnZanr.BackColor = System.Drawing.Color.LightSalmon;
            this.btnZanr.BackgroundImage = global::Library.Properties.Resources.find;
            this.btnZanr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZanr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZanr.Location = new System.Drawing.Point(225, 45);
            this.btnZanr.Name = "btnZanr";
            this.btnZanr.Size = new System.Drawing.Size(75, 55);
            this.btnZanr.TabIndex = 12;
            this.btnZanr.UseVisualStyleBackColor = false;
            this.btnZanr.Click += new System.EventHandler(this.btnZanr_Click);
            // 
            // btnSveKnjige
            // 
            this.btnSveKnjige.BackgroundImage = global::Library.Properties.Resources.knjige;
            this.btnSveKnjige.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSveKnjige.Location = new System.Drawing.Point(17, 14);
            this.btnSveKnjige.Name = "btnSveKnjige";
            this.btnSveKnjige.Size = new System.Drawing.Size(112, 124);
            this.btnSveKnjige.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSveKnjige, "Dugme koje obezbedjuje prikaz svih knjiga");
            this.btnSveKnjige.UseVisualStyleBackColor = true;
            this.btnSveKnjige.Click += new System.EventHandler(this.btnSveKnjige_Click);
            // 
            // FormZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(759, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnUcitajZahteve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUserPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIzdavanje);
            this.Controls.Add(this.cbClanovi);
            this.Controls.Add(this.btnClanovi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSveKnjige);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormZaposleni";
            this.Load += new System.EventHandler(this.FormZaposleni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnUserPass;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUcitajZahteve;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolTip ttPromena;
        private System.Windows.Forms.Panel panel2;
    }
}