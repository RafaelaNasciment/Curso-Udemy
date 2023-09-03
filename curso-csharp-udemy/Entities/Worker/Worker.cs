using System.Globalization;

namespace curso_csharp_udemy.Entities.Worker
{
    public class Worker
    {
        public Worker(string name, Level level, double salaryBase)
        {
            Name = name;
            Level = level;
            SalaryBase = salaryBase;
        }

        public string Name { get; set; }
        public Level Level { get; set; }
        public Double SalaryBase { get; set; }
        public List<Contract> Contract { get; set; } = new List<Contract>();


        public void AddContract(Double valuePerHour, int hours, double incomeMonth, DateTime dateTime)
        {
            Contract.Add(new Contract(
                date: dateTime,
                valuePerHour: valuePerHour,
                hours: hours,
                incomeMonth: incomeMonth));
        }
    }

    public class Contract
    {
        public Contract(DateTime date, double valuePerHour, int hours, double incomeMonth)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
            IncomeMonth = incomeMonth;
        }

        private DateTime Date { get; set; } = DateTime.Now;
        private Double ValuePerHour { get; set; }
        private int Hours { get; set; }
        private double IncomeMonth { get; set; }

    }

    public enum Level : int
    {
        Junior = 50, 
        Pleno = 100, 
        Senior = 300,
    }
}
