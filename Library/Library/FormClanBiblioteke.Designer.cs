namespace Library
{
    partial class FormClanBiblioteke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClanBiblioteke));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVratiKnjigu = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBrojStranica = new System.Windows.Forms.Label();
            this.lblBrojPrimeraka = new System.Windows.Forms.Label();
            this.lblPovez = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIznajmi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKnjiga = new System.Windows.Forms.TextBox();
            this.btnNaslovKnjige = new System.Windows.Forms.Button();
            this.txtImePisca = new System.Windows.Forms.TextBox();
            this.btnPisca = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.rbSve = new System.Windows.Forms.RadioButton();
            this.rbPoezija = new System.Windows.Forms.RadioButton();
            this.rbKlasici = new System.Windows.Forms.RadioButton();
            this.rbDecjeKnjige = new System.Windows.Forms.RadioButton();
            this.rbPsihologija = new System.Windows.Forms.RadioButton();
            this.btnZanr = new System.Windows.Forms.Button();
            this.rbDomaciAutori = new System.Windows.Forms.RadioButton();
            this.rbPublicistika = new System.Windows.Forms.RadioButton();
            this.rbBeletristika = new System.Windows.Forms.RadioButton();
            this.rbRoman = new System.Windows.Forms.RadioButton();
            this.ttSearch = new System.Windows.Forms.ToolTip(this.components);
            this.ttImePisca = new System.Windows.Forms.ToolTip(this.components);
            this.ttNaslovKnjige = new System.Windows.Forms.ToolTip(this.components);
            this.ttIznajmi = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnVratiKnjigu);
            this.panel1.Controls.Add(this.list);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 236);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft MHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(3, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 26);
            this.label13.TabIndex = 24;
            this.label13.Text = "label13";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(532, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Promeni username ili password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(532, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Log-out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVratiKnjigu
            // 
            this.btnVratiKnjigu.BackColor = System.Drawing.Color.Aquamarine;
            this.btnVratiKnjigu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVratiKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiKnjigu.Location = new System.Drawing.Point(532, 5);
            this.btnVratiKnjigu.Name = "btnVratiKnjigu";
            this.btnVratiKnjigu.Size = new System.Drawing.Size(108, 59);
            this.btnVratiKnjigu.TabIndex = 7;
            this.btnVratiKnjigu.Text = "Iznajmljene knjige";
            this.btnVratiKnjigu.UseVisualStyleBackColor = false;
            this.btnVratiKnjigu.Click += new System.EventHandler(this.btnVratiKnjigu_Click);
            // 
            // list
            // 
            this.list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(352, 4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(174, 199);
            this.list.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(20, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Knjige koje nudimo za iznajmljivanje:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(24, 299);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(331, 296);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.BackColor = System.Drawing.Color.Transparent;
            this.lblIzdavac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblIzdavac.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzdavac.ForeColor = System.Drawing.Color.Black;
            this.lblIzdavac.Location = new System.Drawing.Point(12, 106);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(0, 18);
            this.lblIzdavac.TabIndex = 13;
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.BackColor = System.Drawing.Color.Transparent;
            this.lblZanr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblZanr.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZanr.ForeColor = System.Drawing.Color.Black;
            this.lblZanr.Location = new System.Drawing.Point(12, 77);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(0, 18);
            this.lblZanr.TabIndex = 12;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblAutor.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.Black;
            this.lblAutor.Location = new System.Drawing.Point(12, 50);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(0, 18);
            this.lblAutor.TabIndex = 11;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNaslov.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.Black;
            this.lblNaslov.Location = new System.Drawing.Point(12, 22);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(0, 18);
            this.lblNaslov.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblBrojStranica);
            this.panel2.Controls.Add(this.lblBrojPrimeraka);
            this.panel2.Controls.Add(this.lblPovez);
            this.panel2.Controls.Add(this.lblNaslov);
            this.panel2.Controls.Add(this.lblAutor);
            this.panel2.Controls.Add(this.lblZanr);
            this.panel2.Controls.Add(this.lblIzdavac);
            this.panel2.Location = new System.Drawing.Point(701, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 225);
            this.panel2.TabIndex = 16;
            // 
            // lblBrojStranica
            // 
            this.lblBrojStranica.AutoSize = true;
            this.lblBrojStranica.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojStranica.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBrojStranica.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojStranica.ForeColor = System.Drawing.Color.Black;
            this.lblBrojStranica.Location = new System.Drawing.Point(12, 191);
            this.lblBrojStranica.Name = "lblBrojStranica";
            this.lblBrojStranica.Size = new System.Drawing.Size(0, 18);
            this.lblBrojStranica.TabIndex = 16;
            // 
            // lblBrojPrimeraka
            // 
            this.lblBrojPrimeraka.AutoSize = true;
            this.lblBrojPrimeraka.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojPrimeraka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBrojPrimeraka.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPrimeraka.ForeColor = System.Drawing.Color.Black;
            this.lblBrojPrimeraka.Location = new System.Drawing.Point(12, 162);
            this.lblBrojPrimeraka.Name = "lblBrojPrimeraka";
            this.lblBrojPrimeraka.Size = new System.Drawing.Size(0, 18);
            this.lblBrojPrimeraka.TabIndex = 15;
            // 
            // lblPovez
            // 
            this.lblPovez.AutoSize = true;
            this.lblPovez.BackColor = System.Drawing.Color.Transparent;
            this.lblPovez.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPovez.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPovez.ForeColor = System.Drawing.Color.Black;
            this.lblPovez.Location = new System.Drawing.Point(12, 134);
            this.lblPovez.Name = "lblPovez";
            this.lblPovez.Size = new System.Drawing.Size(0, 18);
            this.lblPovez.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Library.Properties.Resources.Books;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(759, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 239);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnIznajmi
            // 
            this.btnIznajmi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIznajmi.Location = new System.Drawing.Point(701, 506);
            this.btnIznajmi.Name = "btnIznajmi";
            this.btnIznajmi.Size = new System.Drawing.Size(113, 35);
            this.btnIznajmi.TabIndex = 17;
            this.btnIznajmi.Text = "Iznajmi";
            this.ttIznajmi.SetToolTip(this.btnIznajmi, "Iznajmljivanje selektovane knjige.");
            this.btnIznajmi.UseVisualStyleBackColor = true;
            this.btnIznajmi.Click += new System.EventHandler(this.btnIznajmi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Klikom vrsite selekciju knjige koju potencijalno zelite iznajmiti";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtKnjiga);
            this.panel3.Controls.Add(this.btnNaslovKnjige);
            this.panel3.Controls.Add(this.txtImePisca);
            this.panel3.Controls.Add(this.btnPisca);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(373, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 108);
            this.panel3.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pretrazivanje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Naslov knjige:";
            // 
            // txtKnjiga
            // 
            this.txtKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKnjiga.Location = new System.Drawing.Point(15, 43);
            this.txtKnjiga.Name = "txtKnjiga";
            this.txtKnjiga.Size = new System.Drawing.Size(109, 21);
            this.txtKnjiga.TabIndex = 6;
            // 
            // btnNaslovKnjige
            // 
            this.btnNaslovKnjige.BackColor = System.Drawing.Color.Bisque;
            this.btnNaslovKnjige.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaslovKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaslovKnjige.Location = new System.Drawing.Point(15, 70);
            this.btnNaslovKnjige.Name = "btnNaslovKnjige";
            this.btnNaslovKnjige.Size = new System.Drawing.Size(109, 28);
            this.btnNaslovKnjige.TabIndex = 7;
            this.btnNaslovKnjige.Text = "Pronadji";
            this.ttNaslovKnjige.SetToolTip(this.btnNaslovKnjige, "Pretrazivanje biblioteke za pun naslov knjige.");
            this.btnNaslovKnjige.UseVisualStyleBackColor = false;
            this.btnNaslovKnjige.Click += new System.EventHandler(this.btnNaslovKnjige_Click);
            // 
            // txtImePisca
            // 
            this.txtImePisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePisca.Location = new System.Drawing.Point(166, 43);
            this.txtImePisca.Name = "txtImePisca";
            this.txtImePisca.Size = new System.Drawing.Size(114, 21);
            this.txtImePisca.TabIndex = 2;
            // 
            // btnPisca
            // 
            this.btnPisca.BackColor = System.Drawing.Color.Bisque;
            this.btnPisca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPisca.Location = new System.Drawing.Point(166, 70);
            this.btnPisca.Name = "btnPisca";
            this.btnPisca.Size = new System.Drawing.Size(114, 28);
            this.btnPisca.TabIndex = 3;
            this.btnPisca.Text = "Pronadji";
            this.ttImePisca.SetToolTip(this.btnPisca, "Pretrazivanje knjiga na osnovu imena i prezimena autora. Tako da vodite racuna da" +
        " unesete puno ime i prezime.");
            this.btnPisca.UseVisualStyleBackColor = false;
            this.btnPisca.Click += new System.EventHandler(this.btnPisca_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(163, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ime pisca:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.rbSve);
            this.panel4.Controls.Add(this.rbPoezija);
            this.panel4.Controls.Add(this.rbKlasici);
            this.panel4.Controls.Add(this.rbDecjeKnjige);
            this.panel4.Controls.Add(this.rbPsihologija);
            this.panel4.Controls.Add(this.btnZanr);
            this.panel4.Controls.Add(this.rbDomaciAutori);
            this.panel4.Controls.Add(this.rbPublicistika);
            this.panel4.Controls.Add(this.rbBeletristika);
            this.panel4.Controls.Add(this.rbRoman);
            this.panel4.Location = new System.Drawing.Point(373, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 217);
            this.panel4.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Po Zanru:";
            // 
            // rbSve
            // 
            this.rbSve.AutoSize = true;
            this.rbSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSve.Location = new System.Drawing.Point(6, 14);
            this.rbSve.Name = "rbSve";
            this.rbSve.Size = new System.Drawing.Size(85, 17);
            this.rbSve.TabIndex = 26;
            this.rbSve.TabStop = true;
            this.rbSve.Text = "Sve knjige";
            this.rbSve.UseVisualStyleBackColor = true;
            // 
            // rbPoezija
            // 
            this.rbPoezija.AutoSize = true;
            this.rbPoezija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPoezija.Location = new System.Drawing.Point(6, 194);
            this.rbPoezija.Name = "rbPoezija";
            this.rbPoezija.Size = new System.Drawing.Size(66, 17);
            this.rbPoezija.TabIndex = 25;
            this.rbPoezija.TabStop = true;
            this.rbPoezija.Text = "Poezija";
            this.rbPoezija.UseVisualStyleBackColor = true;
            // 
            // rbKlasici
            // 
            this.rbKlasici.AutoSize = true;
            this.rbKlasici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKlasici.Location = new System.Drawing.Point(5, 173);
            this.rbKlasici.Name = "rbKlasici";
            this.rbKlasici.Size = new System.Drawing.Size(62, 17);
            this.rbKlasici.TabIndex = 24;
            this.rbKlasici.TabStop = true;
            this.rbKlasici.Text = "Klasici";
            this.rbKlasici.UseVisualStyleBackColor = true;
            // 
            // rbDecjeKnjige
            // 
            this.rbDecjeKnjige.AutoSize = true;
            this.rbDecjeKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDecjeKnjige.Location = new System.Drawing.Point(5, 152);
            this.rbDecjeKnjige.Name = "rbDecjeKnjige";
            this.rbDecjeKnjige.Size = new System.Drawing.Size(96, 17);
            this.rbDecjeKnjige.TabIndex = 23;
            this.rbDecjeKnjige.TabStop = true;
            this.rbDecjeKnjige.Text = "Decje knjige";
            this.rbDecjeKnjige.UseVisualStyleBackColor = true;
            // 
            // rbPsihologija
            // 
            this.rbPsihologija.AutoSize = true;
            this.rbPsihologija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPsihologija.Location = new System.Drawing.Point(5, 131);
            this.rbPsihologija.Name = "rbPsihologija";
            this.rbPsihologija.Size = new System.Drawing.Size(86, 17);
            this.rbPsihologija.TabIndex = 22;
            this.rbPsihologija.TabStop = true;
            this.rbPsihologija.Text = "Psihologija";
            this.rbPsihologija.UseVisualStyleBackColor = true;
            // 
            // btnZanr
            // 
            this.btnZanr.BackgroundImage = global::Library.Properties.Resources.FindBook;
            this.btnZanr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZanr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZanr.Location = new System.Drawing.Point(156, 62);
            this.btnZanr.Name = "btnZanr";
            this.btnZanr.Size = new System.Drawing.Size(124, 102);
            this.btnZanr.TabIndex = 21;
            this.ttSearch.SetToolTip(this.btnZanr, "Pretrazivanje na osnovu zanra knjige.");
            this.btnZanr.UseVisualStyleBackColor = true;
            this.btnZanr.Click += new System.EventHandler(this.btnZanr_Click);
            // 
            // rbDomaciAutori
            // 
            this.rbDomaciAutori.AutoSize = true;
            this.rbDomaciAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDomaciAutori.Location = new System.Drawing.Point(5, 110);
            this.rbDomaciAutori.Name = "rbDomaciAutori";
            this.rbDomaciAutori.Size = new System.Drawing.Size(103, 17);
            this.rbDomaciAutori.TabIndex = 20;
            this.rbDomaciAutori.TabStop = true;
            this.rbDomaciAutori.Text = "Domaci autori";
            this.rbDomaciAutori.UseVisualStyleBackColor = true;
            // 
            // rbPublicistika
            // 
            this.rbPublicistika.AutoSize = true;
            this.rbPublicistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPublicistika.Location = new System.Drawing.Point(5, 89);
            this.rbPublicistika.Name = "rbPublicistika";
            this.rbPublicistika.Size = new System.Drawing.Size(90, 17);
            this.rbPublicistika.TabIndex = 19;
            this.rbPublicistika.TabStop = true;
            this.rbPublicistika.Text = "Publicistika";
            this.rbPublicistika.UseVisualStyleBackColor = true;
            // 
            // rbBeletristika
            // 
            this.rbBeletristika.AutoSize = true;
            this.rbBeletristika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBeletristika.Location = new System.Drawing.Point(5, 70);
            this.rbBeletristika.Name = "rbBeletristika";
            this.rbBeletristika.Size = new System.Drawing.Size(88, 17);
            this.rbBeletristika.TabIndex = 18;
            this.rbBeletristika.TabStop = true;
            this.rbBeletristika.Text = "Beletristika";
            this.rbBeletristika.UseVisualStyleBackColor = true;
            // 
            // rbRoman
            // 
            this.rbRoman.AutoSize = true;
            this.rbRoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRoman.Location = new System.Drawing.Point(4, 49);
            this.rbRoman.Name = "rbRoman";
            this.rbRoman.Size = new System.Drawing.Size(67, 17);
            this.rbRoman.TabIndex = 17;
            this.rbRoman.TabStop = true;
            this.rbRoman.Text = "Romani";
            this.rbRoman.UseVisualStyleBackColor = true;
            // 
            // FormClanBiblioteke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::Library.Properties.Resources.userBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 612);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnIznajmi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClanBiblioteke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormClanBiblioteke_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPovez;
        private System.Windows.Forms.Label lblBrojStranica;
        private System.Windows.Forms.Label lblBrojPrimeraka;
        private System.Windows.Forms.Button btnIznajmi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKnjiga;
        private System.Windows.Forms.Button btnNaslovKnjige;
        private System.Windows.Forms.TextBox txtImePisca;
        private System.Windows.Forms.Button btnPisca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbSve;
        private System.Windows.Forms.RadioButton rbPoezija;
        private System.Windows.Forms.RadioButton rbKlasici;
        private System.Windows.Forms.RadioButton rbDecjeKnjige;
        private System.Windows.Forms.RadioButton rbPsihologija;
        private System.Windows.Forms.Button btnZanr;
        private System.Windows.Forms.RadioButton rbDomaciAutori;
        private System.Windows.Forms.RadioButton rbPublicistika;
        private System.Windows.Forms.RadioButton rbBeletristika;
        private System.Windows.Forms.RadioButton rbRoman;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip ttIznajmi;
        private System.Windows.Forms.ToolTip ttNaslovKnjige;
        private System.Windows.Forms.ToolTip ttImePisca;
        private System.Windows.Forms.ToolTip ttSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVratiKnjigu;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
    }
}