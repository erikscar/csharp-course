using Func.Entities;

namespace Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Delegate FUNC, tem como assinatura retornar algum valor e receber um ou mais objetos!
            //Função do Linq que retorna uma coleção de um array de acordo com uma condição, recebe  um FUNC
            //E deve se converter para ToList, pq retorna um IEnumerable genérico

            //Podemos passar a referência de uma função que contém uma assinatura válida para FUNC
            //List<string> result = list.Select(NameUpper).ToList();

            //Func<Product, string> func = NameUpper; //Utilizando o delegate e salvando a referência da função
            //List<string> result = list.Select(func).ToList();

            //Utilizando expressão anônima Lambda e armazenando em uma variável
            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<string> result = list.Select(func).ToList();

            //Podemos passar aa Lambda diretamente para a função
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
