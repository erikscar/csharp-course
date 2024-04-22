using System.Globalization;

namespace ExerciciosEstruturasCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------

            //int n1 = int.Parse(Console.ReadLine());
            //if(n1 < 0) Console.WriteLine("Negativo");
            //else Console.WriteLine("Positivo");

            //----------------------------------------------------------------------

            //int n1 = int.Parse(Console.ReadLine());
            //if (n1 % 2 == 0) Console.WriteLine("PAR");
            //else Console.WriteLine("IMPAR");

            //----------------------------------------------------------------------

            //string[] v = Console.ReadLine().Split(' ');
            //int a = int.Parse(v[0]);
            //int b = int.Parse(v[1]);

            //if(a % b == 0 || b % a == 0) Console.WriteLine("São Multiplos");
            //else Console.WriteLine("Não São Multiplos");

            //----------------------------------------------------------------------

            //string[] v = Console.ReadLine().Split(' ');
            //int inicial = int.Parse(v[0]);          
            //int final = int.Parse(v[1]);

            //int duracao;
            //if (final > inicial) duracao = final - inicial;
            //else duracao = 24 - inicial + final;

            //Console.WriteLine("O JOGO DUROU " + duracao + " HORAS.");

            //----------------------------------------------------------------------

            //string[] v = Console.ReadLine().Split(' ');
            //int codigo = int.Parse(v[0]);
            //int quantidade = int.Parse(v[1]);
            //double price = 0;
            //switch(codigo)
            //{
            //    case 1: price = 4.00; break;
            //    case 2: price = 4.50; break;
            //    case 3: price = 5.00; break;
            //    case 4: price = 2.00; break;
            //    case 5: price = 1.50; break;
            //    default: Console.WriteLine("Opção Inválida"); break;
            //}
            //double total = price * quantidade;
            //Console.WriteLine("Total: R${0}", total.ToString("F2", CultureInfo.InvariantCulture));

            //----------------------------------------------------------------------

            //double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //if (valor >= 0 &&  valor <= 25) Console.WriteLine("Intervalo [0,25]");
            //else if (valor > 25 && valor <= 50) Console.WriteLine("Intervalo (25,50]");
            //else if (valor > 50 && valor <= 75) Console.WriteLine("Intervalo  (50,75]");
            //else if (valor > 75 && valor <= 100) Console.WriteLine("Intervalo (75,100]");
            //else Console.WriteLine("Fora do Intervalo");

            //----------------------------------------------------------------------

            //string[] v = Console.ReadLine().Split(' ');
            //double x = double.Parse(v[0]);
            //double y = double.Parse(v[1]);

            //if (x > 0 && y > 0) Console.WriteLine("Q1");
            //else if (x < 0 && y > 0) Console.WriteLine("Q2");
            //else if (x < 0 && y < 0) Console.WriteLine("Q3");
            //else if (x > 0 && y < 0) Console.WriteLine("Q4");
            //else if (x == 0 && y == 0)  Console.WriteLine("Origem");
            //else if (x == 0.0) Console.WriteLine("Eixo Y");
            //else if (y == 0.0)Console.WriteLine("Eixo X");

            //----------------------------------------------------------------------

            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double imposto = 0;

            //if (salario >= 0.00 && salario <= 2000.00) Console.WriteLine("Isento");
            //else if (salario >= 2000.01 && salario <= 3000.00) imposto = (salario - 2000.00) * 0.08;
            //else if (salario >= 3000.01 && salario <= 4500.00) imposto = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
            //else if (salario > 4500.00) imposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;

            //Console.WriteLine("R${0}", imposto.ToString("F2", CultureInfo.InvariantCulture));

            //----------------------------------------------------------------------

        }
    }
}
