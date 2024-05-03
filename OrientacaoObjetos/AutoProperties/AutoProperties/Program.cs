namespace AutoProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 200.00, 10);

            Console.WriteLine(p.Nome);
            p.Nome = "Batatao";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            // p.Preco = 300.00; Não irá funcionar porque o set esta como private na classe!

            Console.WriteLine(p.Quantidade);
            p.AdicionarEstoque(10);
            Console.WriteLine(p.Quantidade);
            p.RemoverEstoque(2); ;
            Console.WriteLine(p.Quantidade);    
        }
    }
}
