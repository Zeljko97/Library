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
    public partial class FormZaposleni : Form
    {
        public FormZaposleni()
        {
            InitializeComponent();
        }

        private void btnSveKnjige_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Knjiga>("knjige");

            MongoCursor<Knjiga> knjige = collection.FindAll();

            List<Knjiga> listaKnjiga = new List<Knjiga>();

            foreach(Knjiga k in knjige.ToArray<Knjiga>())
            {
                listaKnjiga.Add(k);
            }
            dataGridView1.DataSource = listaKnjiga;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnPisca_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            var collection = db.GetCollection<Knjiga>("knjige");

            List<Knjiga> knjige = new List<Knjiga>();

            foreach(Knjiga k in collection.Find(Query.EQ("autor", txtImePisca.Text)))
            {
                knjige.Add(k);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = knjige;
        }

        private void btnNaslovKnjige_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            var collection = db.GetCollection<Knjiga>("knjige");

            List<Knjiga> knjige = new List<Knjiga>();

            foreach (Knjiga k in collection.Find(Query.EQ("naslov", txtKnjiga.Text)))
            {
                knjige.Add(k);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = knjige;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnZanr_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            var collection = db.GetCollection<Knjiga>("knjige");

            List<Knjiga> knjige = new List<Knjiga>();

            if(rbRoman.Checked == true)
            {
                foreach(Knjiga k in collection.Find(Query.EQ("zanr", "roman")))
                {
                    knjige.Add(k);
                }
            }
            else if (rbPublicistika.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("zanr", "publicistika")))
                {
                    knjige.Add(k);
                }
            }
            else if (rbDecjeKnjige.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("zanr", "decja knjiga")))
                {
                    knjige.Add(k);
                }
                foreach (Knjiga k in collection.Find(Query.EQ("oznake","decja knjiga")))
                {
                    knjige.Add(k);
                }
            }
            else if (rbDomaciAutori.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("oznake", "domaci autor")))
                {
                    knjige.Add(k);
                }
            }
            else if(rbKlasici.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("oznake", "klasika")))
                {
                    knjige.Add(k);
                }
            }
            else if(rbPoezija.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("oznake", "poezija")))
                {
                    knjige.Add(k);
                }
            }
            else if(rbPsihologija.Checked == true)
            {
                foreach (Knjiga k in collection.Find(Query.EQ("oznake", "psihologija")))
                {
                    knjige.Add(k);
                }
            }



            dataGridView1.DataSource = null;
            dataGridView1.DataSource = knjige;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnIzdavanje_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            var collection = db.GetCollection<Clan>("clanovi");

           
           

            

            MongoCursor<Clan> clanovi = collection.FindAll();

            List<Clan> listaClanova = new List<Clan>();

            foreach (Clan c in clanovi.ToArray<Clan>())
            {
                listaClanova.Add(c);
            }

            for (int i = 0; i < listaClanova.Count;i++)
                cbClanovi.Items.Add(listaClanova[i].ime + " " + listaClanova[i].prezime);
        }

        private void cbClanovi_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIzdavanje_Click_1(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null || cbClanovi.SelectedItem == null)
            {
                MessageBox.Show("Izaberi knjigu i clana biblioteke");
                return;
            }
            int indexRow = dataGridView1.CurrentRow.Index;
            string knjiga = (string)dataGridView1[1, indexRow].Value;
            


            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("Biblioteka");

            var collection = db.GetCollection<IzdataKnjiga>("izdate knjige");

            

            

            string datum = DateTime.Now.ToString();
            string datumVracanje = DateTime.Now.AddDays(30).ToString();

            MessageBox.Show(datum + " --- " + datumVracanje);
          //  IzdataKnjiga izdataKnjiga = new IzdataKnjiga { knjiga = (string)dataGridView1[1, indexRow].Value, datumIzdavanja = datum, datumVracanja = datumVracanje, Clan = cbClanovi.SelectedItem };

        }
    }
}