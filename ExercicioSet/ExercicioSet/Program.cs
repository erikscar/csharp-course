using ExercicioSet.Entities;
using System.Globalization;

namespace ExercicioSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Users> users = new HashSet<Users>();

            Console.Write("Enter File Full Path: ");
            string path = Console.ReadLine();
            //C:\Users\eriks\Desktop\input.txt

            using (StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(" ");

                    users.Add(new Users(s[0], DateTime.Parse(s[1])));
                     
                }
                Console.WriteLine("Total Users: " + users.Count);
            }
        }
    }
}
