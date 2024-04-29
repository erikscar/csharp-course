using System.Globalization;

namespace ExemploDeProblema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); //Variável Composta

            Console.WriteLine("Entre os Dados do Produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no Estoque");
            p.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do Produto: " + p); Não FUNCIONA Imprimir apenas o Objeto!
            //Com a Implementação do override toString, implicitamente irá imprimir o que foi codificado
            //no método da classe

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o Número de Produtos a serem Adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o Número de Produtos a serem Removidos do Estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }
}
