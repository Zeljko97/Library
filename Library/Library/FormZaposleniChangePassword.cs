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
    public partial class FormZaposleniChangePassword : Form
    {
        public FormZaposleniChangePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsernameNew.Text))
            {
                MessageBox.Show("Novi username mora biti unet!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtPasswordNew.Text))
            {
                MessageBox.Show("Novi password mora biti unet.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtPasswordRetype.Text))
            {
                MessageBox.Show("Morate ponovo uneti password.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPasswordRetype.Text != txtPasswordNew.Text)
            {
                MessageBox.Show("Morate uneti identicne lozinke.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");

                var collection = database.GetCollection<Zaposleni>("clanovi");
                //ovde treba ovo za oznake,ali to nisam mogao provaljujem
                var query = (Query.And(Query.EQ("Id", FormZaposleniLogging.logovani.Id), Query.EQ("username", FormZaposleniLogging.logovani.username)));
                ////////////////// Ovde da provalimo kako da update vise stvari.
                var update = MongoDB.Driver.Builders.Update.Set("password", txtPasswordRetype.Text);
                var update2 = MongoDB.Driver.Builders.Update.Set("username", txtUsernameNew.Text);
                collection.Update(query, update);   // ne kapiram zasto ne radi.
                //collection.Update(query, update2);
                MessageBox.Show("Uspesno ste azurirali profil.", "Update je uspesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void FormZaposleniChangePassword_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            txtUsernameNew.Visible = false;
            txtUsernameNew.Text = FormZaposleniLogging.logovani.username;
            txtUserNameOld.Text = FormZaposleniLogging.logovani.username;
            txtPasswordOld.Text = FormZaposleniLogging.logovani.password;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label3.Visible = true;
                txtUsernameNew.Visible = true;
            }
            else
            {
                label3.Visible = false;
                txtUsernameNew.Visible = false;
            }
        }
    }
}
