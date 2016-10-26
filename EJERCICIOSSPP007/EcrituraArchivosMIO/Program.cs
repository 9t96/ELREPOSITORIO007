using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcrituraArchivosMIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona juan = new Persona(1010, "Juan");

            try
            {
                //Creo un archivo nuevo y lo leo.
                juan.Guardar("Nuevo", juan);
                //Leo el archivo que escribi.
                juan.Leer("Nuevo", juan);
                //Trato de leer un archivo que no existe.
                juan.Leer("viejo", juan);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
