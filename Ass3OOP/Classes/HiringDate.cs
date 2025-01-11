using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3OOP.Classes
{
    internal class HiringDate
    {
        public HiringDate() { } 
        public HiringDate(int day, int month, int year)
        {
            if (day < 1 || day > 31) {
                Console.WriteLine("Day must be between 1 and 31.");
            }
            if(month < 1 || month > 12)
            {
                Console.WriteLine("Month must be between 1 and 12.");
            }
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public override string ToString() {
            return $"{Day}-{Month}-{Year}";
        }

    }
}
