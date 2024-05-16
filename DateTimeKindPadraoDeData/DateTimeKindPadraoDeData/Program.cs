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

            Console.WriteLine("\nEXEMPLOS PADRÃO ISO\n");
            //PADRÃO ISO 8601

            //Formato: yyyy-MM-ddTHH:mm:ssZ
            //Z indica que a data esta armazenada em formato de String e em UTC

            DateTime da1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime da2 = DateTime.Parse("2000-08-15T13:05:58Z"); //Irá transformar em UTC

            Console.WriteLine("da1: " + da1);
            Console.WriteLine("da1 Kind: " + da1.Kind);
            Console.WriteLine("da1 ToLocalTime: " + da1.ToLocalTime());
            Console.WriteLine("da1 ToUniversalTime/UTC: " + da1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("da2: " + da2);
            Console.WriteLine("da2 Kind: " + da2.Kind);
            Console.WriteLine("da2 ToLocalTime: " + da2.ToLocalTime());
            Console.WriteLine("da2 ToUniversalTime/UTC: " + da2.ToUniversalTime());
            Console.WriteLine();

            //Não Utilizar essa forma
            //Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));

            //UTilizar desse modo é mais correto, se não irá dar errado
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
