using System.Globalization;
namespace Sobrecarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //SOBRECARGA, gerando um Construtor Opcional, o que vai diferir é a quantidade de parâmetros passados
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }
        public Produto() { }
        //Construtor padrão, se codificarmos os contrutores o padrão não vai ser disponível
        //Para isso declarar ele vazio!
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}