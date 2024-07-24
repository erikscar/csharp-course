
using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Supondo que tentamos dividir um número por 0, o programa irá "estourar" o Stack Trace que é o rastreamento da execução
                //e o Programa irá encerrar para isso n acontecer podemos capturar a exceção em um bloco try catch
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            //catch(Exception e) //Forma mais genérica de se tratar uma exceção, IRA SER CAPTURADO QUALQUER EXCEÇÃO QUE OCORRER
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}
            catch (DivideByZeroException ex) //Porém sempre é melhor obter da forma menos genérica possível
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)//Podemos encadear quantos catch precisar, e não precisamos necessariamente utilizar o argumento passado
            {
                Console.WriteLine("Tente Utilizar Apenas Números Inteiros");
            }

        }
    }
}
