using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto<T> : IArchivo<T>
    {
        public bool guardar(string archivo, T datos)
        {
            throw new NotImplementedException();
        }

        public bool leer(string archivo, out T datos)
        {
            throw new NotImplementedException();
        }
    }
}
