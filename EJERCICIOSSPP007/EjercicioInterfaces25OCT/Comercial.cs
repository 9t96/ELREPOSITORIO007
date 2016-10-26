using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces25OCT
{
    public class Comercial:Avion,IARBA
    {
        public Comercial(double precio, double velocidadMax)
            :base(precio,velocidadMax)
        { 
        
        }

        double IARBA.CalcularImpuesto()
        {
            return this.Precio * 1.25;
        }
    }
}
