using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioInterfaces25OCT
{
    public class Carreta:Vehiculo,IARBA
    {
        public Carreta(double precio)
             :base(precio)
        {
            
        }

        public double CalcularImpuesto()
        {
            return this.Precio * 1.18;
        }

        public override double Precio
        {
            get
            {
                return base._precio;
            }
            set
            {
                base._precio = value;
            }
        }

    }
}
