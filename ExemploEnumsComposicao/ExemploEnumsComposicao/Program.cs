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
            var d1 = new Department(departmentName);

            Console.WriteLine("Enter Worker Data: ");
            Console.Write("Name: ");
            string wName = Console.ReadLine();

            Console.Write("Level (Junior / MidLevel / Senior");


            Console.Write("Base Salary: ");
            double wBaseSalary = double.Parse(Console.ReadLine());


            Console.Write("How Many Contracts to This Worker? ");
            int contractCounter = int.Parse(Console.ReadLine());


            int x = 0;
            while(x < contractCounter)
            {
                Console.WriteLine("Enter #" + (x + 1) + "Contract Data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                var contract = new HourContract(date, valuePerHour, hours);
            }
        }
    }
}
