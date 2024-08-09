using HerancaMultipla.Devices;

namespace HerancaMultipla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema, vamos supor que temos a classe Device Genérica, e Printer e Scanner Herdando ela
            //Porém se precisarmos de uma classe que Herde Scanner e Printer ao mesmo tempo haveria ambiguidade
            //Porque as 2 sobrescrevem o Método ProcessDoc da SuperClasse Abstrata, assim teremos que ter 
            //2 Process Doc na classe que herda Printer e Scanner!
            //Isso seria uma HERANÇA MULTIPLA o que não é permitido

            //Para Resolver isso utilizamos interface, assim a ComboDevice vai implementar o ProcessDoc
            //somente uma vez da classe Abstract, e as interfaces geram o restante dos métodos necessários

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My Letter");
            p.Print("My Letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My Dissertation");
            c.Print("My Dissertation");
            Console.WriteLine(c.Scan()); 
        }
    }
}
