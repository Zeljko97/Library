using System;
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
    public partial class FormClanBiblioteke : Form
    {
        public FormClanBiblioteke()
        {
            InitializeComponent();
        }

        private void FormClanBiblioteke_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            Text = FormClanLogIn.trClan.ime + " " + FormClanLogIn.trClan.prezime;
            label1.Text = "Ime: " + FormClanLogIn.trClan.ime;
            label2.Text = "Prezime: " + FormClanLogIn.trClan.prezime;
            label3.Text = "Zanimanje: " + FormClanLogIn.trClan.zanimanje;
            label4.Text = "Adresa: " + FormClanLogIn.trClan.adresa;
            label5.Text = "Broj telefona: " + FormClanLogIn.trClan.brojTelefona;
            label6.Text = "Broj licne karte:" + FormClanLogIn.trClan.brojLicneKarte;
            label13.Text = "Broj clanske karte:" + FormClanLogIn.trClan.brojClanskeKarte;
            //var izn = database.GetCollection<Clan>("clanovi");
            //MongoCursor<Clan> clan = izn.Find(Query.EQ("Id", FormClanLogIn.trClan.Id));
            //foreach (Clan c in clan)
            //{

            //}


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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string naslov = (string)dataGridView1[1, index].Value;
            if (index < 0)
            {
                lblNaslov.Visible = false;
                lblAutor.Visible = false;
                lblIzdavac.Visible = false;
                lblBrojPrimeraka.Visible = false;
                lblBrojStranica.Visible = false;
                lblPovez.Visible = false;
                lblZanr.Visible = false;
                lblNaslov.Text = "";
                lblAutor.Text = "";
                lblIzdavac.Text = "";
                lblBrojStranica.Text = "";
                lblBrojPrimeraka.Text = "";
                lblPovez.Text = "";
                lblZanr.Text = "";
            }
            else
            {
                lblNaslov.Text = "Naslov: " + (string)dataGridView1[1,index].Value;
                lblAutor.Text = "Autor: " + (string)dataGridView1[2, index].Value;
                lblZanr.Text = "Zanr: " + (string)dataGridView1[3, index].Value;
                lblIzdavac.Text = "Izdavac: " + (string)dataGridView1[4, index].Value;
                lblPovez.Text = "Povez: " + (string)dataGridView1[5, index].Value;
                lblBrojStranica.Text = "Broj stranica: " + (string)dataGridView1[6, index].Value.ToString();
                lblBrojPrimeraka.Text = "Broj primeraka: " + (string)dataGridView1[7, index].Value.ToString();
                lblNaslov.Visible = true;
                lblAutor.Visible = true;
                lblIzdavac.Visible = true;
                lblBrojPrimeraka.Visible = true;
                lblBrojStranica.Visible = true;
                lblPovez.Visible = true;
                lblZanr.Visible = true;

                pictureBox1.Image = Image.FromFile("../../Resources/" + naslov + ".jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string naslov = (string)dataGridView1[1, index].Value;
            if (index < 0)
            {
                lblNaslov.Visible = false;
                lblAutor.Visible = false;
                lblIzdavac.Visible = false;
                lblBrojPrimeraka.Visible = false;
                lblBrojStranica.Visible = false;
                lblPovez.Visible = false;
                lblZanr.Visible = false;
                lblNaslov.Text = "";
                lblAutor.Text = "";
                lblIzdavac.Text = "";
                lblBrojStranica.Text = "";
                lblBrojPrimeraka.Text = "";
                lblPovez.Text = "";
                lblZanr.Text = "";
            }
            else
            {
                lblNaslov.Text = "Naslov: " + (string)dataGridView1[1, index].Value;
                lblAutor.Text = "Autor: " + (string)dataGridView1[2, index].Value;
                lblZanr.Text = "Zanr: " + (string)dataGridView1[3, index].Value;
                lblIzdavac.Text = "Izdavac: " + (string)dataGridView1[4, index].Value;
                lblPovez.Text = "Povez: " + (string)dataGridView1[5, index].Value;
                lblBrojStranica.Text = "Broj stranica: " + (string)dataGridView1[6, index].Value.ToString();
                lblBrojPrimeraka.Text = "Broj primeraka: " + (string)dataGridView1[7, index].Value.ToString();
                lblNaslov.Visible = true;
                lblAutor.Visible = true;
                lblIzdavac.Visible = true;
                lblBrojPrimeraka.Visible = true;
                lblBrojStranica.Visible = true;
                lblPovez.Visible = true;
                lblZanr.Visible = true;

                pictureBox1.Image = Image.FromFile("../../Resources/" + naslov + ".jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnNaslovKnjige_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKnjiga.Text))
            {
                MessageBox.Show("Niste uneli naslov knjige da biste uspesno pretrazili bazu.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var db = server.GetDatabase("Biblioteka");

                var collection = db.GetCollection<Knjiga>("knjige");

                List<Knjiga> knjige = new List<Knjiga>();
                foreach (Knjiga k in collection.Find(Query.EQ("naslov", txtKnjiga.Text)))
                {
                    knjige.Add(k);
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = knjige;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Sektor"].Visible = false;

            }
        }

        private void btnPisca_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            var collection = db.GetCollection<Knjiga>("knjige");

            List<Knjiga> knjige = new List<Knjiga>();

            foreach (Knjiga k in collection.Find(Query.EQ("autor", txtImePisca.Text)))
            {
                knjige.Add(k);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = knjige;
        }

        private void btnZanr_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            var collection = db.GetCollection<Knjiga>("knjige");

            List<Knjiga> knjige = new List<Knjiga>();
            if (rbSve.Checked==true)
            {
                foreach (Knjiga k in collection.FindAll())
                {
                    knjige.Add(k);
                }
            }
            else if (rbRoman.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("zanr", "roman")))
                {
                    knjige.Add(k);
                }
            }
            else if (rbPublicistika.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("zanr", "publicistika")))
                {
                    knjige.Add(k);
                }
            }
            else if (rbDecjeKnjige.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("zanr", "decja knjiga")))
                {
                    knjige.Add(k);
                }
                foreach (Knjiga k in collection.Find(Query.EQ("oznake", "decja knjiga")))
                {
                    knjige.Add(k);
                }
            }
            else if (rbDomaciAutori.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("oznake", "domaci autor")))
                {
                    knjige.Add(k);
                }
            }
            else if (rbKlasici.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("oznake", "klasika")))
                {
                    knjige.Add(k);
                }
            }
            else if (rbPoezija.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("oznake", "poezija")))
                {
                    knjige.Add(k);
                }
            }
            else if (rbPsihologija.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("oznake", "psihologija")))
                {
                    knjige.Add(k);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = knjige;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["zanr"].Visible = false;
            dataGridView1.Columns["izdavac"].Visible = false;
            dataGridView1.Columns["povez"].Visible = false;
            dataGridView1.Columns["brojStrana"].Visible = false;
            dataGridView1.Columns["brojPrimeraka"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClanChangePassword fccp = new FormClanChangePassword();
            fccp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClanLogIn fcli = new FormClanLogIn();
            fcli.Show();
        }

        private void btnIznajmi_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collectionZahtevi = database.GetCollection<Zahtev>("zahtevi");


            int index = dataGridView1.CurrentRow.Index;
            Zahtev zahtev = new Zahtev { knjiga = (string)dataGridView1[1, index].Value, brojClanskeKarte = Int32.Parse(FormClanLogIn.trClan.brojClanskeKarte) };
            collectionZahtevi.Insert(zahtev);

            MessageBox.Show("Poslali ste zahtev za knjigom. ");


        }

        private void btnVratiKnjigu_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Clan>("clanovi");
         
            var knjigeColl = database.GetCollection<Knjiga>("knjige");

            Clan clan = FormClanLogIn.trClan;

      /*    foreach(MongoDBRef k in clan.iznajmljeneKnjige.ToList()  )
          {
              Knjiga knjiga = database.FetchDBRefAs<Knjiga>(k);
              MessageBox.Show(knjiga.naslov);
          }
            */

            foreach(Knjiga k in knjigeColl.FindAll())
            {
               for(int i = 0;i<clan.iznajmljeneKnjige.Count;i++)
               {
                   if (k.Id == clan.iznajmljeneKnjige[i].Id)
                       list.Items.Add(k.naslov);
               }
            }
           /* for(int i = 0;i<clan.iznajmljeneKnjige.Count;i++)
            {
                MessageBox.Show(clan.iznajmljeneKnjige[i].ToString());
            }*/
            


      


        }
    }
}
