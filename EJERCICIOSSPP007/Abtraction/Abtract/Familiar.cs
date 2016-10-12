using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract
{
    public class Familiar:Auto
    {
        public Familiar(string patente) : base(patente) { }

        public override float CalcularCosto()
        {
            return 100;
            //throw new NotImplementedException();
        }
    }
}
