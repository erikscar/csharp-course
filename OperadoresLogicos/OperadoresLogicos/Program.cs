namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operadores Lógicos: ! > && > || (Em Ordem de Precedência)

            bool x1 = 2 > 3 && 4 != 5; // false
            bool c1 = 2 > 3 || 4 != 5; //true
            bool c2 = !(2 > 3) && 4 != 5; //true
            bool c3 = 10 < 5; //false
            bool c4 = c1 || c2 && c3; //true

            Console.WriteLine(x1);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
        }
    }
}
