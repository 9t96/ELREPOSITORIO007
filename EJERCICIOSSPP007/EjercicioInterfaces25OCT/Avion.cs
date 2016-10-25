using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces25OCT
{
    public class Avion:Vehiculo,IAFIP,IARBA
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velocidadMax)
            : base(precio)
        {
            this.Precio = velocidadMax;
        }

        double IAFIP.CalcularImpuesto()
        {
            return this.Precio * 1.33;
        }


        public override double Precio
        {
            get
            {
                return base._precio;
            }
            set
            {
                this._precio = value;
            }
        }

        double IARBA.CalcularImpuesto()
        {
            throw new NotImplementedException();
        }
    }
}
