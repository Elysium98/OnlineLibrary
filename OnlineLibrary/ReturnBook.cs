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
    public partial class ReturnBook : Form
    {
        BookIssued bookIssued = new BookIssued();
        Book book = new Book();
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            returnBooksGridView.DataSource = BooksDao.issuedBooksTable();
        }

        private void returnBooksGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = returnBooksGridView.Rows[index];
            bookIssued.Fullname = selectedRow.Cells[0].Value.ToString();
            bookIssued.Author = selectedRow.Cells[1].Value.ToString();
            bookIssued.BookName = selectedRow.Cells[2].Value.ToString();
            bookIssued.DateAdded = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
            bookIssued.Language = selectedRow.Cells[4].Value.ToString();
            bookIssued.NumberOfPages = Convert.ToInt32(selectedRow.Cells[5].Value.ToString());
            bookIssued.DateIssued = Convert.ToDateTime(selectedRow.Cells[6].Value.ToString());
        }

        private void btn_returnBook_Click(object sender, EventArgs e)
        {
            BookReturned bookReturned = new BookReturned();
            Book book = new Book();
            bookReturned.Fullname = bookIssued.Fullname;
            bookReturned.Author = bookIssued.Author;
            bookReturned.BookName = bookIssued.BookName;
            bookReturned.DateAdded = bookIssued.DateAdded;
            bookReturned.DateIssued = bookIssued.DateIssued;
            bookReturned.Language = bookIssued.Language;
            bookReturned.NumberOfPages = bookIssued.NumberOfPages;
            var date = DateTime.Now.ToString("yyyy.MM.dd");
            bookReturned.DateReturned = Convert.ToDateTime(date);
            try
            {
                BooksDao.returnBook(bookReturned);
            }
            catch(Exception exp)
            {
                MessageBox.Show("Nu ati selectat nicio carte", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(GUIController.checkBookReturnedSuccess==true)
            {
                BooksDao.deleteIssuedBook(bookIssued);
                if(GUIController.checkDeleteIssuedBookSuccess==true)
                {
                    book.Author = bookReturned.Author;
                    book.BookName = bookReturned.BookName;
                    book.DateAdded = bookReturned.DateAdded;
                    book.Language = bookReturned.Language;
                    book.NumberOfPages = bookReturned.NumberOfPages;
                    BooksDao.insertBook(book);
                    returnBooksGridView.DataSource = BooksDao.issuedBooksTable();
                }
            }
        }

      
    }
}
