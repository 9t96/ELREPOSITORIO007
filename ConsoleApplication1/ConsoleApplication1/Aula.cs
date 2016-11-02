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
        private List<Persona> miList;
        public Persona profesor;
        private string _nombreAula;

        //Solamente serializa una atributo privado, si y solo si, el atributo tiene que tener GET y SET.
        public string NombreAula
        {
            get { return _nombreAula; }
            set { _nombreAula = value; }
        }

        //Una lista privada no necesita GET y SET, solo get ya que para agregar un elemento con add es suficiente.
        public List<Persona> MiList
        {
            set { miList = value; }
            get { return miList; }

        }

        //Si o si tien que tener constructor por defecto si no no serializa.
        public Aula()
        { 
            
        }

        public Aula(int number,Persona teacher,string nombreaula)
        {
            miList = new List<Persona>();
            numero = number;
            profesor = teacher;
            _nombreAula = nombreaula;

        }

    }
}
