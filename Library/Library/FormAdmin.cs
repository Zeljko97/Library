using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Library.Entiteti;

using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB.Driver;
using MongoDB.Bson;
namespace Library
{
    public partial class FormAdmin : Form
    {

        public static Entiteti.Admin logovaniAdmin;
        public FormAdmin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
              var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Entiteti.Admin>("admin");

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Entiteti.Admin admin = new Entiteti.Admin();

            foreach(Entiteti.Admin ad in collection.Find(Query.EQ("username", username)))
            {
                if(ad.password == password)
                {
                    logovaniAdmin = ad;
                    this.Hide();
                    Admin f = new Admin();
                    f.Show();
                }

            }

         
            if(logovaniAdmin == null)
            {
                MessageBox.Show("Pogresan username ili password.");
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
