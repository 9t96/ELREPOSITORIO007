using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO47
{
    public class Araña : Animal, IMascota
    {
        private string _nombre;

        public Araña(int patas) : base(patas)
        {
        }

        /// <summary>
        /// Propiedad get&set implementada de IMascota.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.
            }

            set
            {
                
            }
        }

        public override void Comer()
        {
            Console.WriteLine("Este animal come insectos.");
        }

        public void Jugar()
        {
            Console.WriteLine("JUEGA CON LA TELARAÑA");
        }
    }
}
