﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;

namespace EntidadesInstanciables
{
    public class Instructor:PersonaGimnasio
    {
        private Queue<Gimnasio.EClases> _clasesDelDia;
        private static Random _random;

        #region Constructores
        public Instructor()
        {

        }

        static Instructor()
        {
            Instructor._random = new Random();
        }

        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)           
        {
            _clasesDelDia = new Queue<Gimnasio.EClases>();
            this._randomClase();
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Un instructor sera distinto de una EClase si no da esa clase.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Instructor i, Gimnasio.EClases clase)
        {
            return !(i == clase);
        }
        /// <summary>
        /// Un instructor sera igual a una EClase si da esa clase.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        public static bool operator ==(Instructor i, Gimnasio.EClases clase)
        {
            bool daEsaClase = false;

            foreach (Gimnasio.EClases item in i._clasesDelDia.ToList())
            {
                if (item == clase)
                    daEsaClase = true;
            }

            if (!daEsaClase)
                throw new SinInstructorException();

            return daEsaClase;
        }

        #endregion

        #region Metodos
        protected override string ParticiparEnClase()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("CLASES DEL DIA ");
            foreach (Gimnasio.EClases item in _clasesDelDia)
            {
                str.AppendLine(item.ToString());
            }

            return str.ToString();
        }

        protected override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(base.MostrarDatos());
            str.AppendLine(this.ParticiparEnClase());

            return str.ToString();
        }

        private void _randomClase()
        {
            for (int i = 0 ; i < 2; i++)
            {
                _clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(0, 3));
            }
        }
       #endregion

    }
}
