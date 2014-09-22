using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCrave
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblLink_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterMember register = new RegisterMember();
            register.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
