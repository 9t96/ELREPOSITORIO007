using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract
{
    public abstract class Auto:Vehiculo
    {
        public int cantidadPuertas;

        public Auto(string patente)
            : base(patente)
        {     
        }

        public int CantidadPuertas
        {
            get { return cantidadPuertas; }
            set { cantidadPuertas = value; }
        }

        public override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("Patente: " + base.MostrarDatos());
            str.AppendLine("Puertas: " + this.CantidadPuertas);

            return str.ToString();
        }

    }
}
