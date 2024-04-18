using System.Globalization;

namespace Exercícios_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"SOMA = {n1  + n2}");

            //double pi = 3.14159;
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double area = pi * raio * raio;
            //Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

            //int a, b, c, d;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());
            //d = int.Parse(Console.ReadLine());

            //Console.WriteLine($"DIFERENÇA {(a * b) - (c * d)}");

            //int funcionario = int.Parse(Console.ReadLine());
            //int horas = int.Parse(Console.ReadLine());  
            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double calculo = salario * horas;
            //Console.WriteLine("Number: " + funcionario);
            //Console.WriteLine("Salary: U$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));

            //string[] response1 = Console.ReadLine().Split(' ');
            //int r1 = int.Parse(response1[1]);
            //double r2 = double.Parse(response1[2], CultureInfo.InvariantCulture);

            //string[] response2= Console.ReadLine().Split(' ');
            //int r3 = int.Parse(response2[1]);
            //double r4 = double.Parse(response2[2], CultureInfo.InvariantCulture);
            //double resultado = r2 * r1 + r4 * r3;
            //Console.WriteLine("VALOR A PAGAR: R$ {0}", resultado.ToString("F2", CultureInfo.InvariantCulture));

            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);  
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);   
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2;
            double circulo = 3.14159 * c * c;
            double trapezio = ((a + b) * c) / 2;
            double quadrado = b * b;
            double retangulo = a * b;
            Console.WriteLine("TRIANGULO:  {0}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO:  {0}", circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO:  {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO:  {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO:  {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
