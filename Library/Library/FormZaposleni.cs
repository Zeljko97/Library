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

            var collectionIzdateKnjige = db.GetCollection<IzdataKnjiga>("izdateKnjige");
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

            clan1.iznajmljeneKnjige.Add(new MongoDBRef("iznajmljeneKnjige", knjiga1.Id));
            knjiga1.IzdataClanovima.Add(new MongoDBRef("izdataClanovima", clan1.Id));

            collectionClanovi.Save(clan1);
            collectionKnjige.Save(knjiga1);

            //////////////////
            string datum = DateTime.Now.ToString();
            string datumVracanje = DateTime.Now.AddDays(30).ToString();

            
       /*     IzdataKnjiga izdataKnjiga = new IzdataKnjiga { knjiga = (string)dataGridView1[1, indexRow].Value, datumIzdavanja = datum, datumVracanja = datumVracanje};
            collectionIzdateKnjige.Insert(izdataKnjiga);

            

                izdataKnjiga.Clan = new MongoDBRef("clanovi", clan1.brojClanskeKarte);
                clan1.iznajmljeneKnjige.Add(new MongoDBRef("knjiga", knjiga1.naslov));
                
                 
            collectionIzdateKnjige.Save(izdataKnjiga);
            collectionClanovi.Save(clan1);*/
           // MessageBox.Show("Izdata knjiga: " + izdataKnjiga.knjiga + "\n Datum vracanja: " + datumVracanje);

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
                cbClanovi.Items.Add(listaClanova[i].brojClanskeKarte + ". " + listaClanova[i].ime + " " + listaClanova[i].prezime);
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
           for (int i = 0; i < zahtevi.Count; i++)
           {
               listView1.Items.Add("Knjiga: \n" + zahtevi[i].knjiga  + "\n Broj clanske karte: \n" + zahtevi[i].brojClanskeKarte + "\n");
           }
        }
        #endregion

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
