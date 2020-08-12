using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public double Hour { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, double hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }
        public double TotalValue()
        {
            return ValuePerHour * Hour;
        }
    }
}
