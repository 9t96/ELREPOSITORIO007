using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class Juancito
    {
        public string nombre;
        public int edad;

        public Juancito(int edad, string nombre)
        {
             this.edad = edad;
             this.nombre = nombre;

                if(nombre == "Ricardo")
                    throw new Exception("SE LLAMA RICARDO");
        }

        public void EsJuan()
        {        
            try
            {
                Juancito.Cortar();
                new Juancito(20, "Ricardo");
            }
            catch (Exception ex)
            {            
                throw ex;
            }
            
        }

        public void NoesJuan()
        {
            throw new Exception("No es juan..Por ahora.");
        }

        public static void  Cortar()
        {          
            throw new Exception("Juancito se corto.");       
        }


    }
}
