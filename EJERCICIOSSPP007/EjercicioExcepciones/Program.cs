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
            Robertino robert = new Robertino(10);
            
            try
            {
                robert.robertico()//PT.2
                juan.EsJuan();//PT.1
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }

            Console.ReadKey();
        }
    }
}
