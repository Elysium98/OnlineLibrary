using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void UserLogin_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
