using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EscrituraXMLInterface
{
        [XmlInclude(typeof(Alumno))] //Hace falta para que reconozca la calse alumno para poder serializarla.
    public class Persona:ISerialiable2016
    {
        public string nombre;
        public List<Persona> laLista;

        public Persona()
        { 
            
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;           
        }


        public bool Serializar()
        {
            return Serializador.SerializarPersona(this);        
        }

/*
        public Persona Deserializar()
        {
            return Serializador.DesserializarPersona(this);
        }*/


        bool ISerialiable2016.Deserializar()
        {
            throw new NotImplementedException();
        }
    }
}
