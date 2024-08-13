using System.Globalization;

namespace RestricoesGenerics.Entities
{
    internal class Product : IComparable //Implementando a interface se não a comparação do programa n funciona
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Product)) //Se não for um Produto dar erro
            {
                throw new ArgumentException("Comparing Error: Argument is not a Product");
            }

            Product other = obj as Product; //FAzendo um casting 

            return Price.CompareTo(other.Price);
        }
    }
}
