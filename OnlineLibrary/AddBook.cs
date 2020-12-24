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
using OnlineLibrary.controller;

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
            book.Language = textLanguage.Text;
            book.NumberOfPages = Convert.ToInt32(textPages.Text);
            book.DateAdded = DateTime.ParseExact(textDateAdded.Text, "yyyy.MM.dd",null);
            BooksDao.insertBook(book);
            if(GUIController.checkInsertSucces==true)
            {
                textAuthor.Clear();
                textBookName.Clear();
                textLanguage.Clear();
                textPages.Clear();
               
            }
        }

        private void textDateAdded_MouseClick(object sender, MouseEventArgs e)
        {
            if(textDateAdded.Text.Equals("yyyy-mm-dd"))
            {
                textDateAdded.Clear();
            }
        }
    }
}
