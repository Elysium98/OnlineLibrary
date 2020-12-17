using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineLibrary.db.daos;
using OnlineLibrary.db.models;
using OnlineLibrary.controller;

namespace OnlineLibrary
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void textEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if(textEmail.Text.Equals("Email"))
            {
                textEmail.Clear();
            }
           if(string.IsNullOrEmpty(textPassword.Text))
            {
                textPassword.PasswordChar ='\0';
                textPassword.Text = "Password";
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
                UserRegister register = new UserRegister();
                register.Dock = DockStyle.Fill;
                Dashboard.Instance.PnlContainer.Controls.Add(register);
                Dashboard.Instance.PnlContainer.Controls["UserRegister"].BringToFront();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = textEmail.Text;
            user.Password = GUIController.encrypt(textPassword.Text);
            UserDao.login(user);
            if (GUIController.checkLoginSucces == true)
            {
                Dashboard.Instance.PnlContainer.Controls.Clear();
                 if(GUIController.roleAccess.Equals("librarian"))
                  {
                      Dashboard.Instance.showMenuLibrarian();
                  }
                  else 
                  {
                      Dashboard.Instance.showMenuStudent();
                  }
            }
        }

        private void textPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textPassword.Text.Equals("Password"))
            {
                textPassword.Clear();
                textPassword.PasswordChar='*';
            }
            if (string.IsNullOrEmpty(textEmail.Text))
            {
                textEmail.Text = "Email";
            }
        }
    }
}
