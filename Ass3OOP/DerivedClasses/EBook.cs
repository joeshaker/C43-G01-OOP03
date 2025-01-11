using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass3OOP.Classes;

namespace Ass3OOP.DerivedClasses
{
    internal class EBook:Book
    {
        public EBook(string title, string author, string iSBN , int filesize) : base(title, author, iSBN)
        {
            FileSize = filesize;

        }

        public int FileSize {  get; set; }

        public override string ToString()
        {
            return base.ToString()+$" FileSize: {FileSize}MB";
        }

    }
}
