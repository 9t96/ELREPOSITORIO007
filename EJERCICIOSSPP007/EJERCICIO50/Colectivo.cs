using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO50
{
    public abstract class Colectivo
    {
        private int _numeroDeLinea;
        private int _numeroDeMovil;
        protected List<Pasajero> _listPasajeros;
        
        public abstract string colectivo();
    }
}
