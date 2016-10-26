using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces25OCT
{
    public static class Gestion
    {

        static double MostrarImpuestoNacional(IAFIP bienpunible)
        {
            return bienpunible.CalcularImpuesto();
        }

        static double MostrarImpuestoProvincial(IARBA bienpunible)
        {
            return bienpunible.CalcularImpuesto();
        }


        
    }
}
