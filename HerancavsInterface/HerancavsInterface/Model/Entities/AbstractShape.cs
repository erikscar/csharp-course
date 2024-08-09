using HerancavsInterface.Model.Enums;

namespace HerancavsInterface.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area(); //Ele Reproduz o Método da Interface
    }
}
