namespace PropriedadesEOperacoesDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);

            Console.WriteLine("1) Date: " + d.Date); //Desconsiderando o Horário
            Console.WriteLine("2) Day: " + d.Day); //Imprimindo Apenas o Dia
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek); //Dia da Semana
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear); //Dia do Ano
            Console.WriteLine("5) Hour: " + d.Hour); //Hora 
            Console.WriteLine("6) Kind: " + d.Kind); //Se é Local ou se é Global o Horário, por padrão é local
            Console.WriteLine("7) Millisecond: " + d.Millisecond); //Millisegundos
            Console.WriteLine("8) Minute: " + d.Minute); //Minutos
            Console.WriteLine("9) Month : " + d.Month); //Mês
            Console.WriteLine("10) Second: " + d.Second); //Segundo
            Console.WriteLine("11) Ticks: " + d.Ticks); //Ticks
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay); //Apenas Horário, um TimeSpan uma duraçao    
            Console.WriteLine("13) Year: " + d.Year); //Ano

            //Conversões
            Console.WriteLine("\n Conversões: ");
            Console.WriteLine(d.ToLongDateString()); //Data em um formato mais longo
            Console.WriteLine(d.ToLongTimeString()); //Tempo em um formato mais longo
            Console.WriteLine(d.ToShortDateString());//Data em um formato reduzido
            Console.WriteLine(d.ToShortTimeString());//Tempo em um formato reduzido
            Console.WriteLine(d.ToString()); //Data no formato normal + horário

            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss")); //Formatando manualmente
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.ffff")); //inserindo os millisegundos no final

            //Operações
            DateTime d2 = d.AddHours(2); //Adicionando 2 Horas
            DateTime d3 = d.AddMinutes(10); //Adicionando 10 Minutos 

            DateTime d4 = new DateTime(2000, 10, 15);
            DateTime d5 = new DateTime(2000, 10, 18);
            TimeSpan t = d5.Subtract(d4); //Diferença entre duas datas

            Console.WriteLine("\n Operações: ");
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(t);
        }
    }
}
