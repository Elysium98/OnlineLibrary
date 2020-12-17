using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineLibrary.db.utils;
using OnlineLibrary.db.daos;
using OnlineLibrary.db.models;
using OnlineLibrary.controller;

namespace OnlineLibrary
{
    public partial class UserRegister : UserControl
    {
       
        public UserRegister()
        {
            InitializeComponent();
        }

        private void textFullName_MouseClick(object sender, MouseEventArgs e)
        {
            if (textFullName.Text.Equals("Name"))
            {
                textFullName.Clear();
            }
            if (string.IsNullOrEmpty(textEmail.Text))
            {
                textEmail.Text = "Email";
            }
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                textPassword.PasswordChar = '\0';
                textPassword.Text = "Password";
            }

        }

        private void textPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textPassword.Text.Equals("Password"))
            {
                textPassword.Clear();
                textPassword.PasswordChar = '*';
            }
            if (string.IsNullOrEmpty(textEmail.Text))
            {
                textEmail.Text = "Email";
            }
            if (string.IsNullOrEmpty(textFullName.Text))
            {
                textFullName.Text = "Name";
            }
        }
        private void textEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (textEmail.Text.Equals("Email"))
            {
                textEmail.Clear();
            }
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                textPassword.PasswordChar = '\0';
                textPassword.Text = "Password";
            }
            if (string.IsNullOrEmpty(textFullName.Text))
            {
                textFullName.Text = "Name";
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            verificare();
            if (GUIController.isValidEmail(textEmail.Text))
            {
                User user = new User();
                user.Email = textEmail.Text;
                user.FullName = textFullName.Text;
                user.Password = GUIController.encrypt(textPassword.Text);
                UserDao.register(user);
                if (GUIController.checkRegisterSucces == true)
                {
                  //  Dashboard.Instance.PnlContainer.Controls["UserRegister"].Dispose();
                    textEmail.Clear();
                    textFullName.Clear();
                    textPassword.Clear();
                    UserLogin login = new UserLogin();
                    login.Dock = DockStyle.Fill;
                    Dashboard.Instance.PnlContainer.Controls.Add(login);
                    Dashboard.Instance.PnlContainer.Controls["UserLogin"].BringToFront();
                }
                else
                {
                    textPassword.Clear();
                    textEmail.Clear();
                }
            }
            else
            {
                MessageBox.Show("Email-ul nu este intr-un format valid", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEmail.Clear();
            }
        }
        private void verificare()
        {
            if (string.IsNullOrEmpty(textEmail.Text) == true)
            {
                MessageBox.Show("Nu ati introdus email-ul", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textEmail.Clear();
                textEmail.Focus();
            }
            else
                if (string.IsNullOrEmpty(textPassword.Text) == true)
            {
                MessageBox.Show("Nu ati introdus parola", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPassword.Clear();
                textPassword.Focus();
            }
            else
                if(string.IsNullOrEmpty(textFullName.Text)==true)
            {
                MessageBox.Show("Nu v-ati introdus numele si prenumele", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textFullName.Clear();
                textFullName.Focus();
            }
        }
    }
}
