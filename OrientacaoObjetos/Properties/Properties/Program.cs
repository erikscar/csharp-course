namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Produto("TV", 200.00, 10);

            Console.WriteLine(p1.Nome);

            p1.Nome = "TV4K"; //Utilizando somente o nome da property podemos utilizar seu "SET"
                              //E Modificar o valor conforme a regra passada na property

            Console.WriteLine(p1.Nome); //Utilizando somente o nome da property podemos utilizar seu "GET"

        }
    }
}
