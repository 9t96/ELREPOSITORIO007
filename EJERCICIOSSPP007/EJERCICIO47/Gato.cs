using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO47
{
    public class Gato:Animal,IMascota
    {
        private string _nombre;

        public Gato(int patas)
            :base(patas)
        { }

        public override void Comer()
        {
            Console.WriteLine("Este animal come alimento balanceado.");
        }

        public void Jugar()
        {
            Console.WriteLine("Este animal juega con bolas de lana.");
        }
        /// <summary>
        /// Propiedad get&set implementada de Imascota.
        /// </summary>
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

        public override string Caminar()
        {
            return string.Concat(base.Caminar() + " " + this._patas+" patas");
        }
    }
}
