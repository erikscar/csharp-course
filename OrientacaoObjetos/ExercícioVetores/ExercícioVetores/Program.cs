namespace ExercícioVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("How Many Rooms Will be Rented? ");
            int n = int.Parse(Console.ReadLine());  
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nRent #" + (i + 1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                vect[numeroQuarto] = new Estudante(name, email);

            }
            Console.WriteLine("\nBusy Rooms: \n");
            
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]) ;
                }
            }

        }
    }
}
