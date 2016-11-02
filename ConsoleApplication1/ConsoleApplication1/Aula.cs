using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
 
    public class Aula
    {
        public int numero;
        public List<Persona> miList;
        public Persona profesor;

        public Aula()
        { 
            
        }

        public Aula(int number,Persona teacher)
        {
            miList = new List<Persona>();
            numero = number;
            profesor = teacher;

        }

    }
}
