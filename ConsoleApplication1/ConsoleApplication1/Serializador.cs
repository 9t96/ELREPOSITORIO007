using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    public static class Serializador
    {
        public static void SerializarPersona(Persona p)
        { 
            //XmlTextWriter->Hereda de textewriter.
            //XmlSerializer hola = new XmlSerializer();
            XmlSerializer serial = null;
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Persona.xml", Encoding.UTF8))
                {
                    serial = new XmlSerializer(typeof(Persona));

                    serial.Serialize(escritor, p);
                }

            }
            catch (Exception)
            {

            }
        
        }

        public static void SerializarListado(List<Persona> listaASerial)
        {
            XmlSerializer serial = null;

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("ListadoPersonas.xml", Encoding.UTF8))
                {
                    serial = new XmlSerializer(typeof(List<Persona>));

                    serial.Serialize(escritor, listaASerial);
                }

            }
            catch (Exception)
            {

            }
        }

        public static void SerializarAula(Aula miAula)
        {
            XmlSerializer serial = null;

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("aula.xml", Encoding.UTF8))
                {
                    serial = new XmlSerializer(typeof(Aula));

                    serial.Serialize(escritor, miAula);
                }

            }
            catch (Exception)
            {


            }
        }
    }
}
