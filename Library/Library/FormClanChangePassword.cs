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
    public partial class FormClanChangePassword : Form
    {
        public FormClanChangePassword()
        {
            InitializeComponent();
        }

        private void FormClanChangePassword_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            txtUsernameNew.Visible = false;
            txtUsernameNew.Text = FormClanLogIn.trClan.username;
            txtUserNameOld.Text = FormClanLogIn.trClan.username;
            txtPasswordOld.Text = FormClanLogIn.trClan.password;
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("Morate uneti identicne lozinke.","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");

                var collection = database.GetCollection<Clan>("clanovi");
                //ovde treba ovo za oznake,ali to nisam mogao provaljujem
                var query = (Query.And(Query.EQ("Id", FormClanLogIn.trClan.Id),Query.EQ("username",FormClanLogIn.trClan.username)));
                ////////////////// Ovde da provalimo kako da update vise stvari.
                var update = MongoDB.Driver.Builders.Update.Set("password", txtPasswordRetype.Text);
                var update2 = MongoDB.Driver.Builders.Update.Set("username", txtUsernameNew.Text);
                collection.Update(query, update);   // ne kapiram zasto ne radi.
                //collection.Update(query, update2);
                MessageBox.Show("Uspesno ste azurirali profil.","Update je uspesan",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
