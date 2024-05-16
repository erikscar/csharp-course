namespace DateTimeKindPadraoDeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boa Prática é Armazenar Datas no formato UTC, instanciar e mostrar em horário local

            DateTime d1 = DateTime.Now;

            DateTime d2 = d1.ToLocalTime();
            DateTime d3 = d2.ToUniversalTime();

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);


            Console.WriteLine("\n\nDateTimeKind");
            //Criando uma Data Indicando que está sendo utilizado o Horário Local
            DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            //Criando uma data Indicando que está sendo utilizado o Horário UTC
            DateTime d5 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d6 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Passando somente o DateTimeKind, o C# irá imprimir todas as datas da mesma forma
            //Porém Especificando o DateTimeKind, as funções ToLocalTime e ToUniversalTime 
            //Serão Utilizadas da forma correta
            Console.WriteLine("d4: " + d4);
            Console.WriteLine("d4 DateTimeKind: " + d4.Kind);
            Console.WriteLine("d4 ToLocal: " + d4.ToLocalTime());
            Console.WriteLine("d4 ToUtc: " + d4.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d5: " + d5);
            Console.WriteLine("d5 DateTimeKind: " + d5.Kind);
            Console.WriteLine("d5 ToLocal: " + d5.ToLocalTime());
            Console.WriteLine("d5 ToUtc: " + d5.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d6: " + d6);
            Console.WriteLine("d6 DateTimeKind: " + d6.Kind);
            Console.WriteLine("d6ToLocal: " + d6.ToLocalTime());
            Console.WriteLine("d6 ToUtc: " + d6.ToUniversalTime());
            Console.WriteLine();
        }
    }
}
