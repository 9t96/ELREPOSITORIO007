using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosdeTextoDiaLLuvioso
{
    public class Vehiculo
    {
        public string marca;
        public string color;
        public string patente;

        public Vehiculo(string marca, string color, string patente)
        {
            this.patente = patente;
            this.marca = marca;
            this.color = color;
        }

        public static bool operator ==(Vehiculo vUno, Vehiculo vDos)
        {
            return (vUno.patente == vDos.patente);
        }

        public static bool operator !=(Vehiculo vUno, Vehiculo vDos)
        {
            return !(vUno.patente == vDos.patente);
        }

        public override bool Equals(object obj)
        {
            if (obj is Vehiculo)
                return this == ((Vehiculo)obj);

            return false;
        }


    }
}
