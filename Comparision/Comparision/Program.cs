using Comparision.Entities;

namespace Comparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Tablet", 450.00));

            //Dessa forma devemos utlizar a interface IComparable
            //products.Sort();

            //Passando somente a referência da função estática, e não passando os parâmetros CHAMAMOS DE DELEGATE
            //Isso porque o Delegate Comparision que é uma sobrecarga do SORT aceita uma função desse mesmo jeito criado
            //products.Sort(CompareProduct)

            //Comparison<Product> comp = CompareProduct;
          
            //products.Sort(comp); //Ou só passar a referência da função

            //DESSA FORMA NAO PRECISAMOS NEM DECLARAR UMA FUNÇÃO PODEMOS APENAS PASSAR UMA EXPRESSÂO LAMBDA (ANÔNIMA) para o Comparison
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //products.Sort(comp);

            products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); //E A MESMA COISA

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
        //static int CompareProduct(Product product1, Product product2)
        //{
        //    //Mesma implementação do CompareTo, comparando 2 produtos pelo nome
        //    return product1.Name.ToUpper().CompareTo(product2.Name.ToUpper());
        //}
    }
}
