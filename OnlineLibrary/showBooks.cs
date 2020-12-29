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
    public partial class showBooks : Form
    {
        Book book = new Book();
        public showBooks()
        {
            InitializeComponent();
        }

        private void showBooks_Load(object sender, EventArgs e)
        {
            //dataBooksView.Columns[0].DefaultCellStyle.Format = "d";
            dataBooksView.DataSource = BooksDao.showBooksTable();
            
            if(GUIController.roleAccess.Equals("student"))
            {
                textAuthor.Hide();
                textBookName.Hide();
                textDateAdded.Hide();
                textLanguage.Hide();
                textNumberOfPages.Hide();
                btn_Delete.Hide();
                btn_Update.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
            }
          
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                BooksDao.deleteBook(book);
                if(GUIController.checkDeleteBookSuccess==true)
                {
                    dataBooksView.DataSource = BooksDao.showBooksTable();
                }    
            }
            catch(Exception exp)
            {
                MessageBox.Show("Nu s-a reusit stergerea", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataBooksView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataBooksView.Rows[index];
            book.BookId = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            book.Author = selectedRow.Cells[1].Value.ToString();
            textAuthor.Text=selectedRow.Cells[1].Value.ToString();
            book.BookName = selectedRow.Cells[2].Value.ToString();
            textBookName.Text=selectedRow.Cells[2].Value.ToString();
            book.DateAdded = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
            textDateAdded.Text = book.DateAdded.ToString("yyyy.MM.dd");
            book.Language = selectedRow.Cells[4].Value.ToString();
            textLanguage.Text= selectedRow.Cells[4].Value.ToString();
            book.NumberOfPages = Convert.ToInt32(selectedRow.Cells[5].Value.ToString());
            textNumberOfPages.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            book.Author = textAuthor.Text;
            book.BookName = textBookName.Text;
            book.DateAdded= DateTime.ParseExact(textDateAdded.Text, "yyyy.MM.dd", null);
            book.Language = textLanguage.Text;
            book.NumberOfPages = Convert.ToInt32(textNumberOfPages.Text);
            BooksDao.updateBook(book);
            if(GUIController.checkUpdateBookSuccess)
            {
                dataBooksView.DataSource = BooksDao.showBooksTable();
            }
            else
            {
                MessageBox.Show("Nu s-a reusit actualizarea", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Issue_Click(object sender, EventArgs e)
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
            catch(Exception exp)
            {
                MessageBox.Show("Nicio carte selectata", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(GUIController.checkBookIssueSuccess==true)
            {
                BooksDao.deleteBook(book);
                dataBooksView.DataSource = BooksDao.showBooksTable();
            }
            
        }
    }
}
