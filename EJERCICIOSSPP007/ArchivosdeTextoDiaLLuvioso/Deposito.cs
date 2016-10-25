using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosdeTextoDiaLLuvioso
{
    public class Deposito<T>:IEnumerable<T>
    {
        public List<T> _misProductos;
        public int cantidadMax;

        public Deposito(int cantidad)
        {
            this.cantidadMax = cantidad;
            this._misProductos = new List<T>();
        }

        /// <summary>
        /// Agrega o no un produto a la lista.
        /// </summary>
        /// <param name="miprod"></param>
        /// <returns>True si agrego, false si no lo hizo.</returns>
        public bool Agregar(T miprod)
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
        public bool NoEsta(T algo)
        {
            foreach (T item in this._misProductos)
            {
                if (item.Equals(algo))
                    return false;
            }

            return true;
        }

        public static bool operator +(Deposito<T> deposito, T item)
        {
            if (deposito.HayLugar() && deposito.NoEsta(item))
            {
                deposito._misProductos.Add(item);
                return true;
            }

            return false;
                
        }



        public IEnumerator<T> GetEnumerator()
        {
            return new _misprd
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }
}
