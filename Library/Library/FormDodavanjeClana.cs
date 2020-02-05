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
    public partial class FormDodavanjeClana : Form
    {
        public FormDodavanjeClana()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Niste uneli ime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtPrezime.Text))
            {
                MessageBox.Show("Niste uneli prezime.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtBrojLicneKarte.Text))
            {
                MessageBox.Show("Niste uneli broj licne karte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtZanimanje.Text))
            {
                MessageBox.Show("Niste uneli zanimanje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtBrojTelefona.Text))
            {
                MessageBox.Show("Niste uneli broj telefona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtAdresa.Text))
            {
                MessageBox.Show("Niste uneli adresu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtBroj.Text))
            {
                MessageBox.Show("Niste uneli registarski broj.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string user = txtIme.Text + " " + txtPrezime.Text;
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");

                var collection = database.GetCollection<Clan>("clanovi");
                Clan c = new Clan
                {
                    brojClanskeKarte = Convert.ToInt32(txtBroj.Text),
                    ime = txtIme.Text,
                    prezime = txtPrezime.Text,
                    zanimanje = txtZanimanje.Text,
                    adresa = txtAdresa.Text,
                    brojLicneKarte = txtBrojLicneKarte.Text,
                    brojTelefona = txtBrojTelefona.Text
                };
                collection.Insert(c);
                MessageBox.Show(txtIme.Text + " " + txtPrezime.Text + " je sada novi clan biblioteke", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
