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
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

using Library.Entiteti;
namespace Library
{
    public partial class FormNaruci : Form
    {
        public FormNaruci()
        {
            InitializeComponent();
        }

        private void FormNaruci_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Knjiga>("knjige");

            MongoCursor<Knjiga> knjige = collection.FindAll();

            foreach(Knjiga k in knjige)
            {
                comboBox1.Items.Add(k.naslov);
            }
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collectionZahtevi = database.GetCollection<Zahtev>("zahtevi");
            //var collectionClanovi = database.GetCollection<Clan>("clanovi");

            Zahtev zahtev = new Zahtev { knjiga = comboBox1.Text, brojClanskeKarte = Int32.Parse(textBox1.Text) };
            collectionZahtevi.Insert(zahtev);

            MessageBox.Show("Poslali ste zahtev za knjigom. ");

            
        }
    }
}
