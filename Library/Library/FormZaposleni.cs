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
    public partial class FormZaposleni : Form
    {
        public FormZaposleni()
        {
            InitializeComponent();
        }
        #region Knjige
        private void btnSveKnjige_Click(object sender, EventArgs e)
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
            dataGridView1.Columns["Sektor"].Visible = false;
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
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Sektor"].Visible = false;
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
        private void btnZanr_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            var collection = db.GetCollection<Knjiga>("knjige");

            List<Knjiga> knjige = new List<Knjiga>();

            if (rbRoman.Checked == true)
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
            dataGridView1.Columns["Sektor"].Visible = false;
        }
        #endregion
        private void btnIzdavanje_Click_1(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null || cbClanovi.SelectedItem == null)
            {
                MessageBox.Show("Izaberi knjigu i clana biblioteke");
                return;
            }
            int indexRow = dataGridView1.CurrentRow.Index;
            string knjiga = (string)dataGridView1[1, indexRow].Value;

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            
            var collectionClanovi = db.GetCollection<Clan>("clanovi");
            var collectionKnjige = db.GetCollection<Knjiga>("knjige");

          


           Clan clan1 =new Clan();
            foreach(Clan c in collectionClanovi.Find(Query.EQ("brojClanskeKarte", cbClanovi.SelectedItem.ToString())))
            {
                clan1 = c;
            }
            Knjiga knjiga1 = new Knjiga();
            foreach(Knjiga k in collectionKnjige.Find(Query.EQ("naslov", (string)dataGridView1[1,indexRow].Value)))
            {
                knjiga1 = k;
            }
            //////////////////

            if(knjiga1.brojPrimeraka < 1)
            {
                MessageBox.Show("Trenutno nema primeraka knjige u biblioteci.");
                return;
            }

            knjiga1.brojPrimeraka -= 1;

        //    clan1.iznajmljeneKnjige.Add(new MongoDBRef("iznajmljeneKnjige", knjiga1.Id));
            clan1.iznajmljeneKnjige.Add(knjiga1.Id);
            knjiga1.IzdataClanovima.Add(clan1.Id);

            collectionClanovi.Save(clan1);
            collectionKnjige.Save(knjiga1);

            //////////////////
            string datum = DateTime.Now.ToString();
            string datumVracanje = DateTime.Now.AddDays(30).ToString();

            

            MessageBox.Show("Izdata knjiga: " + knjiga1.naslov + "\n Datum vracanja: " + datumVracanje);

        }
        #region zaFormu
        private void FormZaposleni_Load(object sender, EventArgs e)
        {
            Text = " " + FormZaposleniLogging.logovani.ime + " " +FormZaposleniLogging.logovani.prezime;
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");
            var collectionSektori = db.GetCollection<Sektor>("sektori");
            foreach(Sektor s in collectionSektori.FindAll())
            {
                comboBox1.Items.Add(s.oznakaSektora);
            }
            var collection = db.GetCollection<Clan>("clanovi");
            MongoCursor<Clan> clanovi = collection.FindAll();
            List<Clan> listaClanova = new List<Clan>();
            foreach (Clan c in clanovi.ToArray<Clan>())
            {
                listaClanova.Add(c);
            }
            for (int i = 0; i < listaClanova.Count; i++)
                cbClanovi.Items.Add(listaClanova[i].brojClanskeKarte); //+ ". " + listaClanova[i].ime + " " + listaClanova[i].prezime);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Sve-izdavanje knjige

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            var collectionSektori = db.GetCollection<Sektor>("sektori");
            var collectionKnjige = db.GetCollection<Knjiga>("knjige");
            Sektor s = new Sektor();

            foreach(Sektor sektor in collectionSektori.Find(Query.EQ("oznakaSektora", comboBox1.SelectedItem.ToString())))
            {
                s = sektor;
            }

            List<Knjiga> knjigeLista = new List<Knjiga>();
            foreach(Knjiga k in collectionKnjige.FindAll())
            {
                for(int i = 0;i<s.knjigeUSektoru.Count;i++)
                {
                    if (k.Id == s.knjigeUSektoru[i].Id)
                        knjigeLista.Add(k);
                }
            }
            dataGridView1.DataSource = knjigeLista;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Sektor"].Visible = false;
        }
        private void btnUcitajZahteve_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collectionZahtevi = database.GetCollection<Zahtev>("zahtevi");

            List<Zahtev> zahtevi = new List<Zahtev>();
           foreach(Zahtev z in collectionZahtevi.FindAll())
           {
               zahtevi.Add(z);
           }
          

           dataGridView2.DataSource = zahtevi;
        }
        #endregion

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Clan>("clanovi");
   
            var knjigeColl = database.GetCollection<Knjiga>("knjige");

            Clan clan = new Clan();
            foreach (Clan c in collection.Find(Query.EQ("brojClanskeKarte", cbClanovi.SelectedItem.ToString())))
            {
                clan = c;
            }

            
            foreach (Knjiga k in knjigeColl.FindAll())
            {
                for (int i = 0; i < clan.iznajmljeneKnjige.Count; i++)
                {
                    if (k.Id == clan.iznajmljeneKnjige[i])//.id
                        listBox1.Items.Add(k.naslov);
                }
            }


        }

        private void cbClanovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnPodaci_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var clanoviCollection = database.GetCollection<Clan>("clanovi");

            listBox1.Items.Clear();

            if(cbClanovi.Text == null)
            {
                MessageBox.Show("Izaberite clana, na osnovu broja clanske karte.");
            }

            Clan clan = new Clan();
            foreach (Clan c in clanoviCollection.Find(Query.EQ("brojClanskeKarte", cbClanovi.SelectedItem.ToString())))
            {
                clan = c;
            }


            listBox1.Items.Add("Ime: " + clan.ime);
            listBox1.Items.Add("Prezime: " + clan.prezime);
            listBox1.Items.Add("Zanimanje: " + clan.zanimanje);
            listBox1.Items.Add("Broj licne karte: " + clan.brojLicneKarte);
            listBox1.Items.Add("Broj telefona: " + clan.brojTelefona);
        }

        private void btnVracenaKnjiga_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var clanoviCollection = database.GetCollection<Clan>("clanovi");
            var knjigeColl = database.GetCollection<Knjiga>("knjige");

            //int indexRow = dataGridView1.CurrentRow.Index;



            if(listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte knjigu iz liste iznajmljenih knjiga!");
                return;
            }


            Clan clan = new Clan();
            foreach (Clan c in clanoviCollection.Find(Query.EQ("brojClanskeKarte", cbClanovi.SelectedItem.ToString())))
            {
                clan = c;
            }

            Knjiga knjiga = new Knjiga();
            foreach (Knjiga k in knjigeColl.Find(Query.EQ("naslov", listBox1.SelectedItem.ToString())))//(string)dataGridView1[1, indexRow].Value)))
            {
                knjiga = k;
            }


            List<ObjectId> listaKnjiga = new List<ObjectId>();
            List<ObjectId> listaClanova = new List<ObjectId>();

            foreach(ObjectId izKnjiga in clan.iznajmljeneKnjige.ToList())
            {
                listaKnjiga.Add(izKnjiga);
            }

            foreach(ObjectId izClanu in knjiga.IzdataClanovima.ToList())
            {
                listaClanova.Add(izClanu);
            }

            for (int i = 0; i < listaKnjiga.Count;i++)
            {

                if(knjiga.Id == listaKnjiga[i])
                {
                    listaKnjiga.RemoveAt(i);
                }
                    knjiga.brojPrimeraka++;
            }

            knjigeColl.Save(knjiga);


            for(int i = 0;i<listaClanova.Count;i++)
            {
                if(clan.Id == listaClanova[i])
                {
                    listaClanova.RemoveAt(i);
                }
            }

            var query = Query.EQ("_id", clan.Id);
            var update = MongoDB.Driver.Builders.Update.Set("iznajmljeneKnjige", BsonValue.Create(listaKnjiga));
            clanoviCollection.Update(query, update);
            
            var query1 = Query.EQ("_id", knjiga.Id);
            var update1 = MongoDB.Driver.Builders.Update.Set("IzdataClanovima", BsonValue.Create(listaClanova));
               knjigeColl.Update(query1, update1);
            
            MessageBox.Show("Knjiga " + knjiga.naslov + " je vracena.");
    }

        private void btnIzadavanjeZahtev_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null )
            {
                MessageBox.Show("Izaberite zahtev!");
                return;
            }
            int indexRow = dataGridView2.CurrentRow.Index;
            string knjiga = (string)dataGridView2[2, indexRow].Value;
            string brojClanskeKarte = (string)dataGridView2[1, indexRow].Value.ToString();
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");


            var collectionClanovi = db.GetCollection<Clan>("clanovi");
            var collectionKnjige = db.GetCollection<Knjiga>("knjige");




            Clan clan1 = new Clan();
            foreach (Clan c in collectionClanovi.Find(Query.EQ("brojClanskeKarte", brojClanskeKarte)))
            {
                clan1 = c;
            }
            Knjiga knjiga1 = new Knjiga();
            foreach (Knjiga k in collectionKnjige.Find(Query.EQ("naslov", knjiga)))
            {
                knjiga1 = k;
            }
            //////////////////

            if (knjiga1.brojPrimeraka < 1)
            {
                MessageBox.Show("Trenutno nema primeraka knjige u biblioteci.");
                return;
            }

            knjiga1.brojPrimeraka -= 1;

          
            clan1.iznajmljeneKnjige.Add(knjiga1.Id);
            knjiga1.IzdataClanovima.Add(clan1.Id);

            collectionClanovi.Save(clan1);
            collectionKnjige.Save(knjiga1);

            //////////////////
            string datum = DateTime.Now.ToString();
            string datumVracanje = DateTime.Now.AddDays(30).ToString();


            MessageBox.Show("Izdata knjiga: " + knjiga1.naslov + "\n Datum vracanja: " + datumVracanje);


            var collectionZahtevi = db.GetCollection<Zahtev>("zahtevi");

            ObjectId idZahteva = ObjectId.Parse(dataGridView2[0, indexRow].Value.ToString());

            var query = Query.EQ("_id", idZahteva);
            collectionZahtevi.Remove(query);
        }
    }
}
