namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "João", "Jumento" };

            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]); 
            }

            Console.WriteLine("------------------------------------------------");
            foreach(var obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
