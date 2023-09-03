using curso_csharp_udemy.Entities.Enums;

namespace curso_csharp_udemy.Entities.Worker
{
    internal class Worker2
    {
        public Worker2()
        {

        }

        public Worker2(
            string name,
            WorkerLevel level,
            double baseSalary,
            Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //garantir que nunca seja null;

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            //double sum = BaseSalary;
            //sum += Contracts.Where(x => x.Date.Year == year && x.Date.Month == month).Select(x => x.TotalValue()).Sum();

            return Contracts.Where(x => x.Date.Year == year && x.Date.Month == month).Select(x => x.TotalValue()).Sum();
        }
    }
}
