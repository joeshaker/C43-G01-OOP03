using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass3OOP.Classes;

namespace Ass3OOP.DerivedClasses
{
    internal class PrintedBook:Book
    {
        public PrintedBook(string title, string author, string iSBN , int pageCount) : base(title, author, iSBN)
        {
            PageCount = pageCount;
        }

        public int PageCount { get; set; }
        public override string ToString()
        {
            return base.ToString()+$" PageCount {PageCount}";
        }

    }
}
