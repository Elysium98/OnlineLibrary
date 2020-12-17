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
using OnlineLibrary.db.models;

namespace OnlineLibrary
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btn_insertBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Author = textAuthor.Text;
            book.BookName = textBookName.Text;
            UserDao.insertBook(book);
        }
    }
}
