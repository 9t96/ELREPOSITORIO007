using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EscrituraXMLInterface
{
    public static class Serializador
    {
        public static bool SerializarPersona(Persona p)
        { 
            //XmlTextWriter->Hereda de textewriter.
            //XmlSerializer hola = new XmlSerializer();
            bool succed = false;

            XmlSerializer serial = null;
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Persona.xml", Encoding.UTF8))
                {
                    serial = new XmlSerializer(typeof(Persona));
                    //LE PASO EL ESCRITOR XML Y LA PERSONA(1) PARA SERIALIZAR.
                    serial.Serialize(escritor, p);
                    succed = true;
                }

            }
            catch (Exception)
            {
                succed = false;
            }

            return succed;       
        }

        public static bool SerializarListado(List<Persona> listaASerial)
        {
            bool succed = false;

            XmlSerializer serial = null;

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("ListadoPersonas.xml", Encoding.UTF8))
                {
                    serial = new XmlSerializer(typeof(List<Persona>));
                    //LE PASO EL ESCRITOR XML Y LA LISTA PARA SERIALIZAR.
                    serial.Serialize(escritor, listaASerial);
                    succed = true;
                }

            }
            catch (Exception)
            {
                succed = false;
            }

            return succed;
        }

        public static bool SerializarAula(Aula miAula)
        {
            bool succed = false;
            XmlSerializer serial = null;

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("aula.xml", Encoding.UTF8))
                {
                    serial = new XmlSerializer(typeof(Aula));
                    //LE PASO EL ESCRITOR XML Y EL AULA PARA SERIALIZAR.
                    serial.Serialize(escritor, miAula);
                    succed = true;
                }

            }
            catch (Exception)
            {
                succed = false;
            }

            return succed;
        }

        public static bool SerializarGenerico(ISerialiable2016 serializable2016)
        {
            return serializable2016.Serializar();
        }

        public static Persona DesserializarPersona()
        {
            Persona p1 = null;

            try
            {
                using (XmlTextReader lector = new XmlTextReader("Persona.xml"))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));

                    p1 = (Persona)serializador.Deserialize(lector);
                }
            }
            catch (Exception)
            {
                p1 = null;           
            }

            return p1;
        }
    }
}
