using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaMultipla.Devices
{
    //Não podemos herdar várias classes mas podemos herdar várias interfaces
    internal class ComboDevice : Device, IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine("Combo Device Print: " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combo Device Processing: " + document);
        }

        public string Scan()
        {
            return "Combo Device Scan Result";
        }
    }
}
