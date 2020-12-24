using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.db.models
{
    class Book
    {
        private int bookId;
        private string author;
        public string Author { get => author; set => author = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public DateTime DateAdded { get => dateAdded; set => dateAdded = value; }
        public string Language { get => language; set => language = value; }
        public int NumberOfPages { get => numberOfPages; set => numberOfPages = value; }
        public int BookId { get => bookId; set => bookId = value; }

        private string bookName;

        private DateTime dateAdded;
        private string language;
        private int numberOfPages;

        
    }
}
