using System.Globalization;

namespace ExercicioComOrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classes Também são TIPOS!!!
            Triangulo x, y;

            //Instanciando uma classe, logo isso será um objeto!
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as Medidas do Triângulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as Medidas do Triângulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt((p * (p - x.A) * (p - x.B) * (p - x.C)));
            Console.WriteLine("Área de X: {0}", areaX.ToString("F4", CultureInfo.InvariantCulture));
           
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt((p * (p - y.A) * (p - y.B) * (p - y.C)));
            Console.WriteLine("Área de Y: {0}", areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) Console.WriteLine("Maior Área: X");
            else Console.WriteLine("Maior Área: Y");
        }
    }
}
