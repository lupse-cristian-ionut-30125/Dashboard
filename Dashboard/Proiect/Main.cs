using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Proiect.inneForms;
using Proiect.innerForms;

namespace Proiect
{
    public partial class Main : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentInnerForm;

        public Main(string username)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            welcomeLabel.Text = "Hello " + username + ", Welcome Back!";
        }
        // Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(250, 90, 90);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(0, 0, 139);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(1, 171, 85);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon inner form
                iconInnerForm.IconChar = currentBtn.IconChar;
                iconInnerForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(1, 171, 85);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenInnerForm(Form innerForm)
        { 
            if(currentInnerForm != null)
            {
                currentInnerForm.Close();
            }
            currentInnerForm = innerForm;
            innerForm.TopLevel = false;
            innerForm.FormBorderStyle = FormBorderStyle.None;
            innerForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(innerForm);
            panelDesktop.Tag = innerForm;
            innerForm.BringToFront();
            innerForm.Show();
            labelInnerForm.Text = innerForm.Text;   
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenInnerForm(new DashboardForm());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenInnerForm(new OrdersForm());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenInnerForm(new ProductsForm());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenInnerForm(new CustomersForm());
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenInnerForm(new MarketingForm());
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenInnerForm(new Analytics());
        }

        private void iconLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

       // private void OpenChild()

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconInnerForm.IconChar = IconChar.Home;
            iconInnerForm.IconColor = Color.White;
            labelInnerForm.Text = "Home";
        }
    }
}
