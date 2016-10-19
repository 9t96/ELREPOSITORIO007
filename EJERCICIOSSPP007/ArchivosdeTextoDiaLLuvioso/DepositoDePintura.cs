using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosdeTextoDiaLLuvioso
{
    public class DepositoDePintura
    {
        public List<Producto> _misProductos;
        public int cantidadMax;

        public DepositoDePintura(int cantidad)
        {
            this.cantidadMax = cantidad;
            this._misProductos = new List<Producto>();
        }

        /// <summary>
        /// Agrega o no un produto a la lista.
        /// </summary>
        /// <param name="miprod"></param>
        /// <returns>True si agrego, false si no lo hizo.</returns>
        public bool Agregar(Producto miprod)
        {
            return this + miprod;
        }
        /// <summary>
        /// Informa si la lista tiene espacio para otro producto.
        /// </summary>
        /// <returns>true si hay espacio, false si no lo hay.</returns>
        public bool HayLugar()
        {
            return !(this._misProductos.Count == this.cantidadMax);
        }
        /// <summary>
        /// Informa si el producto ya se encuentra o no en la lista.
        /// </summary>
        /// <param name="miProd"></param>
        /// <returns>TRUE si ya se encuentra, FALSE si no se encuentra.</returns>
        public bool NoEsta(Producto miProd)
        {
            foreach (Producto item in this._misProductos)
            {
                if (item == miProd)
                    return false;
            }

            return true;
        }

        public static bool operator +(DepositoDePintura deposito, Producto miProducto)
        {
            if (deposito.HayLugar() && deposito.NoEsta(miProducto))
            {
                deposito._misProductos.Add(miProducto);
                return true;
            }

            return false;
                
        }
    }
}
