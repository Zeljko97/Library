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

using System.IO;

using Library.Entiteti;

namespace Library
{
    public partial class Admin : Form
    {
        public static Knjiga azuriranje;
        public static Clan azuriranjeClana;
        public Admin()
        {
            InitializeComponent();
            azuriranje = null;
        }

        #region Zaposleni
        private void btnSviZaposleni_Click(object sender, EventArgs e)
        {
            Zaposleni();
        }
        public void Zaposleni() // zbog toga sto je potreban refresh
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
            SakrijZaposleni();
        }
        private void SakrijZaposleni()
        {
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
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Nijedan zaposleni nije selektovan.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = dataGridView2.CurrentRow.Index;
                ObjectId idZaposlenog = ObjectId.Parse(dataGridView2[0,index].Value.ToString());
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Zaposleni>("zaposleni");
                //MongoCursor<Zaposleni> zaposleni = collection.FindAll();
                var query = Query.EQ("_id", idZaposlenog);
                collection.Remove(query);
                MessageBox.Show("Izabrani korisnik je uspesno", "Uspesno brisanje korisnika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Zaposleni();// refresh
            }
        }
        private void btnResetujPassword_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Nijedan zaposleni nije selektovan.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = dataGridView2.CurrentRow.Index;
                ObjectId idZaposlenog = ObjectId.Parse(dataGridView2[0, index].Value.ToString());

                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Zaposleni>("zaposleni");
                MongoCursor<Zaposleni> zaposleni = collection.FindAll();
                var query = Query.EQ("_id", idZaposlenog);
                var update = MongoDB.Driver.Builders.Update.Set("password", "mongo");
                collection.Update(query, update);
                MessageBox.Show("Password korisnika je uspesno resetovan.", "Uspesno resetovan password", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SakrijZaposleni();
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
            SakrijZaposleni();
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
            SakrijZaposleni();
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
            Sakrij();
        }
        private void Sakrij()
        {
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["zanr"].Visible = true;
            dataGridView1.Columns["izdavac"].Visible = false;
            dataGridView1.Columns["povez"].Visible = false;
            dataGridView1.Columns["brojStrana"].Visible = false;
            dataGridView1.Columns["brojPrimeraka"].Visible = false;
            dataGridView1.Columns["Sektor"].Visible = false;
        }
        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            FormDodajKnjigu fdk = new FormDodajKnjigu();
            fdk.Show();
        }
        private void btnAzurirajKnjigu_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (dataGridView1.CurrentRow == null)
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
            if (dataGridView1.CurrentRow == null)
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
        private void PrikazLabela(bool s)
        {
            label1.Visible = s;
            label2.Visible = s;
            label3.Visible = s;
            label4.Visible = s;
            label8.Visible = s;
            label8.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                PrikazLabela(false);
            }
            else
            {
                int index = dataGridView1.CurrentRow.Index;
                string naslov = (string)dataGridView1[1, index].Value;
                PrikazLabela(true);
                label1.Text = "Zanr: " + (string)dataGridView1[3, index].Value;
                label2.Text = "Izdavac: " + (string)dataGridView1[4, index].Value;
                label3.Text = "Povez: " + (string)dataGridView1[5, index].Value;
                label4.Text = "Broj stranica: " + (string)dataGridView1[6, index].Value.ToString();
                label8.Text = "Broj primeraka: " + (string)dataGridView1[7, index].Value.ToString();
                
                string path = @"../../Resources/" + naslov + ".jpg";
                if (!File.Exists(path))
                {
                    pbKnjiga.Image = Image.FromFile("../../Resources/NotFound.png");
                    pbKnjiga.SizeMode = PictureBoxSizeMode.StretchImage;
                    label11.Visible = true;
                }
                else
                {
                    pbKnjiga.Image = Image.FromFile("../../Resources/" + naslov + ".jpg");
                    pbKnjiga.SizeMode = PictureBoxSizeMode.StretchImage;
                    label11.Visible = false;
                }
            }
        }
        //sortiranja
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
            Sakrij();
        }
        private void btnKnjigePoNaslovu_Click(object sender, EventArgs e)
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");
            var collection = database.GetCollection<Knjiga>("knjige");
            List<Knjiga> listaZaposleni = new List<Knjiga>();

            foreach (Knjiga k in collection.FindAll().SetSortOrder(SortBy.Descending("naslov")))
            {
                listaZaposleni.Add(k);
            }
            dataGridView1.DataSource = listaZaposleni;
            Sakrij();
        }
        private void btnSortPoBrojuPrimeraka_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");
            var collection = database.GetCollection<Knjiga>("knjige");
            List<Knjiga> listaZaposleni = new List<Knjiga>();

            foreach (Knjiga k in collection.FindAll().SetSortOrder(SortBy.Descending("brojPrimeraka")))
            {
                listaZaposleni.Add(k);
            }
            dataGridView1.DataSource = listaZaposleni;
            Sakrij();
        }
        private void btnSektor_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridView1.CurrentRow.Index;
            string knjiga = (string)dataGridView1[1, indexRow].Value;
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            var collectionKnjige = db.GetCollection<Knjiga>("knjige");
            var collectionSektori = db.GetCollection<Sektor>("sektori");

            Knjiga knjiga1 = new Knjiga();
            foreach (Knjiga k in collectionKnjige.Find(Query.EQ("naslov", (string)dataGridView1[1, indexRow].Value)))
            {
                knjiga1 = k;
            }
            Sektor sektor1 = new Sektor();
            foreach (Sektor s in collectionSektori.Find(Query.EQ("oznakaSektora", comboBox1.Text)))
            {
                sektor1 = s;
            }
            sektor1.knjigeUSektoru.Add(new MongoDBRef("knjigeUSektoru", knjiga1.Id));
            knjiga1.Sektor = new MongoDBRef("sektori", sektor1.Id);
            collectionSektori.Save(sektor1);
            collectionKnjige.Save(knjiga1);
            MessageBox.Show("Knjiga: " + knjiga1.naslov + "je sada u sektoru: " + sektor1.oznakaSektora + ".", "Uspesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnImeAutora_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtImePisca.Text))
            {
                MessageBox.Show("Da bi pretrazila baza po autora knjige,potrebno je pre svega uneti ga.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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
            Sakrij();
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
            Sakrij();
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
                Sakrij();
            }
        }
        private void btnDodajPrimerak_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBrojPrimeraka.Text))
            {
                MessageBox.Show("\t Da biste dodali broj primeraka\t neophodno je prvo popuniti polje iznad.", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index = dataGridView1.CurrentRow.Index;
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Nijedna knjiga nije selektovana", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ObjectId IdKnjige = ObjectId.Parse(dataGridView1[0, index].Value.ToString());
                string Autor = (string)dataGridView1[2, index].Value;
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Knjiga>("knjige");

                Knjiga knjiga = new Knjiga();
                foreach (Knjiga k in collection.Find(Query.EQ("_id", IdKnjige)))
                {
                    knjiga = k;
                }
                int brPrim = Int32.Parse(txtBrojPrimeraka.Text);
                knjiga.brojPrimeraka += brPrim;
                collection.Save(knjiga);
                Knjige(); // refresh
            }
        }
        #endregion

        #region Korisnici
        private void btnSviKorisnici_Click(object sender, EventArgs e)
        {
            Clanovi();
        }
        private void Clanovi()
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
        }
        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            FormDodavanjeClana fcd = new FormDodavanjeClana();
            fcd.Show();
        }
        private void btnObrisiClana_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null)
            {
                MessageBox.Show("Nijedan korisnik nije selektovan", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = dataGridView3.CurrentRow.Index;
               // int Broj = Convert.ToInt32(dataGridView3[1, index].Value);
                ObjectId id = ObjectId.Parse(dataGridView3[0, index].Value.ToString());
                //zbog stampanja samo
                string ime = (string)dataGridView3[2, index].Value;
                string prezime = (string)dataGridView3[3, index].Value;
                /*****/
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Clan>("clanovi");
                var query = Query.EQ("_id", id);
                collection.Remove(query);
                MessageBox.Show("Clan " + ime + " " + prezime + " je uspesno obrisan..", "Uspesno brisanje clana biblioteke", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clanovi(); // refresh
            }
        }
        private void dataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView3.CurrentRow == null)
            {
                MessageBox.Show("Nijedna knjiga nije selektovana", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Clear();
                int index = dataGridView3.CurrentRow.Index;
                // int Broj = Convert.ToInt32(dataGridView3[1, index].Value);
                ObjectId id = ObjectId.Parse(dataGridView3[0, index].Value.ToString());
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Clan>("clanovi");

                var knjigeColl = database.GetCollection<Knjiga>("knjige");
                Clan clan = new Clan();
                foreach (Clan c in collection.Find(Query.EQ("_id", id)))
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
        }

        #endregion

        #region Ostalo
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");
            var collectionSektori = db.GetCollection<Sektor>("sektori");
            foreach (Sektor s in collectionSektori.FindAll())
            {
                comboBox1.Items.Add(s.oznakaSektora);
            }
        }
        private void txtBrojPrimeraka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        private void btnAzurirajClana_Click(object sender, EventArgs e)
        {
            int index = dataGridView3.CurrentRow.Index;
            if (dataGridView3.CurrentRow == null)
            {
                MessageBox.Show("Clan nije selektovan", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ObjectId id = ObjectId.Parse(dataGridView3[0, index].Value.ToString());
                

                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");
                var collection = database.GetCollection<Clan>("clanovi");

                //MongoCursor<Zaposleni> zaposleni = collection.FindAll();
                var query = Query.EQ("_id", id);
                azuriranjeClana = collection.FindOne(query);
                FormAzurirajClana f = new FormAzurirajClana();
                f.Show();
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {

        }
    }
}
