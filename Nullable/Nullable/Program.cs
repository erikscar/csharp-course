namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double é um valor não nullable, não funciona double x = null;

            //São váriaves Opcionais
            
            Nullable<double> x = null; //Dessa forma o C# Aceita

            double? y = 10; //Mesma coisa ( RECOMENDADO )

            //Pegar o valor de x ou obter o valor padrão do tipo
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Verificar se a variável tem algum valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Lançar um Erro / Exceção se tentarmos utilizar uma varável que tem nulo
            //Se tiver um número imprime o número
            if(x.HasValue) Console.WriteLine(x.Value);
            else Console.WriteLine("X is Null");

            if (y.HasValue) Console.WriteLine(y.Value);
            else Console.WriteLine("Y is Null");

            Console.WriteLine();
            Console.WriteLine("OPERADOR DE COALESCÊNCIA NULA");
            //Serve para se um valor for nulo ele executa a outra ação 
            //Como se fosse um IF
            double? n1 = null;
            double? n2 = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

    }
}
