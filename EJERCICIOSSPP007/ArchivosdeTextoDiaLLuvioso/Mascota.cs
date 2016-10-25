using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosdeTextoDiaLLuvioso
{
    public class Mascota
    {
        public string nombre;
        public string raza;

        public Mascota(string nombre, string raza) 
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("Nombre: " + this.nombre);
            str.AppendLine("Raza: " + this.raza);

            return str.ToString();
        }

        public static bool operator ==(Mascota mUno, Mascota mDos)
        {
            return (mUno.raza == mDos.raza && mUno.nombre == mDos.nombre);
        }

        public static bool operator !=(Mascota mUno, Mascota mDos)
        {
            return !(mUno.raza == mDos.raza && mUno.nombre == mDos.nombre);
        }

        public override bool Equals(object obj)
        {
            if (obj is Mascota)
                return this == ((Mascota)obj);

            return false;
        }

    }
}
