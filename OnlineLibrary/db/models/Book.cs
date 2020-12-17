using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.db.models
{
    class Book
    {
        private string author;

        public string Author { get => author; set => author = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public DateTime DateAdded { get => dateAdded; set => dateAdded = value; }

        private string bookName;

        private DateTime dateAdded;
        

        
    }
}
