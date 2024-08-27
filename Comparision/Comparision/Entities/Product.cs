using System.Globalization;

namespace Comparision.Entities
{
    internal class Product //: IComparable<Product>   
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

        //Porém a classe não ficará fechada, algo que deve ser de acordo com SOLID, se por acaso devemos mudar a comparação,
        //vamos ter que alterar a classe
        //public int CompareTo(Product other)
        //{
        //    //A comparação vai ser feita desconsiderando maisculas com minusculas já que todas serão maiusculas
        //    return Name.ToUpper().CompareTo(other.Name.ToUpper());  
        //}
    }
}
