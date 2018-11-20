using System;
using System.Collections.Generic;

namespace lab_4
{
    class Time : IComparable<Time>
    {
        //04.11.2018
        public int hours;
        public int minutes;
        public Time(string date) {
            string[] data = date.Split(':');
            this.hours = Int32.Parse(data[0]);
            this.minutes = Int32.Parse(data[1]);
        }
        public int CompareTo(Time d) {
            if ((hours < d.hours) || (hours == d.hours && minutes < d.minutes)) {
                return -1;
            } else return 1;
        }
    }
}

