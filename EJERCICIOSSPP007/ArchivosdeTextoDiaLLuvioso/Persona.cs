using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosdeTextoDiaLLuvioso
{
    public class Persona
    {
        public string nombre;
        public int dni;

        public Persona(string nombre, int dni)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public static bool operator ==(Persona pUno, Persona pDos)
        {
            return (pUno.dni == pDos.dni);
        }

        public static bool operator !=(Persona pUno, Persona pDos)
        {
            return !(pUno.dni == pDos.dni);
        }

        public override bool Equals(object obj)
        {
            if (obj is Persona)
                return this == ((Persona)obj);

            return false;

        }


    }
}
