using Predicate.Entites;

namespace Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Mouse", 50.0));
            list.Add(new Product("Tablet", 350.5));
            list.Add(new Product("HD Case", 80.9));

            //O Método RemoveAll recebe um delegate o chamado PREDICATE, podemos fazer dessa forma
            //list.RemoveAll(p => p.Price >= 100); //Removendo todos os produtos que possuem o preço maior que 100
            //Leitura: Recebe um produto da lista e remover o produto tal que ele tenha seu preço menor do que 100

            //Ou podemos apenas passar a função com a assinatura igual a o delegate PREDICATE que irá resultar a mesma coisa
            list.RemoveAll(ProductTest);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //Essa é a mesma assinatura do Predicate, recebe como parâmetro um objeto e retorna um boll
        static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}
