using HerancavsInterface.Model.Entities;
using HerancavsInterface.Model.Enums;

namespace HerancavsInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando dessa forma, Abstract + Interface podemos ter sempre a implementação da Area
            //por causa da interface e agora não necessariamente precimaos ter uma cor da Classe Abstract
            //Podemos apenas implementar a Interface como Herança e ignorar a classe Abstract
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
