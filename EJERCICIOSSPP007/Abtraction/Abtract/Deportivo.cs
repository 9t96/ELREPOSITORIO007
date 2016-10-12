using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract
{
    public class Deportivo:Auto,IAfip
    {
        public Deportivo(string patente) : base(patente) { }

        public override float CalcularCosto()
        {
            return 150;
            //throw new NotImplementedException();
        }

        float IAfip.RetornarImpuesto()
        {
            return 2;
        }
    }
}
