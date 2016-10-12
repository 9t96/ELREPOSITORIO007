using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO47
{
    public interface IMascota
    {
        /// <summary>
        /// Como Juega la mascota.
        /// </summary>
        void Jugar();

        /// <summary>
        /// Propiedad get&set.
        /// </summary>
        string Nombre
        {
            get;
            set;
        }

    }
}
