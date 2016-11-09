using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;
using Archivos;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{

    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Instructor))]
    [XmlInclude(typeof(Jornada))]

    public class Gimnasio
    {
        public enum EClases { CrossFit, Natacion, Pilates, Yoga }

        private List<Alumno> _alumnos;
        private List<Instructor> _instructores;
        private List<Jornada> _jornada;

        #region Constructores

        public Gimnasio()
        {
            this._alumnos = new List<Alumno>();
            this._instructores = new List<Instructor>();
            this._jornada = new List<Jornada>();
        }
        #endregion

        #region Propiedades
        public Jornada this[int index]
        {
            get
            {
                if (index >= 1 && index < Jornada.Count)
                    return this.Jornada[index];

                return null;
            }
        }

        internal List<Alumno> alumnos
        {
            get
            {
                return this._alumnos;
            }

        }

        public List<Instructor> Instructores
        {
            get
            {
                return this._instructores;
            }

        }

        public List<Jornada> Jornada
        {
            get
            {
                return this._jornada;
            }
        }
        #endregion

        #region Sobrecargas.


        public static bool operator !=(Gimnasio g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Gimnasio g, Alumno a)
        {
            bool inscripto = false;

            foreach (Alumno item in g._alumnos)
            {
                if (item == a)
                    inscripto = true;
            }

            return inscripto;
        }

        public static Instructor operator !=(Gimnasio g, EClases e)
        {
            Instructor noDaEsaClse = null;

            foreach (Instructor item in g.Instructores)
            {
                if (item != e)
                     noDaEsaClse = item;
            }

            return noDaEsaClse;
        }

        public static Instructor operator ==(Gimnasio g, EClases e)
        {
            foreach (Instructor item in g.Instructores)
            {
                if (item == e)
                    return item;
            }

            throw new SinInstructorException();
        }

        public static bool operator !=(Gimnasio g, Instructor i)
        {
            return !(g == i);
        }

        public static bool operator ==(Gimnasio g, Instructor i)
        {
            bool daClase = false;

            foreach (Instructor item in g.Instructores)
            {              
                if (item == i)
                    daClase = true;
            }

            if (!daClase)
                throw new SinInstructorException();

            return daClase;
        }


        public static  Gimnasio operator +(Gimnasio g, Alumno a)
        {
            bool yaExiste = false;

            foreach (Alumno item in g._alumnos)
            {
                if (item == a)
                    yaExiste = true;
            }

            if (!yaExiste)
                g._alumnos.Add(a);

            return g;
        }

        public static  Gimnasio operator +(Gimnasio g, EClases e)
        {
            int index = 0;

            foreach (Instructor item in g.Instructores)
            {
                if (item == e)
                    index = g.Instructores.IndexOf(item);
            }

            Jornada j = new Jornada(e, g.Instructores[index]);


            foreach (Alumno item in g._alumnos)
            {
                if (item == e)
                    j += item;                                     
            }

            g.Jornada.Add(j);

            return g;
        }

        public static  Gimnasio operator +(Gimnasio g, Instructor i)
        {
            bool yaExiste = false;

            foreach(Instructor item in g.Instructores)
            {
                if (item == i)
                    yaExiste = true;
            }

            if (!yaExiste)
                g.Instructores.Add(i);

            return g;
        }

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        #endregion

        #region Metodos
        private string MostrarDatos(Gimnasio gim)
        {
            StringBuilder str = new StringBuilder();

            foreach (Jornada item in gim.Jornada)
            {
                str.Append(item.ToString());
            }

            return str.ToString(); 
        }

        public static void Guardar(Gimnasio gim)
        { }

        public static void Leer(Gimnasio gim)
        {

        }
        #endregion

    }
}
