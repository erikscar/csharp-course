using Delegates.Services;

namespace Delegates
{
    //Declarando um delegate, ele vai servir de referência a uma FUNÇÃO QUE RETORNA DOUBLE E POSSUI 2 PARAMETROS DOUBLE
    //para utilizar ele precisa necessariamente cumprir seu requisito

    delegate double BinaryOperation(double x, double y);
    delegate void AnotherOperation(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 12.0;

            Console.WriteLine(CalculationService.Max(a, b));
            Console.WriteLine(CalculationService.Sum(a, b));
            Console.WriteLine(CalculationService.Square(a));

            //Utilizando o delegate para salvar a função dentro da variável op
            BinaryOperation op = CalculationService.Sum;
            BinaryOperation op1 = new BinaryOperation(CalculationService.Sum); //É a mesma coisa

            //E depois utilizar a variável como se fosse uma função e nos trará o mesmo resultado
            Console.WriteLine("Delegate SUM: " + op(a, b));
            Console.WriteLine("Delegate SUM: " + op.Invoke(a, b)); //É a mesma coisa
            Console.WriteLine();

            //MULTICAST DE DELEGATE, podemos adicionar 2 funções dentro de um tipo delegate
            //Assim ele automaticamente irá realizar as 2 funções, FAZ SENTIDO EM MÉTODOS VOID!
            AnotherOperation operation = CalculationService.ShowSum;
            operation += CalculationService.ShowMax;

            operation.Invoke(a, b);
            operation(a, b);
        }
    }
}
