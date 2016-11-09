using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;


namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Extranjero, Argentino };

        private string _apellido;
        private int _dni;
        private ENacionalidad _nacionalidad;
        private string _nombre;

        //Falta incorporar Excepciones
        #region Constructores
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        {
            this.Nombre= nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            this._nombre = nombre;
            this.Apellido = apellido;
            this.StringToDNI = dni;
            this.Nacionalidad = nacionalidad;
        }

        #endregion
       
        //Falta implementar metodos validadores en las propiedades dni.

        #region Propiedades
        public string Apellido
        {
            get
            {
                return _apellido;
            }

            set
            {
                _apellido = this.VaildarNombre(value);
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = this.VaildarNombre(value);
            }
        }

        public int DNI
        {
            get
            {
                return _dni;
            }

            set
            {
                _dni = this.ValidarDni(this._nacionalidad, value);
            }
        }

        public string StringToDNI
        {
            set
            {
                _dni = this.ValidarDni(this.Nacionalidad, value);               
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return _nacionalidad;
            }

            set
            {
                _nacionalidad = value;
            }
        }

        #endregion
    
        #region Metodos
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("NOMBRE COMPLETO: "+this.Apellido+", "+this.Nombre);
            str.AppendLine("NACIONALIDAD: " + this.Nacionalidad);

            return str.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato > 0 && dato < 89999999)
                {
                    return dato;
                }
                else
                    throw new DniInvalidoException();
            }
            else
                return dato;
        }
        /// <summary>
        /// Verifica que la cadena contenga solo numero caso contrario la excepcion DniInvalidoException.
        /// Si contiene caracteres validos convierte la cadena en un entero y la valida nuevamente.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>El dni valido y parseado, '0' si no cotiene caracteres validos.</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int valido = 0;

            if (Regex.IsMatch(dato, @"^[0-9]+$"))
            {
                    if (int.TryParse(dato, out valido))
                        return this.ValidarDni(nacionalidad, dato);                       
            }
            else
                throw new DniInvalidoException();

            return valido;
        }
        /// <summary>
        /// Valida que la cadena tenga caracteres validos.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>Retorna la cadena si contiene caracteres validos, caso contrario una cadena vacia.</returns>
        private string VaildarNombre(string dato)
        {
            if (Regex.IsMatch(dato, @"^[a-zA-Z]+$"))
                return dato;
            else
                return "";
        }
        #endregion

    }
}
