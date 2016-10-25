using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces25OCT
{
    public class Familiar:Auto
    {
        public int _cantidadAsientos;

        public Familiar(string patente,double precio,int cantidadasientos)
            :base(precio,patente)
        {
            this._cantidadAsientos = cantidadasientos;
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
