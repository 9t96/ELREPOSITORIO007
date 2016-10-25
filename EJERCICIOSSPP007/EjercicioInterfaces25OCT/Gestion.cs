using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces25OCT
{
    public static class Gestion
    {

        public double MostrarImpuestoNacional(IAFIP bienpunible)
        {
            return bienpunible.CalcularImpuesto();
        }

        public double MostrarImpuestoProvincial(IARBA bienpunible)
        {
            return bienpunible.CalcularImpuesto();
        }


        
    }
}
