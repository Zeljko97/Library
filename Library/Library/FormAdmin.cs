using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormAdmin : Form
    {
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
            if (txtUsername.Text == "admin" && txtPassword.Text == "mongo")
            {
                this.Hide();
                Admin a = new Admin();
                a.Show();
            }
            else
            {
                lblError.Text = "Pogresan username ili password.\n Pokusajte ponovo";
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
