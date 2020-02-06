using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;

using Library.Entiteti;


namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Clan>("clanovi");
            var coll = database.GetCollection<IzdataKnjiga>("izdateKnjige");
            var knjigeColl = database.GetCollection<Knjiga>("knjige");

           /* Clan clan1 = new Clan();
            foreach (Clan c in collection.Find(Query.EQ("brojClanskeKarte", "3")))
            {
                clan1 = c;
            }
            */
          
            Knjiga knjiga= new Knjiga();
            List<MongoDBRef> kn = new List<MongoDBRef>();
            foreach (Clan c in collection.Find(Query.EQ("brojClanskeKarte", "2")))
            {
                kn = c.iznajmljeneKnjige;
            }

           
            knjiga.naslov = kn[0].ToString();
           
            MessageBox.Show(knjiga.naslov);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormZaposleniLogging fzl = new FormZaposleniLogging();
            fzl.Show();
            //FormZaposleni fz = new FormZaposleni();
            //fz.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.Show();
        }

        private void btnOpis_Click(object sender, EventArgs e)
        {

        }

        private void btnKnjige_Click(object sender, EventArgs e)
        {
            FormKnjigeINarucivanje f = new FormKnjigeINarucivanje();
            f.Show();
        }
    }
}
