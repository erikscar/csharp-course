namespace PropriedadesEOperacoesTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue; //Obter o Maior Valor de um TimeSpan
            TimeSpan t2 = TimeSpan.MinValue; //Obter o Menor Valor de um TimeSpan (pode ter negativo)
            TimeSpan t3 = TimeSpan.Zero; //Obter o Valor 0 de um TimeSpan

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);
            Console.WriteLine("\nNúmeros Inteiros: ");
            Console.WriteLine("Days: " + t.Days); //Quantidade de Dias de um TimeSpan
            Console.WriteLine("Hours: " + t.Hours); //Quantidade de Horas de um TimeSpan
            Console.WriteLine("Minutes: " + t.Minutes); //Quantidade de Minutos de um TimeSpan 
            Console.WriteLine("Milliseconds: " + t.Milliseconds); //Quantidade de Millisegundos de um TimeSpan
            Console.WriteLine("Seconds: " + t.Seconds); //Quantidade de Segundos de um TimeSpan
            Console.WriteLine("Ticks: " + t.Ticks); //Quantidade de Ticks

            Console.WriteLine("\nFração dos Números");
            Console.WriteLine("TotalDays: " + t.TotalDays); //Quantidade de Dias
            Console.WriteLine("TotalHourse: " + t.TotalHours); //Quantidade de Horas
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes); //Quantidade de Minutos
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds); //Quantidade de Segundos
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds); //Quantidade de Millisegundos

            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t5.Add(t6); //Somando um TimeSpan com outro
            TimeSpan dif = t5.Subtract(t6); //Subtraindo um TimeSpan com o outro
            TimeSpan mult = t6.Multiply(2.0); //Multiplicando um TimeSpan por 2.0 (double)
            TimeSpan div = t6.Divide(2.0); //Dividindo um TimeSpan por 2.0 (double)

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

        }
    }
}
