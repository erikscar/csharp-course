using System.Globalization;

namespace ExercicioClasseAtributoMetodo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: " );
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as Três Notas do Aluno");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture ); 
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );  
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota Final: {0}", aluno.Media().ToString("F2", CultureInfo.InvariantCulture));
            aluno.Status();
        }
    }
}
