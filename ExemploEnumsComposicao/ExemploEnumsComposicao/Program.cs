using ExemploEnumsComposicao.Entities;
using ExemploEnumsComposicao.Entities.Enums;
using System.Globalization;

namespace ExemploEnumsComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department's Name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter Worker Data: ");
            Console.Write("Name: ");
            string wName = Console.ReadLine();

            Console.Write("Level (Junior / MidLevel / Senior");
            WorkerLevel wLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double wBaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var department = new Department(departmentName);

            var worker = new Worker(wName, wLevel, wBaseSalary, department);

            Console.Write("How Many Contracts to This Worker? ");
            int n = int.Parse(Console.ReadLine());
          
            for (int i = 0; i <= n; i++) 
            {
                Console.WriteLine($"Enter #{i} Contract Data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                var contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter a Month and Year to Calculate Income (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for: " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
