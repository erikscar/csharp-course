namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encapsulamento serve para deixar acessível ao usuário apenas o necessário
            Produto p = new Produto("TV", 500.00, 10);

            //p._nome = "Batata"; //Não é possível modificar o Nome porque é private para isso utilizar o set ou o get
            Console.WriteLine(p.GetNome());
            //Dessa forma irá ser alterado de acordo com uma lógica definida na classe e não como bem entender
            p.SetNome("TV4K");
            Console.WriteLine(p.GetNome());


        }
    }
}
