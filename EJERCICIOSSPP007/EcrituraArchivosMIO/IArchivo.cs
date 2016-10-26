using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcrituraArchivosMIO
{
    interface IArchivo
    {
        bool Guardar(string archivo, Persona datos);
        bool Leer(string archivo, Persona datos);
    }
}
