using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    
    public class Alumno:Persona
    {
        public int legajo;

        public Alumno()
        { }

        public Alumno(string nombre, int legajo)
            : base(nombre)
        {
            this.legajo = legajo;
            
        }

    }
}
