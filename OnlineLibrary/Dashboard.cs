using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineLibrary.controller;

namespace OnlineLibrary
{
    public partial class Dashboard : Form
    {
        static Dashboard _obj;
        public static Dashboard Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Dashboard();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook book = new AddBook();
            book.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            menuStrip1.Hide();
            _obj = this;
            UserLogin login = new UserLogin();
            login.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(login);
            panelContainer.Controls["UserLogin"].BringToFront();
            if(GUIController.checkLoginSucces==true)
            {
                panelContainer.Controls["UserLogin"].Dispose();
            }
            
        }

        public void showMenuLibrarian()
        {
            menuStrip1.Show();
            issueBooksToolStripMenuItem.Visible = false;
            returnBooksToolStripMenuItem.Visible = false;
            completeBookDetailsToolStripMenuItem.Visible = false;
        }
        public void showMenuStudent()
        {
            menuStrip1.Show();
            addNewBooksToolStripMenuItem.Visible = false;
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showBooks viewbooks = new showBooks();
            viewbooks.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showBooks viewbooks = new showBooks();
            viewbooks.Show();
        }
    }
}
