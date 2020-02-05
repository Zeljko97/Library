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
    public partial class FormDodajZaposlenog : Form
    {
        public FormDodajZaposlenog()
        {
            InitializeComponent();
            txtJMBG.MaxLength = 13;
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
            else if (String.IsNullOrEmpty(txtJMBG.Text))
            {
                MessageBox.Show("Niste uneli JMBG.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtRadniStaz.Text))
            {
                MessageBox.Show("Niste uneli radni staz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string user = txtIme.Text + " " + txtPrezime.Text;
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");

                var collection = database.GetCollection<Zaposleni>("zaposleni");
                Zaposleni z = new Zaposleni { ime = txtIme.Text, prezime = txtPrezime.Text, radni_staz = Convert.ToInt32(txtRadniStaz.Text), JMBG = txtJMBG.Text, username = user, password = "mongo" };
                collection.Insert(z);
                MessageBox.Show(txtIme.Text + " " + txtPrezime.Text + " je uspesno dodat","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
