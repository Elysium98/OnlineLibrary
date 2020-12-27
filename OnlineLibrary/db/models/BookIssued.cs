using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.db.models
{
    class BookIssued : Book
    {
        private string fullname;
        private DateTime dateIssued;

        public string Fullname { get => fullname; set => fullname = value; }
        public DateTime DateIssued { get => dateIssued; set => dateIssued = value; }
    }
}
