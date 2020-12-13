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
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
                UserRegister register = new UserRegister();
                register.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(register);
                Form1.Instance.PnlContainer.Controls["UserRegister"].BringToFront();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = textEmail.Text;
            user.Password = GUIController.encrypt(textPassword.Text);
            UserDao.login(user);
            if(GUIController.checkLoginSucces==true)
            {

            }
        }
    }
}
