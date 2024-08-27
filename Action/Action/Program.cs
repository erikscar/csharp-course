using Action.Entities;

namespace Action
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Mouse", 50.0));
            list.Add(new Product("TV", 350.5));
            list.Add(new Product("TV", 80.9));

            //Recebe um delegate Action no qual tem a assinatura necessariamente,
            //retornando um void e recebendo como parâmetro UM OU MAIS OBJETOS
            
            //Podemos salvar em uma váriavel ou apenas passar o nome no ForEach
            Action<Product> act = UpdatePrice;

            //Como é um método void temos que abrir chaves
            Action<Product> act2 = p => { p.Price += p.Price * 0.1; }; //Mesma forma com expressão Anonima Lambda

            //list.ForEach(act2);
            list.ForEach(p => { p.Price += p.Price * 0.1; }); //Mesma forma mas passando direto para a função
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }


        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
