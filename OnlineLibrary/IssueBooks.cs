using OnlineLibrary.controller;
using OnlineLibrary.db.daos;
using OnlineLibrary.db.models;
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
    public partial class IssueBooks : Form
    {
        Book book = new Book();
        public IssueBooks()
        {
            InitializeComponent();
        }

       

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            dataBooksView.DataSource = BooksDao.showBooksTable();
        }

        private void btn_Issue_Click(object sender, EventArgs e)
        {
            BooksDao.getNumberOfIssuedBooks();
            if (GUIController.numberOfIssuedBooks == true)
            {
                BookIssued bookissued = new BookIssued();
                bookissued.Author = book.Author;
                bookissued.BookName = book.BookName;
                bookissued.Fullname = GUIController.getFullName;
                bookissued.Language = book.Language;
                bookissued.NumberOfPages = book.NumberOfPages;
                bookissued.DateAdded = book.DateAdded;
                var date = DateTime.Now.ToString("yyyy.MM.dd");
                bookissued.DateIssued = Convert.ToDateTime(date);
                try
                {
                    BooksDao.issueBook(bookissued);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Nicio carte selectata", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (GUIController.checkBookIssueSuccess == true)
                {
                    BooksDao.deleteBook(book);
                    dataBooksView.DataSource = BooksDao.showBooksTable();
                }
            }
            else
            {
                MessageBox.Show("Prea multe carti imprumutate", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dataBooksView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataBooksView.Rows[index];
            book.BookId = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            book.Author = selectedRow.Cells[1].Value.ToString();
            book.BookName = selectedRow.Cells[2].Value.ToString();
            book.DateAdded = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
            book.Language = selectedRow.Cells[4].Value.ToString();
            book.NumberOfPages = Convert.ToInt32(selectedRow.Cells[5].Value.ToString());
        }
    }
}
