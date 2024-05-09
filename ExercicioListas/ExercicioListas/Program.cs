using System.Globalization;

namespace ExercicioListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How Many Employees Will be Registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEmployee: #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, name, salary));
            }

            Console.Write("\nEnter the Employee Id That Will Have Salary Increase: ");
            int findId = int.Parse(Console.ReadLine());
            Funcionario increase = funcionarios.Find(x => x.Id == findId);

            if(increase == null)
            {
                Console.WriteLine("This ID does not Exist!");
            } else
            {
                Console.Write("Enter the Percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                increase.IncreaseSalary(percentage);
            }

            Console.WriteLine("\nUpdated List of Employees: ");
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(
                    funcionario.Id + ", " + 
                    funcionario.Name + ", " + 
                    funcionario.Salary.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }

        }
    }
}
