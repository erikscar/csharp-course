using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Triangulo
    {
        public double A, B, C;

        public double Area() //Como o método só utiliza os atributos da classe, não é necessário parâmetros
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
