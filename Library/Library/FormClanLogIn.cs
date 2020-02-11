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
    public partial class FormClanLogIn : Form
    {
        public static Clan trClan;
        public FormClanLogIn()
        {
            InitializeComponent();
            trClan = null;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Niste uneli username.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Niste uneli password.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Clan>("clanovi");

            foreach (Clan c in collection.Find(Query.And(Query.EQ("username", txtUsername.Text), Query.EQ("password", txtPassword.Text))))
            {
                    trClan = c;
                    this.Hide();
                    FormClanBiblioteke fcb = new FormClanBiblioteke();
                    fcb.Show();
            }
            if (trClan == null)
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Clan biblioteke sa trazenim username-om ili password-om ne postoji.\t\nPokusajte ponovo", "Neuspesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tDa biste resetovali lozinku javite se administratoru na broj +3810600516997 \n Mozete da prijavite problem sa logovanjem na server, na e-mail : \t mare97ng@hotmail.com \t libraryMongo@gmail.com ","Resetovanje lozinke",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            FormClanSingIn f = new FormClanSingIn();
            f.Show();
        }
    }
}
