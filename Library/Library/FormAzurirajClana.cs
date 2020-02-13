using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

using Library.Entiteti;

namespace Library
{
    public partial class FormAzurirajClana : Form
    {
        public FormAzurirajClana()
        {
            InitializeComponent();
        }

        private void FormAzurirajClana_Load(object sender, EventArgs e)
        {
            txtBrClKarte.Text = Admin.azuriranjeClana.brojClanskeKarte;
            txtIme.Text = Admin.azuriranjeClana.ime;
            txtPrezime.Text = Admin.azuriranjeClana.prezime;
            txtZanimanje.Text = Admin.azuriranjeClana.zanimanje;
            txtAdresa.Text = Admin.azuriranjeClana.adresa;
            txtBrojTelefona.Text = Admin.azuriranjeClana.brojTelefona;
            txtBrojLicneKarte.Text = Admin.azuriranjeClana.brojLicneKarte;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Clan>("clanovi");


            var query = Query.EQ("_id", Admin.azuriranjeClana.Id);

            var update = MongoDB.Driver.Builders.Update.Set("brojClanskeKarte", BsonValue.Create(txtBrClKarte.Text));
            collection.Update(query, update);
            update = MongoDB.Driver.Builders.Update.Set("ime", BsonValue.Create(txtIme.Text));
            collection.Update(query, update);
            update = MongoDB.Driver.Builders.Update.Set("prezime", BsonValue.Create(txtPrezime.Text));
            collection.Update(query, update);
            update = MongoDB.Driver.Builders.Update.Set("zanimanje", BsonValue.Create(txtZanimanje.Text));
            collection.Update(query, update);
            update = MongoDB.Driver.Builders.Update.Set("adresa", BsonValue.Create(txtAdresa.Text));
            collection.Update(query, update);
            update = MongoDB.Driver.Builders.Update.Set("brojTelefona", BsonValue.Create(txtBrojTelefona.Text));
            collection.Update(query, update);
            update = MongoDB.Driver.Builders.Update.Set("brojLicneKarte", BsonValue.Create(txtBrojLicneKarte.Text));
            collection.Update(query, update);

            MessageBox.Show(txtIme.Text + " " + txtPrezime.Text, " je izmenjen.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
