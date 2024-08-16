namespace ExercicioSet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            Console.Write("How Many Students for Course A? ");
            int a = int.Parse(Console.ReadLine());

            for(int i = 0;  i < a; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set.Add(number);
            }

            Console.Write("How Many Students for Course B? ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set.Add(number);
            }

            Console.Write("How Many Students for Course C? ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set.Add(number);
            }

            Console.WriteLine("Total Students: " + set.Count);
        }
    }
}
