﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB.Driver;

using Library.Entiteti;

namespace Library
{
    public partial class Admin : Form
    {
        public static Knjiga azuriranje;
        public Admin()
        {
            InitializeComponent();
            azuriranje = null;
        }
        #region Zaposleni
        private void btnSviZaposleni_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Zaposleni>("zaposleni");

            MongoCursor<Zaposleni> zaposleni = collection.FindAll();
            List<Zaposleni> listaZaposleni = new List<Zaposleni>();

            foreach (Zaposleni k in zaposleni.ToArray<Zaposleni>())
            {
                listaZaposleni.Add(k);
            }
            dataGridView2.DataSource = listaZaposleni;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["username"].Visible = false;
            dataGridView2.Columns["password"].Visible = false;
        }
        private void btnDodajZaposleni_Click(object sender, EventArgs e)
        {
            FormDodajZaposlenog fdz = new FormDodajZaposlenog();
            fdz.Show();
        }
        private void btnObrisiZaposleni_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index;
            if (index < 0)
            {
                MessageBox.Show("Nijedan zaposleni nije selektovan.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Ime = (string)dataGridView2[1, index].Value;
                string Prezime = (string)dataGridView2[2, index].Value;

                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Zaposleni>("zaposleni");
                //MongoCursor<Zaposleni> zaposleni = collection.FindAll();
                var query = Query.And(Query.EQ("ime", Ime),
                           Query.EQ("prezime", Prezime)
                           );

                collection.Remove(query);
                MessageBox.Show(Ime + " " + Prezime + " je uspesno obrisan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnResetujPassword_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index;
            if (index < 0)
            {
                MessageBox.Show("Nijedan zaposleni nije selektovan.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Ime = (string)dataGridView2[1, index].Value;
                string Prezime = (string)dataGridView2[2, index].Value;

                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Zaposleni>("zaposleni");
                MongoCursor<Zaposleni> zaposleni = collection.FindAll();
                var query = Query.And(Query.EQ("ime", Ime),
                           Query.EQ("prezime", Prezime)
                           );
                var update = MongoDB.Driver.Builders.Update.Set("password", "mongo");
                collection.Update(query, update);
                MessageBox.Show("Password korisnika " + Ime + " " + Prezime + " je uspesno resetovan.", "Uspesno resetovan password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSortPrezime_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Zaposleni>("zaposleni");

            List<Zaposleni> listaZaposleni = new List<Zaposleni>();

            foreach (Zaposleni k in collection.FindAll().SetSortOrder(SortBy.Descending("prezime"))) //ILI: //collection.FindAll().SetSortOrder(SortBy.Descending("prezime"));
            {
                listaZaposleni.Add(k);
            }
            dataGridView2.DataSource = listaZaposleni;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["username"].Visible = false;
            dataGridView2.Columns["password"].Visible = false;
        }
        private void SortRadniStaz_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Zaposleni>("zaposleni");

            List<Zaposleni> listaZaposleni = new List<Zaposleni>();

            foreach (Zaposleni k in collection.FindAll().SetSortOrder(SortBy.Descending("radni_staz"))) //ILI: //collection.FindAll().SetSortOrder(SortBy.Descending("prezime"));
            {
                listaZaposleni.Add(k);
            }
            dataGridView2.DataSource = listaZaposleni;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["username"].Visible = false;
            dataGridView2.Columns["password"].Visible = false;
        }
        private void btnSortIme_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");
            var collection = database.GetCollection<Zaposleni>("zaposleni");
            List<Zaposleni> listaZaposleni = new List<Zaposleni>();

            foreach (Zaposleni k in collection.FindAll().SetSortOrder(SortBy.Descending("ime")))
            {
                listaZaposleni.Add(k);
            }
            dataGridView2.DataSource = listaZaposleni;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["username"].Visible = false;
            dataGridView2.Columns["password"].Visible = false;
        }


        #endregion

        #region Knjige
        private void btnSveKnjige_Click(object sender, EventArgs e)
        {
            Knjige();
        }
        public void Knjige()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Knjiga>("knjige");

            MongoCursor<Knjiga> knjige = collection.FindAll();

            List<Knjiga> listaKnjiga = new List<Knjiga>();

            foreach (Knjiga k in knjige.ToArray<Knjiga>())
            {
                listaKnjiga.Add(k);
            }
            dataGridView1.DataSource = listaKnjiga;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["zanr"].Visible = false;
            dataGridView1.Columns["izdavac"].Visible = false;
            dataGridView1.Columns["povez"].Visible = false;
            dataGridView1.Columns["brojStrana"].Visible = false;
            dataGridView1.Columns["brojPrimeraka"].Visible = false;
        }
        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            FormDodajKnjigu fdk = new FormDodajKnjigu();
            fdk.Show();
        }
        private void btnAzurirajKnjigu_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index < 0)
            {
                MessageBox.Show("Nijedna knjiga nije selektovana", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Naslov = (string)dataGridView1[1, index].Value;
                string Autor = (string)dataGridView1[2, index].Value;

                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Knjiga>("knjige");

                //MongoCursor<Zaposleni> zaposleni = collection.FindAll();
                var query = Query.And(Query.EQ("naslov", Naslov),
                           Query.EQ("autor", Autor)
                           );
                azuriranje = collection.FindOne(query);
                FormAzurirajKnjigu fak = new FormAzurirajKnjigu();
                fak.Show();
            }
        }
        private void btnObrisiKnjigu_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index < 0)
            {
                MessageBox.Show("Nijedna knjiga nije selektovana", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Naslov = (string)dataGridView1[1, index].Value;
                string Autor = (string)dataGridView1[2, index].Value;

                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Knjiga>("knjige");

                //Dal bi moglo da se izvude ObjectID? mozda bi bilo efikasnije 
                var query = Query.And(Query.EQ("naslov", Naslov),
                           Query.EQ("autor", Autor)
                           );
                collection.Remove(query);
                MessageBox.Show("Knjiga koja nosi naslov '" + Naslov + "' autora: " + Autor + "  je uspesno obrisan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Knjige();
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string naslov = (string)dataGridView1[1, index].Value;
            if (index < 0)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
            }
            else
            {
                label1.Text = "Zanr: " + (string)dataGridView1[3, index].Value;
                label2.Text = "Izdavac: " + (string)dataGridView1[4, index].Value;
                label3.Text = "Povez: " + (string)dataGridView1[5, index].Value;
                label4.Text = "Broj stranica: " + (string)dataGridView1[6, index].Value.ToString();
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;

                pbKnjiga.Image = Image.FromFile("../../Resources/" + naslov + ".jpg");
                pbKnjiga.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        #endregion

        #region Korisnici
        private void btnSviKorisnici_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");
            var collection = database.GetCollection<Clan>("clanovi");

            MongoCursor<Clan> clanovi = collection.FindAll();

            List<Clan> listaClanova = new List<Clan>();

            foreach (Clan k in clanovi.ToArray<Clan>())
            {
                listaClanova.Add(k);
            }
            dataGridView3.DataSource = listaClanova;
            dataGridView3.Columns["Id"].Visible = false;
            dataGridView3.Columns["username"].Visible = false;
            dataGridView3.Columns["password"].Visible = false;
            //dataGridView3.Columns["Id"].Visible = false;
        }
        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            FormDodavanjeClana fcd = new FormDodavanjeClana();
            fcd.Show();
        }
        private void btnObrisiClana_Click(object sender, EventArgs e)
        {
            int index = dataGridView3.CurrentRow.Index;
            if (index < 0)
            {
                MessageBox.Show("Nijedna knjiga nije selektovana", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Broj = Convert.ToInt32(dataGridView3[1, index].Value);
                //zbog stampanja samo
                string ime = (string)dataGridView3[2, index].Value;
                string prezime = (string)dataGridView3[3, index].Value;
                /*****/
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Clan>("clanovi");

                //Dal bi moglo da se izvude ObjectID? mozda bi bilo efikasnije 
                var query = Query.EQ("brojClanskeKarte", Broj);
                collection.Remove(query);
                MessageBox.Show("Clan " + ime + " " + prezime + " je uspesno obrisan..", "Uspesno brisanje clana biblioteke", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnSortBrojStranica_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");
            var collection = database.GetCollection<Knjiga>("knjige");
            List<Knjiga> listaZaposleni = new List<Knjiga>();

            foreach (Knjiga k in collection.FindAll().SetSortOrder(SortBy.Descending("brojStrana")))
            {
                listaZaposleni.Add(k);
            }
            dataGridView1.DataSource = listaZaposleni;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["zanr"].Visible = true;
            dataGridView1.Columns["izdavac"].Visible = false;
            dataGridView1.Columns["povez"].Visible = false;
            dataGridView1.Columns["brojStrana"].Visible = false;
            dataGridView1.Columns["brojPrimeraka"].Visible = false;
        }

        


    }
}