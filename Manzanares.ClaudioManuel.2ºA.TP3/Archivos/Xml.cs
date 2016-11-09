using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Serializa los datos pasados por parametro con el nombre de ruta especificado.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>TRUE si serializo correctamente, FALSE  si no lo hizo.</returns>
        public bool guardar(string archivo, T datos)
        {
            bool succed = false;

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    serializador.Serialize(escritor, datos);
                    succed = true;
                }
            }
            catch (Exception e)
            {
                succed = false;
                throw new ArchivosException(e);
            }

            return succed;
        }
        /// <summary>
        /// Lee un archivo Xml en la ruta especificada.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>TRUE si la lectura fue correcta, FALSE si no lo fue.</returns>
        public bool leer(string archivo, out T datos)
        {
            bool succed = false;

            try
            {
                using (XmlTextReader lector = new XmlTextReader(archivo))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    datos = (T)serializador.Deserialize(lector);
                    succed = true;
                }
            }
            catch (Exception e)
            {
                succed = false;
                throw new ArchivosException(e);
            }

            return succed;
        }
    }
}
