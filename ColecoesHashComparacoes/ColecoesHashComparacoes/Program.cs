using ColecoesHashComparacoes.Entities;

namespace ColecoesHashComparacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5 ,10));

            //Esse vai ser um objeto diferente dentro da memória do que foi inserido
            Product prod = new Product("Notebook", 1200.0);

            //Embora os dados do Produto sejam iguais, os endereços de memória são diferentes!
            //E Product é um tipo Referência
            //POREM SE IMPLEMENTARMOS O GETHASHCODE E O EQUALS ELE VAI RETORNAR TRUE
            Console.WriteLine(a.Contains(prod));

            //Agora ele irá retornar true, porque é um dado do TIPO VALOR e ele vai comparar o valor dos atributos
            Point point = new Point(3, 4);
            Console.WriteLine(b.Contains(point));
        }
    }
}
