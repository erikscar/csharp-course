using InterfaceIComparable.Entities;

namespace InterfaceIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\eriks\Desktop\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    //List<string> list = new List<string>();
                    List<Employee> employees = new List<Employee>();
                    while(!sr.EndOfStream)
                    {
                        employees.Add(new Employee(sr.ReadLine()));
                    }
                    employees.Sort(); //Ordenando a Lista em Ordem  Alfábetica
                    //Utilizando o Employee não será possível realizar isso devemos Implementar a IComparable
                    foreach(Employee emp in employees)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An Error Ocurred: " + e.Message);
            }
        }
    }
}
