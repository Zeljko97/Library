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
    public partial class FormZaposleniLogging : Form
    {
        public static Zaposleni logovani;
        public FormZaposleniLogging()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 15;
            logovani = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Niste uneli username.","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Niste uneli password.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Zaposleni>("zaposleni");

            foreach (Zaposleni k in collection.Find(Query.EQ("username", txtUsername.Text)))
            {
                if (k.password==txtPassword.Text)
                {
                    logovani = k;
                    this.Hide();
                    FormZaposleni fz = new FormZaposleni();
                    fz.Show();
                }
            }
            if (logovani == null)
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Zaposleni sa trazenim username-om ili password-om ne postoji.\t\nPokusajte ponovo","Neuspesno",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

    }
}
