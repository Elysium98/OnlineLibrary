using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.db.models
{
    class BookReturned : BookIssued
    {
        private DateTime dateReturned;

        public DateTime DateReturned { get => dateReturned; set => dateReturned = value; }
    }
}
