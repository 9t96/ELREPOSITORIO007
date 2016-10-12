using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO47
{
    public class Pez:Animal,IMascota
    {
        private string _nombre;

        public Pez(int patas)
            :base(patas)
        { }

        public override void Comer()
        {
            Console.WriteLine("El animal come alimento para pez.");
        }

        public void Jugar()
        {
            Console.WriteLine("Este animal no juega...");
        }

        public override string Caminar()
        {
            return "Este animal no camina...";
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                _nombre = value;
            }
        }
    }
}
