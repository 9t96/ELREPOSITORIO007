using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace EjercicioExcepciones
{
    public class Robertino
    {
        public int edad;

        public Robertino(int edad)
        {
            this.edad = edad;
        }

        

        public void robertico()
        {
            StreamReader leer;

            try
            {
                Juancito.Cortar();//Viene de juancito.cortar() metodo de clase.

            }
            catch (Exception ex)
            {
                

                throw new miExcepcion(ex.Message+"Robertico lo agarro y lo ayuda.", ex)//Robertico agarro la excepcion y lo ayuda.
            }
        }


    }
}
