using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLibrary
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
           /* UserRegister reg = new UserRegister();
            reg.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(reg);
            panelContainer.Controls["UserRegister"].BringToFront();
           */
            UserLogin login = new UserLogin();
            login.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(login);
            panelContainer.Controls["UserLogin"].BringToFront();
            
        }
    }
}
