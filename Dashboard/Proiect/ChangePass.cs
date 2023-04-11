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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(textBoxChangePass.Text.Length>3)
            {
                if (textBoxChangePass.Text == textBoxRepeatPass.Text)
                {
                    string[] credentials = File.ReadAllLines("credentials.txt");

                    if (credentials.Length >= 2)
                    {
                        credentials[1] = textBoxChangePass.Text;
                        File.WriteAllLines("credentials.txt", credentials);
                    }
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Parolele nu sunt la fel. Va rugam verificati ca cele doua parole sa fie la fel");
                }
            }
            else
            {
                MessageBox.Show("Noua parola trebuie sa contina minim 4 caractere");
            }
            
        }
    }
}
