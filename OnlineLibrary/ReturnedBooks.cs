using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineLibrary.db.daos;
namespace OnlineLibrary
{
    public partial class ReturnedBooks : Form
    {
        public ReturnedBooks()
        {
            InitializeComponent();
        }

        private void ReturnedBookscs_Load(object sender, EventArgs e)
        {
            returnedbooksView1.DataSource = BooksDao.returnedBooksTable();
        }
    }
}
