﻿namespace curso_csharp_udemy.Entities
{
    internal class HourContract
    {
        public HourContract()
        {
            
        }

        public HourContract(
            DateTime date, 
            double valuePerHour, 
            int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hours { get; set; }


        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
