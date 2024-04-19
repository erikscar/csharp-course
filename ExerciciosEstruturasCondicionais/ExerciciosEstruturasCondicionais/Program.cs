namespace ExerciciosEstruturasCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n1 = int.Parse(Console.ReadLine());
            //if(n1 < 0) Console.WriteLine("Negativo");
            //else Console.WriteLine("Positivo");

            //int n1 = int.Parse(Console.ReadLine());
            //if (n1 % 2 == 0) Console.WriteLine("PAR");
            //else Console.WriteLine("IMPAR");

            //string[] v = Console.ReadLine().Split(' ');
            //int a = int.Parse(v[0]);
            //int b = int.Parse(v[1]);

            //if(a % b == 0 || b % a == 0) Console.WriteLine("São Multiplos");
            //else Console.WriteLine("Não São Multiplos");

            //string[] v = Console.ReadLine().Split(' ');
            //int inicial = int.Parse(v[0]);          
            //int final = int.Parse(v[1]);

            //int duracao;
            //if (final > inicial) duracao = final - inicial;
            //else duracao = 24 - inicial + final;

            //Console.WriteLine("O JOGO DUROU " + duracao + " HORAS.");

            string[] v = Console.ReadLine().Split(' ');
            int codigo = int.Parse(v[0]);
            int quantidade = int.Parse(v[1]);
            double price;
            switch(codigo)
            {
                case 1: price = 4.00; break;
                case 2: price = 4.50; break;
                case 3: price = 5.00; break;
                case 4: price = 2.00; break;
                case 5: price = 1.50; break;
                default: Console.WriteLine("Opção Inválida"); break;
            }
            Console.WriteLine("Total: R${0}", (price * quantidade));

        }
    }
}
