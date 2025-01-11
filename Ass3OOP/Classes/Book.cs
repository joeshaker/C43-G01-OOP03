using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3OOP.Classes
{
    internal class Book
    {
        public Book(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public override string ToString()
        {
            return $"Title of book: {Title} by {Author} its ISBN: {ISBN}";
        }

    }
}
