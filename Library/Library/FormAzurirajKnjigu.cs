﻿using System;
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
    public partial class FormAzurirajKnjigu : Form
    {
        public FormAzurirajKnjigu()
        {
            InitializeComponent();
        }

        #region Funkcionalnost
        private void FormAzurirajKnjigu_Load(object sender, EventArgs e)
        {
            txtAutor.Text = Admin.azuriranje.autor;
            txtNaslov.Text = Admin.azuriranje.naslov;
            txtIzdavac.Text = Admin.azuriranje.izdavac;
            txtBrojPrimeraka.Text = Admin.azuriranje.brojPrimeraka.ToString();
            txtBrojStrana.Text = Admin.azuriranje.brojStrana.ToString();
            cbPovez.SelectedItem = Admin.azuriranje.povez;
            cbZanr.SelectedItem = Admin.azuriranje.zanr;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNaslov.Text))
            {
                MessageBox.Show("Niste uneli naslov.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtAutor.Text))
            {
                MessageBox.Show("Niste uneli autora knjige.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtIzdavac.Text))
            {
                MessageBox.Show("Niste uneli izdavaca knjige.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtBrojPrimeraka.Text))
            {
                MessageBox.Show("Niste uneli broj primeraka knjige.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(txtBrojStrana.Text))
            {
                MessageBox.Show("Niste uneli broj strana knjige.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(cbPovez.Text))
            {
                MessageBox.Show("Niste uneli povez knjige.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (String.IsNullOrEmpty(cbZanr.SelectedItem.ToString()))
            {
                MessageBox.Show("Niste uneli zanr knjige.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");

                var collection = database.GetCollection<Knjiga>("knjige");
               

                var query = Query.EQ("_id", Admin.azuriranje.Id);

                var update = MongoDB.Driver.Builders.Update.Set("naslov",BsonValue.Create(txtNaslov.Text));
                collection.Update(query, update);
                update = MongoDB.Driver.Builders.Update.Set("izdavac", BsonValue.Create(txtIzdavac.Text));
                collection.Update(query, update);
                 update = MongoDB.Driver.Builders.Update.Set("zanr", BsonValue.Create(cbZanr.Text));
                collection.Update(query, update);
                update = MongoDB.Driver.Builders.Update.Set("autor", BsonValue.Create(txtAutor.Text));
                collection.Update(query, update);
                update = MongoDB.Driver.Builders.Update.Set("povez", BsonValue.Create(cbPovez.Text));
                collection.Update(query, update);
                update = MongoDB.Driver.Builders.Update.Set("brojStrana", BsonValue.Create(txtBrojStrana.Text));
                collection.Update(query, update);
                update = MongoDB.Driver.Builders.Update.Set("brojPrimeraka", BsonValue.Create(txtBrojPrimeraka.Text));
                collection.Update(query, update);

                MessageBox.Show(txtNaslov.Text + " knjiga je uspesno izmenjena", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion

        #region Ogranicenja
        private void txtBrojStrana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtBrojPrimeraka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}
