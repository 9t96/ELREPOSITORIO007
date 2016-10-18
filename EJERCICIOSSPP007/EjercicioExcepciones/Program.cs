using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            1-Contructor-instancia-prog
            2-static-intancia-prog
            3-instancia-static-contructor-program
            4-3metodos-static-prog
            5-3instancia-static-contructor-prog
            */
            
            Juancito juan = new Juancito(20, "pepe");

            try
            {
                juan.EsJuan();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }

            Console.ReadKey();
        }
    }
}
