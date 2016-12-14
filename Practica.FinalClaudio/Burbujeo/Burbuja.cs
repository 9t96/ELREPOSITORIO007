using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbujeo
{
    public class Burbuja
    {
        public void Instancia()
        {
            throw new Exception("Metodo instancia");
        }

        public static void Estatico(Burbuja clase)
        {
            try
            {
                clase.Instancia();
            }
            catch (Exception e)
            {

                throw new Exception("Metodo de instacia + metodo estatico",e);
            }
        }
    }
}
