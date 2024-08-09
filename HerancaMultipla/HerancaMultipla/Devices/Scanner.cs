using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaMultipla.Devices
{
    internal class Scanner : Device, IScanner
    {
        //Vem do device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner Processing: " + document);
        }

        //Vem do IScanner
        public string Scan()
        {
            return "Sccaner Scan Result";
        }
    }
}
