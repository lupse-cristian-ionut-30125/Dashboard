namespace Proiect
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.iconFacebook = new FontAwesome.Sharp.IconPictureBox();
            this.iconLinkedin = new FontAwesome.Sharp.IconPictureBox();
            this.iconInstagram = new FontAwesome.Sharp.IconPictureBox();
            this.iconWebsite = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLinkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconWebsite)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(13, 187);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(97, 24);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(13, 237);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 24);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(135, 190);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(153, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(135, 237);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(153, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOG IN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(17, 283);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(119, 33);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(233)))), ((int)(((byte)(221)))));
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Location = new System.Drawing.Point(165, 283);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(123, 33);
            this.btnChangePass.TabIndex = 7;
            this.btnChangePass.Text = "Change password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // iconFacebook
            // 
            this.iconFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(85)))));
            this.iconFacebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(174)))));
            this.iconFacebook.IconChar = FontAwesome.Sharp.IconChar.FacebookSquare;
            this.iconFacebook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(174)))));
            this.iconFacebook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFacebook.IconSize = 50;
            this.iconFacebook.Location = new System.Drawing.Point(12, 334);
            this.iconFacebook.Name = "iconFacebook";
            this.iconFacebook.Size = new System.Drawing.Size(52, 50);
            this.iconFacebook.TabIndex = 8;
            this.iconFacebook.TabStop = false;
            this.iconFacebook.Click += new System.EventHandler(this.iconFacebook_Click);
            // 
            // iconLinkedin
            // 
            this.iconLinkedin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(85)))));
            this.iconLinkedin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.iconLinkedin.IconChar = FontAwesome.Sharp.IconChar.Linkedin;
            this.iconLinkedin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.iconLinkedin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLinkedin.IconSize = 50;
            this.iconLinkedin.Location = new System.Drawing.Point(87, 334);
            this.iconLinkedin.Name = "iconLinkedin";
            this.iconLinkedin.Size = new System.Drawing.Size(52, 50);
            this.iconLinkedin.TabIndex = 9;
            this.iconLinkedin.TabStop = false;
            this.iconLinkedin.Click += new System.EventHandler(this.iconLinkedin_Click);
            // 
            // iconInstagram
            // 
            this.iconInstagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(85)))));
            this.iconInstagram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(61)))), ((int)(((byte)(180)))));
            this.iconInstagram.IconChar = FontAwesome.Sharp.IconChar.InstagramSquare;
            this.iconInstagram.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(61)))), ((int)(((byte)(180)))));
            this.iconInstagram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInstagram.IconSize = 50;
            this.iconInstagram.Location = new System.Drawing.Point(165, 334);
            this.iconInstagram.Name = "iconInstagram";
            this.iconInstagram.Size = new System.Drawing.Size(52, 50);
            this.iconInstagram.TabIndex = 10;
            this.iconInstagram.TabStop = false;
            this.iconInstagram.Click += new System.EventHandler(this.iconInstagram_Click);
            // 
            // iconWebsite
            // 
            this.iconWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(85)))));
            this.iconWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(229)))), ((int)(((byte)(235)))));
            this.iconWebsite.IconChar = FontAwesome.Sharp.IconChar.Yelp;
            this.iconWebsite.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(229)))), ((int)(((byte)(235)))));
            this.iconWebsite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconWebsite.IconSize = 50;
            this.iconWebsite.Location = new System.Drawing.Point(236, 334);
            this.iconWebsite.Name = "iconWebsite";
            this.iconWebsite.Size = new System.Drawing.Size(52, 50);
            this.iconWebsite.TabIndex = 11;
            this.iconWebsite.TabStop = false;
            this.iconWebsite.Click += new System.EventHandler(this.iconWebsite_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(171)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.iconWebsite);
            this.Controls.Add(this.iconInstagram);
            this.Controls.Add(this.iconLinkedin);
            this.Controls.Add(this.iconFacebook);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLinkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconWebsite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnChangePass;
        private FontAwesome.Sharp.IconPictureBox iconFacebook;
        private FontAwesome.Sharp.IconPictureBox iconLinkedin;
        private FontAwesome.Sharp.IconPictureBox iconInstagram;
        private FontAwesome.Sharp.IconPictureBox iconWebsite;
    }
}