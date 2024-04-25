namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //    Console.WriteLine("Par");
            //else
            //    Console.WriteLine("Impar");

            int hora = int.Parse(Console.ReadLine());

            //Dessa forma irá funcionar, porém mesmo após a primeira condição se tornar verdadeira
            //O programa não saberá quando se encerrar, assim passará por todas as condições
            ////Álém de poder ocorrer erros, como esquecer >=.
            //if (hora < 12)
            //    Console.WriteLine("Bom Dia!");
            //if (hora >= 12 && hora < 18)
            //    Console.WriteLine("Boa Tarde1");
            //if (hora >= 18)
            //    Console.WriteLine("Boa Noite!");

            //------------------------------------------------------------------------------------------------

            //Melhor forma
            if (hora < 12)
                Console.WriteLine("Bom dia!");
            else if (hora < 18) // O Programa já sabe que a hora é menor do que 12, assim é necessário só testar
                Console.WriteLine("Boa Tarde"); //se a hora é menor do que 18!
            else //Se as duas condições se tornarem falsa ele executará a condição que resta
                Console.WriteLine("Boa Noite");

        }
    }
}
