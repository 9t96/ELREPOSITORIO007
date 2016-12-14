using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoTres_Deposito
{
    public class ProdImpuesto:Producto
    {
        public ProdImpuesto()
        {
        
        }

        public ProdImpuesto(string nombre, int stock)
            :base(stock,nombre)
        {

        }
    }
}
