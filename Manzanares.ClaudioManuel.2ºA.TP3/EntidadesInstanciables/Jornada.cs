using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;


namespace EntidadesInstanciables
{

    public class Jornada
    {
        private List<Alumno> _alumno;
        private Gimnasio.EClases _clase;
        private Instructor _instructor;

        #region Contructores
        private Jornada()
        {
                     
        }

        public Jornada(Gimnasio.EClases clase,Instructor instructor)
        {
            this._alumno = new List<Alumno>();
            this._clase = clase;
            this._instructor = instructor;
        }
        #endregion
        
        #region Propiedades
        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this._alumno.Count)
                    return this[i];
                else
                    return null;
            }
        }
        #endregion

        #region Sobrecargas

        public static bool operator !=(Jornada j,Alumno a)
        {
            return !(j==a);
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            return !(a != j._clase);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            bool repetido = false;

            foreach (Alumno item in j._alumno)
            {
                if (item == a)
                {
                    repetido = true;
                    throw new AlumnoRepetidoException();
                }
            }

            if (!repetido)
                j._alumno.Add(a);
          
            return j;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("JORNADA:");
            str.AppendLine("CLASE DE " + this._clase + " POR ");
            str.Append(this._instructor.ToString());
            foreach (Alumno item in this._alumno)
            {
                str.AppendLine(item.ToString());
            }

            return str.ToString();            
        }

        #endregion

        #region Metodos
        public static bool guardar(string archivo, Jornada datos)
        {
            bool succed = false;

            return succed;
        }

        public bool leer(string archivo, out Jornada datos)
        {
            bool succed = false;

            succed = true;

            return succed;
        }
        #endregion

    }
}
