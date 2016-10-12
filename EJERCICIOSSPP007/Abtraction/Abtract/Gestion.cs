using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract
{
    public class Gestion
    {
        public static float MostrarImp(IAfip algo)
        {
            return algo.RetornarImpuesto();
        }

    }
}
