using System.Globalization;

namespace ExercicioClasseAtributoMetodo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var retangulo = new Retangulo();

            Console.WriteLine("Entre a Largura e Altura do Retângulo");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Área: " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
