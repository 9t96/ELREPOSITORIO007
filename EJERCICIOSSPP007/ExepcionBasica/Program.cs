using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionBasica
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                LanzarError();
                Operar();
            }
            catch (FormatException fe)//Format exception y divdeException estan al mismo nivel de jeraquia.
            {
                Console.WriteLine("Error de formato");
                Console.WriteLine(fe.Message);
            }
            catch (DivideByZeroException dvz)
            {
                Console.WriteLine("Error division por cero.");
                Console.WriteLine(dvz.Message);
            }
            catch (Exception ex)//Superiorridad en jerearquia. Si este se pusiese primero no ingresaria a las demas excepciones.
            {

                Console.WriteLine(ex.Message);
                //throw;
            }


            Console.ReadKey();
        }


        public static void Operar()
        {

            try
            {
                 int numero;
                 string dato;
    
                 dato = Console.ReadLine();
                 numero = int.Parse(dato);
                 numero = numero / numero;
            }
            catch (Exception ex)
            {//Operacion para guardar informacion de la excepcion.


                throw new Exception("Se quedo sin internet.");
                                
            }
        }

        public static void LanzarError()
        {
            throw new Exception("Se quedo sin memoria RAM");           
        }
    }
}
