using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioInterfaces25OCT
{
    public class Carreta:Vehiculo
    {
        public Carreta(double precio)
             :base(precio)
        {
            
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
