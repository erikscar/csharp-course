namespace GetHashCodeEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Equals retorna True ou False
            Console.WriteLine("EQUALS: ");
            string a = "Maria";
            string b = "João";

            string c = "Maria";
            string d = "Maria";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(c.Equals(d));

            //GetHashCode retorna um número que é obtido através de operações internas
            //Strings iguais retornam números iguais
            //Esses números mudam em cada execução

            //Se os código dos dois forem iguais muito provável que os objetos sejam iguais(mas pode haver coinciddÊncia)
            Console.WriteLine("\nGETHASHCODE: ");

            string f = "Jumento";
            string g = "Abelha";
            string h = "Jumento";

            Console.WriteLine(f.GetHashCode());
            Console.WriteLine(g.GetHashCode());
            Console.WriteLine(h.GetHashCode());
        }
    }
}
