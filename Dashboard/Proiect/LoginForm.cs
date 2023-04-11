using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBoxPassword.KeyPress += new KeyPressEventHandler(textBoxPassword_KeyPress);
        }

        private void iconFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/freshclicknow");
        }

        private void iconLinkedin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/company/freshclicknow/about/");
        }

        private void iconInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/freshclicknow/"); 
        }

        private void iconWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://freshclick.ro/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] userCredentials = File.ReadAllLines("credentials.txt");
            if (textBoxUsername.Text == userCredentials[0] && textBoxPassword.Text == userCredentials[1])
            {
                Main main = new Main(textBoxUsername.Text);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contul sau parola sunt gresite, va rugam incercati din nou");
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass();
            changePass.Show();
            this.Hide();
        }
    }
}
