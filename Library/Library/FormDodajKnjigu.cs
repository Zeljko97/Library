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
    public partial class FormDodajKnjigu : Form
    {
        public FormDodajKnjigu()
        {
            InitializeComponent();
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
                ///tagovi
                List<string> lista = new List<string>();
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        lista.Add(checkedListBox1.Items[i].ToString());
                  
                    }
                }
                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Biblioteka");

                var collection = database.GetCollection<Knjiga>("knjige");

                var sektoriCollection = database.GetCollection<Sektor>("sektori");

                Knjiga k = new Knjiga
                {
                    naslov = txtNaslov.Text,
                    autor = txtAutor.Text,
                    izdavac = txtIzdavac.Text,
                    zanr = cbZanr.SelectedItem.ToString(),
                    brojPrimeraka = Convert.ToInt32(txtBrojPrimeraka.Text),
                    brojStrana = Convert.ToInt32(txtBrojStrana.Text),
                    povez = cbPovez.SelectedItem.ToString(),
     
                    oznake = lista,
                };

           
                collection.Insert(k);
                collection.Save(k);
         
                MessageBox.Show(txtNaslov.Text + " knjiga je uspesno dodata", "Dodavanje uspesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void FormDodajKnjigu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
