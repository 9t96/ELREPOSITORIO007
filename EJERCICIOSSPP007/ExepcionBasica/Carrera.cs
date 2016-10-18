using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionBasica
{
    public class Carrera
    {
        public List<Auto> _miList;
        public string autodromo;

        public Carrera(string nombre)
        {
            _miList = new List<Auto>();
            autodromo = nombre;
            
            if (nombre != "ChacoRace")
                throw new NombreAutodromoException("El autodromo no es chaco", DateTime.Now);
            
            autodromo = nombre;
        }

        public void CorrerCarrera()
        {
            if (this._miList.Count == 0)
                throw new miExcepcion("ListaVacia",DateTime.Now);
            else
                foreach (var item in this._miList)
                {
                    item.Andar();
                }
        }
    }
}
