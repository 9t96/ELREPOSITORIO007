using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces25OCT
{
    public class Privado:Avion
    {
        public Privado(float precio,float velocidadMax)
            :base(precio,velocidadMax)
        {}

    }
}
