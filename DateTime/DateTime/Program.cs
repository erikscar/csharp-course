using System;
using System.Globalization;

namespace DateTime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Representa um Instante
            //Armazena "ticks" = 100 nanosegundos desde meia noite do dia 1 de Janeiro do ano 1     

            DateTime d1 = DateTime.Now; //Instante Atual, ele não guarda isso
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); //Guarda os Ticks, calcula e devolve o instante atual

            //Ano, Mês e Dia
            DateTime d2 = new DateTime(2024, 05, 25);

            //Ano, Mês, Dia, Hora, Minuto e Segundo
            DateTime d3 = new DateTime(2025, 8, 28, 14, 18, 12);

            //Ano, Mês, Dia, Hora, Minuto, Segundo e Milisegundo, porém não leva em condideração os milisegundos
            DateTime d4 = new DateTime(2025, 8, 28, 14, 18, 12, 500);

            //Data de Hoje as 00 Horas
            DateTime d5 = DateTime.Today;

            //Instante em UTC / Horário Universal
            DateTime d6 = DateTime.UtcNow;

            //Podemos passar o horário com essa formatação que o C# converte para DateTime
            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");

            //Mesmo passando a formatação do Brasil o C# entende e converte
            DateTime d8 = DateTime.Parse("15/08/2000 20:4:58");

            //Determinar o PROPRIO FORMATO DA DATA, para que o C# possa entender qualquer tipo de Data
            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime d10 = DateTime.ParseExact("15/08/2000 15:05:59", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
        }
    }
}
