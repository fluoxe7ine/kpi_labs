using System;
using System.Collections.Generic;

namespace lab_4
{
    class Date : IComparable<Date>
    {
        //04.11.2018
        public int day;
        public int month;
        public int year;
        public Date(string date) {
            string[] data = date.Split('.');
            this.day = Int32.Parse(data[0]);
            this.month = Int32.Parse(data[1]);
            this.year = Int32.Parse(data[2]);
            //Console.WriteLine(data.Length);
        }
        public int CompareTo(Date d) {
            if ((year < d.year) || (year == d.year && month < d.month) || (year == d.year && month == d.month && day < d.day)) {
                return -1;
            } else return 1;
        }
    }
}

