namespace AutoProperties
{
    internal class Produto
    {
        private string _nome;
        //Auto Property, elas são utilizadas SOMENTE QUANDO NÃO PRECISA DE LÓGICA DE IMPLEMENTAÇÃO DOS SET E GET
        public double Preco {  get; private set; } //Além de deixar o set não utilizável
        public int Quantidade { get; private set; }

        public Produto () {}
        public Produto (string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Se tiverem lógica no get ou set utilizaremos a forma normal
        public string Nome
        {
            get { return _nome; }
            set { 
                if(value != null && value.Length > 1)
                _nome = value; 
            }
        }

        public double ValorTotalEmEstoque ()
        {
            return Preco * Quantidade;
        }
        public void AdicionarEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
