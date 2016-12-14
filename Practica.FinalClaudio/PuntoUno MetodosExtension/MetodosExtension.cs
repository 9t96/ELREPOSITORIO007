using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoUno_MetodosExtension
{
    public static class MetodosExtension
    {
        public static bool EsPar(this Int32 numero)
        {
            if (numero % 2 == 0)
                return true;

            return false;
        }

        public static bool EsImpar(this Int32 numero)
        {
            return !MetodosExtension.EsPar(numero);
        }
    }
}
