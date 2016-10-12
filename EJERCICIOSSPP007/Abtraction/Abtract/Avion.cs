using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract
{
    public class Avion:Vehiculo,IAfip
    {
        public Avion(string patente) 
            : base(patente) 
        { }

        public override float CalcularCosto()
        {
            //throw new NotImplementedException();
            return 1500;
        }

        float IAfip.RetornarImpuesto()
        {
            return 3;
        }
       
    }
}
