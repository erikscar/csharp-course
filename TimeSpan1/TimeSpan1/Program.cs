using System;

namespace TimeSpan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Em vez de Armazenar INSTANTE o TimeSpan armazena durações na forma de TICKS (100 Nanosegundos)

            TimeSpan t1 = new TimeSpan(0, 1, 30); //Hora Minuto e Segundo
            TimeSpan t2 = new TimeSpan(); //Criando um TimeSpan valendo 0
            TimeSpan t3 = new TimeSpan(900000000L); //Passando a Quantidade de Ticks, L porque é um Long
            TimeSpan t4 = new TimeSpan(15, 11, 21); //Hora Minuto e Segundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 30); //Dia Hora Minuto e Segundo 
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321); //Dia Hora Minuto e Segundo e Milisegundos

            //Criar um novo TimeSpan a partir de um dia, no Caso 1 Dia e Meio
            TimeSpan t7 = TimeSpan.FromDays(1.5);

            //Criar um novo TimeSpan a partir de um valor em horas, no Caso 1 Hora e Meia
            TimeSpan t8 = TimeSpan.FromHours(1.5);

            //Criar um novo TimeSpan a partir de um valor em minutos, no Caso 1 minuto e Meio
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);

            //Criar um novo TimeSpan a partir de um valor em segundos, no Caso 1 segundo e Meio
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);

            //Criar um novo TimeSpan a partir de um valor em Milisegundos, no Caso 1 milisegundo e Meio
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);

            TimeSpan t12 = TimeSpan.FromTicks(900000000L); //Só Aceita Long, porque Ticks são o menor valor
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);
        }
    }
}
