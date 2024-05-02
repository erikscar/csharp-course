using System.Globalization;

namespace Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para Evitar um Produto Nulo Utilizar o Construtor e instanciar ja com valores

            Console.WriteLine("Entre os Dados do Produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int qtde = int.Parse(Console.ReadLine());
            
            Produto p = new Produto(nome, preco, qtde);


            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o Número de Produtos a serem Adicionados ao Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);


            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o Número de Produtos a serem Removidos do Estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
        }
    }
}
