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

        public Araña(int patas)
            : base(patas)
        {
        }

        public override void Comer()
        {
            Console.WriteLine("Este animal come insectos.");
        }

        public void Jugar()
        {
            Console.WriteLine("JUEGA CON LA TELARAÑA");
        }

        public override string Caminar()
        {
            return string.Concat(base.Caminar()+" "+this._patas+" patas.");
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
