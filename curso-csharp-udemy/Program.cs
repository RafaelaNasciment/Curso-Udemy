using curso_csharp_udemy.Entities;
using curso_csharp_udemy.Entities.Enums;
using System.Globalization;

Console.WriteLine("Department: ");
var department = Console.ReadLine();

Console.WriteLine("Name: ");
var name = Console.ReadLine();

Console.WriteLine("Level: ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.WriteLine("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Departament dept = new(department);

Worker2 worker = new Worker2(
    name: name,
    level: level,
    baseSalary: baseSalary,
    departament: dept);

Console.WriteLine("Quantity contracts: ");
int quantity = int.Parse(Console.ReadLine());

for(int i = 1; i < quantity; i++)
{
    Console.WriteLine($"Enter #{i} contract information: ");  
    Console.WriteLine($"Informe a data (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine()); 

    Console.WriteLine($"Value per hour: ");
    Double valuePerHour = Double.Parse(Console.ReadLine());

    Console.WriteLine($"Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract newContract = new HourContract(
        date: date,
        valuePerHour: valuePerHour,
        hours: hours);

    worker.AddContract(newContract);
}

Console.WriteLine();
Console.Write("Informe o mes e ano (MM/YYYY):");
string monthAndYear = Console.ReadLine();

int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Split("/")[1]);


Console.Write($"Name: {worker.Name}");
Console.Write($"Departament: {worker.Departament.Name}");
Console.Write($"Income for: {monthAndYear} : {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");