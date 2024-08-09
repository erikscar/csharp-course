using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaMultipla.Devices
{
    //Não podemos herdar 2 classes, mas podemos herdar interface e classes
    internal class Printer : Device, IPrinter
    {
        //Vem do Device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer Processing: " + document);
        }

        //Vem do IPrinter
        public void Print(string document)
        {
            Console.WriteLine("Printer Print " + document);
        }
    }
}
