using System.Globalization;

namespace IfTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estrutura Opcional ao IF, quando decidir um VALOR por uma CONDIÇÃO
            // ( condição ) ? valor_caso_verdadeiro : valor_caso_falso

            //Se o dois for maior do que o 4, imprimir 50 SE NÃO imprimir 80
            int x = (2 > 4) ? 60 : 80;

            //Se 10 for diferente do que 3 imprimir MARIA SE NÃO imprimir JOÃO
            string nome = (10 != 3) ? "Maria" : "João";


            //Se o Preço for maior do que 20 o desconto será de 10% SE NÃO o desconto será de 5%
            //Com ou Sem IF Ternário será o mesmo resultado, porém com o Ternário é mais simples e em uma linha!

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double discountIF = (price > 20) ? price * 0.1 : price * 0.05;
            double discount;

            if (price > 20) discount = price * 0.1;
            else discount = price * 0.05;

            Console.WriteLine("IF ELSE Padrão: " + discount);
            Console.WriteLine("IF Ternário: " + discountIF);

        }
    }
}
