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
    public partial class FormClanSingIn : Form
    {
        public FormClanSingIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var clanoviCollection = database.GetCollection<Clan>("clanovi");

            Clan clan = new Clan();
            foreach (Clan c in clanoviCollection.Find(Query.EQ("brojClanskeKarte", txtClanskaKarta.Text)))
            {
                clan = c;
            }

            if(clan.ime == null)
            {
                MessageBox.Show("Niste uclanjeni u biblioteku.");
            }
            else
            {
                label2.Visible = true;
                label4.Visible = true;
                txtUsername.Visible = true;
                txtPassword.Visible = true;
                btnOK.Visible = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var clanoviCollection = database.GetCollection<Clan>("clanovi");

             Clan clan = new Clan();
            foreach (Clan c in clanoviCollection.Find(Query.EQ("brojClanskeKarte", txtClanskaKarta.Text)))
            {
                clan = c;
            }

            var query = Query.EQ("brojClanskeKarte", clan.brojClanskeKarte);
            var update = MongoDB.Driver.Builders.Update.Set("username", BsonValue.Create(txtUsername.Text));
            var update1 = MongoDB.Driver.Builders.Update.Set("password", BsonValue.Create(txtPassword.Text));

            clanoviCollection.Update(query, update);
            clanoviCollection.Update(query, update1);

            MessageBox.Show("Uspesno ste kreirali nalog");
        }
    }
}
