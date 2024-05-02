using System.Globalization;

namespace Construtores
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Ao instanciar um Produto será obrigado a Informar esses dados
        //O Construtor tem que ter o mesmo nome da Classe
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
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
            return Nome + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " 
                + Quantidade + " Unidades" + " Total: $" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
