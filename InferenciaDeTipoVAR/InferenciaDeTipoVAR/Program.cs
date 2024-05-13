namespace InferenciaDeTipoVAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Palavra VAR para não precisar declarar tipos
            //C# Vai Inferir que o tipo é int 
            var x = 10;

            //C# Vai Inferir que o tipo é double 
            var y = 20.0;

            //C# Vai Inferir que o tipo é string
            var w = "Polenta";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(w);
        }
    }
}
