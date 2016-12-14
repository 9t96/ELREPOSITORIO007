using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno_MetodosExtension;
using System.Xml;
using System.Xml.Serialization;
using PuntoTres_Deposito;


namespace PuntoCuatro_Galpon
{
    [Serializable]
    [XmlInclude(typeof(ProdImportado))]
    [XmlInclude(typeof(ProdImpuesto))]
    [XmlInclude(typeof(ProdVendido))]
    [XmlInclude(typeof(Producto))]
    public class Galpon<T>:IGuardarXML
    {
        public List<T> miLista;
        private int canitdad;

        public delegate void MiDelegado(object obj,EventArgs evento);

        public event MiDelegado myevent;

        public Galpon()
        {

        }

        public Galpon(int cantidad)
        {
            this.Canitdad = cantidad;
        }

        public int Canitdad
        {
            set
            {
                if (value == 0)
                    throw new ArgumentException("El valor que se intenta asignar es 0");
                else if (value.EsImpar())
                    this.myevent(value, new EventArgs());

                canitdad = value;                
            }
        }

        public bool SerializarXML()
        {
            bool succed = false;

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("archivo.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<T>));

                    serializador.Serialize(escritor, this);

                    succed = true;
                }
            }
            catch (Exception e)
            {
                succed = false;
                throw e;
            }

            return succed;
        }
    }
}
