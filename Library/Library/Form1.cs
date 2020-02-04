using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;

using Library.Entiteti;


namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Knjiga>("knjige");

            MongoCursor<Knjiga> knjige = collection.FindAll();

            foreach(Knjiga k in knjige.ToArray<Knjiga>())
            {
                MessageBox.Show(k.brojPrimeraka.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormZaposleni fz = new FormZaposleni();
            fz.Show();
        }
    }
}
