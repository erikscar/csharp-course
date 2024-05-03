using System.Globalization;
namespace Properties
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Properties Servem para evitar o uso de vários get e set no programa, são altamente recomendadas
        //Então utilizamos dessa forma elas:

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value; // A diferença e utilizar a palavra "value" para os parametros 
                }
            }
        }
        //Caso não definirmos o "SET" não será possível modificar porque teremos apenas o get
        //E para utilizar o a Property utilizar apenas o nome dela
        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade;  }
        }

        //public string GetNome()
        //{
        //    return _nome;
        //}
        //public void SetNome(string nome)
        //{
        //    if (nome != null && nome.Length > 1)
        //    {
        //        _nome = nome;
        //    }
        //}
        //public double GetPreco()
        //{
        //    return _preco;
        //}
        //public int GetQuantidade()
        //{
        //    return _quantidade;
        //}

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}