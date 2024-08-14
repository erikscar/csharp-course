using System;
using GetHashCodeEquals1.Entities;

namespace GetHashCodeEquals1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Com o Equals Personalizado, setamos o objeto como sendo iguais se os emails forem igual
            Client c1 = new Client("Maria", "maria@gmail.com");
            Client c2 = new Client("Alex", "alex@gmail.com");

            //Retornará false, porque os Emails são diferentes
            Console.WriteLine(c1.Equals(c2));

            Client c3 = new Client("Maria", "maria@gmail.com");
            Client c4 = new Client("Alex", "maria@gmail.com");

            //Retornará true, porque os Email são iguais
            Console.WriteLine(c3.Equals(c4));

            //Pegando os HashCodes apenas dos emails
            Console.WriteLine(c3.GetHashCode());
            Console.WriteLine(c4.GetHashCode());
        }
    }
}
