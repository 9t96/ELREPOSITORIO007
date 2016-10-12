using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndexador
{
    public class Laboratorio
    {
        public string nombre;
        public List<PC> _listPc;

        public Laboratorio(string nombre)
        {
            this.nombre = nombre;
            _listPc = new List<PC>();
        }

        public PC this[int indice]
        {
            get
            {
                if (indice >= 0 && indice < this._listPc.Count)
                    return this._listPc[indice];
                else
                    return null;
            }

            set 
            {
                if (indice == _listPc.Count)
                    _listPc.Add(value);
                else
                {
                    if (indice >= 0 && indice < this._listPc.Count)
                        this._listPc[indice] = value;
                }
            }
        }
    }
}
