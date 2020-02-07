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
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB.Bson;

namespace Library
{
    public partial class FormKnjigeINarucivanje : Form
    {

        OpenFileDialog fd = new OpenFileDialog();

        public FormKnjigeINarucivanje()
        {
            InitializeComponent();
        }

        private void FormKnjigeINarucivanje_Load(object sender, EventArgs e)
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            var collection = database.GetCollection<Knjiga>("knjige");

          MongoCursor<Knjiga> knjige= collection.FindAll();

            int loc1 = 10;
            int loc2 = 100;

            foreach (Knjiga k in knjige.ToArray<Knjiga>())
                {
                PictureBox picturebox1 = new PictureBox();
                Label label = new Label();
               
                  //  picturebox1.Name = "picturebox1";
                  //  label.Name = "label";
                    picturebox1.Location = new Point(loc1, loc2);
                    label.Location = new Point(loc1, loc2 + 80);
                    label.Text = k.naslov;
                    label.Size = new Size(80, 20);

                    picturebox1.Size = new Size(80, 80);
                    picturebox1.BackColor = Color.Aqua;
                    picturebox1.Image = Image.FromFile("../../Resources/"+ k.naslov +".jpg");

                    picturebox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(label);    
                    Controls.Add(picturebox1);
               

                    loc1 += 90;
                    if(loc1 > 700)
                    {
                        loc1 = 10;
                        loc2 += 110;
                    }

              //OpenFileDialog fd = new OpenFileDialog();
                
             //   picturebox1.MouseDoubleClick += new MouseEventHandler((o, a) => fd.ShowDialog());
                
                    
                
                }

            
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           // this.Controls.Clear();
            for (int i = 0; i <4 ; i++)
            {
                foreach (Control c in Controls)
                {
                    if (c is Label)
                        this.Controls.Remove(c);
                    else if (c is PictureBox)
                        this.Controls.Remove(c);
                }
            }
      

            
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            
             var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Biblioteka");

            


            var collection = database.GetCollection<Knjiga>("knjige");

            string zanr = comboBox1.SelectedItem.ToString();

            MongoCursor<Knjiga> knjige = collection.Find(Query.EQ("zanr",zanr));




            int loc1 = 10;
            int loc2 = 100;

            foreach (Knjiga k in knjige.ToArray<Knjiga>())
            {
                PictureBox picturebox1 = new PictureBox();
                Label label = new Label();

                // picturebox1[i].Name = "picturebox1";
                picturebox1.Location = new Point(loc1, loc2);
                label.Location = new Point(loc1, loc2 + 80);
                label.Text = k.naslov;
                label.Size = new Size(80, 20);

                picturebox1.Size = new Size(80, 80);
                picturebox1.BackColor = Color.Aqua;

                picturebox1.Image = Image.FromFile("../../Resources/" + k.naslov + ".jpg");

                picturebox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Controls.Add(picturebox1);
                Controls.Add(label);
                loc1 += 90;
                if (loc1 > 700)
                {
                    loc1 = 10;
                    loc2 += 110;
                }

                //OpenFileDialog fd = new OpenFileDialog();

                picturebox1.MouseDoubleClick += new MouseEventHandler((o, a) => fd.ShowDialog());
            }
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            FormNaruci f = new FormNaruci();
            f.Show();
        }
    }
}
