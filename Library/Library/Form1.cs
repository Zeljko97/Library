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

        #region buttons
        private void button2_Click(object sender, EventArgs e)
        {
            FormZaposleniLogging fzl = new FormZaposleniLogging();
            fzl.Show();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.Show();
        }
        private void btnKnjige_Click(object sender, EventArgs e)
        {
            FormKnjigeINarucivanje f = new FormKnjigeINarucivanje();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormClanLogIn fcli = new FormClanLogIn();
            fcli.Show();
        }
        #endregion
    }
}
