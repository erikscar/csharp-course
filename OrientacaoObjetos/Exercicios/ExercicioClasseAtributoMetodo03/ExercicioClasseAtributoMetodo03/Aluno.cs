using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseAtributoMetodo03
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Media()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public void Status()
        {
            if (Media() <= 60)
            {
              Console.WriteLine("Reprovado" );
               Console.WriteLine("Faltaram {0} Pontos", (60 - Media()).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
        }
    }
}
