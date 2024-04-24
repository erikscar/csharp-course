namespace ExerciciosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int senha = int.Parse(Console.ReadLine());

            //while(senha != 2002)
            //{
            //    Console.WriteLine("Acesso Negado");
            //    senha = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Acesso Permitido");

            //string[] v = Console.ReadLine().Split(' ');
            //int x = int.Parse(v[0]);  
            //int y = int.Parse(v[1]);
            //while (x != 0 || y != 0)
            //{
            //    if (x > 0 && y > 0) Console.WriteLine("Q1");
            //    if (x < 0 && y > 0) Console.WriteLine("Q2");
            //    if (x < 0 && y < 0) Console.WriteLine("Q3");
            //    if (x > 0 && y < 0) Console.WriteLine("Q4");
            //    v = Console.ReadLine().Split(' ');
            //    x = int.Parse(v[0]);
            //    y = int.Parse(v[1]);
            //}

            int produto = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (produto != 4)
            {
                if (produto == 1)
                {
                    alcool++;
                    Console.WriteLine("Alcool: {0}", alcool);
                }
                else if (produto == 2)
                {
                    gasolina++;
                    Console.WriteLine("Gasolina: {0}", gasolina);
                }
                else if (produto == 3)
                {
                    diesel++;
                    Console.WriteLine("Diesel: {0}", diesel);
                }
                produto = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado!");
        }
    }
}
