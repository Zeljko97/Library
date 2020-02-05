namespace Library
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSveKnjige = new System.Windows.Forms.Button();
            this.btnSviZaposleni = new System.Windows.Forms.Button();
            this.btnSviKorisnici = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDodajZaposleni = new System.Windows.Forms.Button();
            this.btnObrisiZaposleni = new System.Windows.Forms.Button();
            this.btnResetujPassword = new System.Windows.Forms.Button();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.btnAzurirajKnjigu = new System.Windows.Forms.Button();
            this.btnObrisiKnjigu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.btnObrisiClana = new System.Windows.Forms.Button();
            this.btnAzurirajClana = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 46);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(315, 246);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnObrisiKnjigu);
            this.panel1.Controls.Add(this.btnAzurirajKnjigu);
            this.panel1.Controls.Add(this.btnDodajKnjigu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnSveKnjige);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 307);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnSveKnjige
            // 
            this.btnSveKnjige.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSveKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSveKnjige.Location = new System.Drawing.Point(3, 8);
            this.btnSveKnjige.Name = "btnSveKnjige";
            this.btnSveKnjige.Size = new System.Drawing.Size(101, 32);
            this.btnSveKnjige.TabIndex = 0;
            this.btnSveKnjige.Text = "Knjige";
            this.btnSveKnjige.UseVisualStyleBackColor = true;
            this.btnSveKnjige.Click += new System.EventHandler(this.btnSveKnjige_Click);
            // 
            // btnSviZaposleni
            // 
            this.btnSviZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSviZaposleni.Location = new System.Drawing.Point(12, 10);
            this.btnSviZaposleni.Name = "btnSviZaposleni";
            this.btnSviZaposleni.Size = new System.Drawing.Size(105, 28);
            this.btnSviZaposleni.TabIndex = 2;
            this.btnSviZaposleni.Text = "Svi Zaposleni";
            this.btnSviZaposleni.UseVisualStyleBackColor = true;
            this.btnSviZaposleni.Click += new System.EventHandler(this.btnSviZaposleni_Click);
            // 
            // btnSviKorisnici
            // 
            this.btnSviKorisnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSviKorisnici.Location = new System.Drawing.Point(3, 3);
            this.btnSviKorisnici.Name = "btnSviKorisnici";
            this.btnSviKorisnici.Size = new System.Drawing.Size(101, 37);
            this.btnSviKorisnici.TabIndex = 3;
            this.btnSviKorisnici.Text = "Svi Korisnici";
            this.btnSviKorisnici.UseVisualStyleBackColor = true;
            this.btnSviKorisnici.Click += new System.EventHandler(this.btnSviKorisnici_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(958, 330);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(161, 37);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnResetujPassword);
            this.panel2.Controls.Add(this.btnObrisiZaposleni);
            this.panel2.Controls.Add(this.btnDodajZaposleni);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.btnSviZaposleni);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(550, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 307);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Location = new System.Drawing.Point(12, 48);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.Size = new System.Drawing.Size(545, 246);
            this.dataGridView2.TabIndex = 3;
            // 
            // btnDodajZaposleni
            // 
            this.btnDodajZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajZaposleni.Location = new System.Drawing.Point(123, 10);
            this.btnDodajZaposleni.Name = "btnDodajZaposleni";
            this.btnDodajZaposleni.Size = new System.Drawing.Size(156, 28);
            this.btnDodajZaposleni.TabIndex = 4;
            this.btnDodajZaposleni.Text = "Dodaj Zaposlenog";
            this.btnDodajZaposleni.UseVisualStyleBackColor = true;
            this.btnDodajZaposleni.Click += new System.EventHandler(this.btnDodajZaposleni_Click);
            // 
            // btnObrisiZaposleni
            // 
            this.btnObrisiZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiZaposleni.Location = new System.Drawing.Point(285, 10);
            this.btnObrisiZaposleni.Name = "btnObrisiZaposleni";
            this.btnObrisiZaposleni.Size = new System.Drawing.Size(137, 28);
            this.btnObrisiZaposleni.TabIndex = 5;
            this.btnObrisiZaposleni.Text = "Obrisi zaposlenog";
            this.btnObrisiZaposleni.UseVisualStyleBackColor = true;
            this.btnObrisiZaposleni.Click += new System.EventHandler(this.btnObrisiZaposleni_Click);
            // 
            // btnResetujPassword
            // 
            this.btnResetujPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetujPassword.Location = new System.Drawing.Point(428, 10);
            this.btnResetujPassword.Name = "btnResetujPassword";
            this.btnResetujPassword.Size = new System.Drawing.Size(129, 28);
            this.btnResetujPassword.TabIndex = 6;
            this.btnResetujPassword.Text = "Resetuj password";
            this.btnResetujPassword.UseVisualStyleBackColor = true;
            this.btnResetujPassword.Click += new System.EventHandler(this.btnResetujPassword_Click);
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKnjigu.Location = new System.Drawing.Point(110, 8);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(101, 32);
            this.btnDodajKnjigu.TabIndex = 7;
            this.btnDodajKnjigu.Text = "Dodaj knjigu";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            this.btnDodajKnjigu.Click += new System.EventHandler(this.btnDodajKnjigu_Click);
            // 
            // btnAzurirajKnjigu
            // 
            this.btnAzurirajKnjigu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAzurirajKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajKnjigu.Location = new System.Drawing.Point(217, 9);
            this.btnAzurirajKnjigu.Name = "btnAzurirajKnjigu";
            this.btnAzurirajKnjigu.Size = new System.Drawing.Size(101, 32);
            this.btnAzurirajKnjigu.TabIndex = 8;
            this.btnAzurirajKnjigu.Text = "Azuriraj knjigu";
            this.btnAzurirajKnjigu.UseVisualStyleBackColor = true;
            this.btnAzurirajKnjigu.Click += new System.EventHandler(this.btnAzurirajKnjigu_Click);
            // 
            // btnObrisiKnjigu
            // 
            this.btnObrisiKnjigu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObrisiKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiKnjigu.Location = new System.Drawing.Point(324, 9);
            this.btnObrisiKnjigu.Name = "btnObrisiKnjigu";
            this.btnObrisiKnjigu.Size = new System.Drawing.Size(101, 32);
            this.btnObrisiKnjigu.TabIndex = 9;
            this.btnObrisiKnjigu.Text = "Obrisi knjigu";
            this.btnObrisiKnjigu.UseVisualStyleBackColor = true;
            this.btnObrisiKnjigu.Click += new System.EventHandler(this.btnObrisiKnjigu_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.btnAzurirajClana);
            this.panel3.Controls.Add(this.btnObrisiClana);
            this.panel3.Controls.Add(this.btnDodajClana);
            this.panel3.Controls.Add(this.btnSviKorisnici);
            this.panel3.Location = new System.Drawing.Point(12, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 260);
            this.panel3.TabIndex = 6;
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajClana.Location = new System.Drawing.Point(110, 3);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(101, 37);
            this.btnDodajClana.TabIndex = 4;
            this.btnDodajClana.Text = "Nov clan";
            this.btnDodajClana.UseVisualStyleBackColor = true;
            this.btnDodajClana.Click += new System.EventHandler(this.btnDodajClana_Click);
            // 
            // btnObrisiClana
            // 
            this.btnObrisiClana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiClana.Location = new System.Drawing.Point(217, 3);
            this.btnObrisiClana.Name = "btnObrisiClana";
            this.btnObrisiClana.Size = new System.Drawing.Size(101, 37);
            this.btnObrisiClana.TabIndex = 5;
            this.btnObrisiClana.Text = "Obrisi clana";
            this.btnObrisiClana.UseVisualStyleBackColor = true;
            this.btnObrisiClana.Click += new System.EventHandler(this.btnObrisiClana_Click);
            // 
            // btnAzurirajClana
            // 
            this.btnAzurirajClana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajClana.Location = new System.Drawing.Point(324, 3);
            this.btnAzurirajClana.Name = "btnAzurirajClana";
            this.btnAzurirajClana.Size = new System.Drawing.Size(121, 37);
            this.btnAzurirajClana.TabIndex = 6;
            this.btnAzurirajClana.Text = "Azuriranje clana";
            this.btnAzurirajClana.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Location = new System.Drawing.Point(3, 46);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.ShowCellToolTips = false;
            this.dataGridView3.Size = new System.Drawing.Size(512, 207);
            this.dataGridView3.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(534, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 186);
            this.listBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Iznajmljene knjige";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(347, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 141);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1135, 597);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSveKnjige;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSviKorisnici;
        private System.Windows.Forms.Button btnSviZaposleni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnResetujPassword;
        private System.Windows.Forms.Button btnObrisiZaposleni;
        private System.Windows.Forms.Button btnDodajZaposleni;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.Button btnAzurirajKnjigu;
        private System.Windows.Forms.Button btnObrisiKnjigu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnAzurirajClana;
        private System.Windows.Forms.Button btnObrisiClana;
        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
    }
}