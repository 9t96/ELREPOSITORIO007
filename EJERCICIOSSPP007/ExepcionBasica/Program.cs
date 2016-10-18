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
            List<Rueda> listarueda = new List<Rueda>();

            Carrera carrera = new Carrera("argentino");
            
            Auto car1 = new Auto("Renault",30,listarueda);
            Auto car2 = new Auto("Fiat", 40, listarueda);
            Auto car3 = new Auto("Chevrolet", 50, listarueda);
            Auto car4 = new Auto("Mazda", 60, listarueda);

            carrera._miList.Add(car1);
            carrera._miList.Add(car2);
            carrera._miList.Add(car3);
            carrera._miList.Add(car4);

            car1._misRuedas.Add(new Rueda("Firestone"));
            car1._misRuedas.Add(new Rueda("Godyear"));
            car1._misRuedas.Add(new Rueda("Michelin"));
            car1._misRuedas.Add(new Rueda("samperio"));
            
            car2._misRuedas.Add(new Rueda("samperio"));
            car2._misRuedas.Add(new Rueda("Firestone"));
            car2._misRuedas.Add(new Rueda("Firestone"));
            car2._misRuedas.Add(new Rueda("samperio"));

            car3._misRuedas.Add(new Rueda("Michelin"));
            car3._misRuedas.Add(new Rueda("Michelin"));
            car3._misRuedas.Add(new Rueda("Firestone"));
            car3._misRuedas.Add(new Rueda("Firestone"));

            car4._misRuedas.Add(new Rueda("Preston"));
            car4._misRuedas.Add(new Rueda("Preston"));
            car4._misRuedas.Add(new Rueda("Preston"));
            car4._misRuedas.Add(new Rueda("Preston"));

            try
            {


                carrera.CorrerCarrera();
                /*();
                Operar()*/
            }
            catch (AutoException fe)//Format exception y divdeException estan al mismo nivel de jeraquia.
            {
                Console.WriteLine("EXCEPCION AUTO VA A EXPLOTAR");
                Console.WriteLine(fe.Message);
            }
            catch (PinchaduraException fe)//Format exception y divdeException estan al mismo nivel de jeraquia.
            {
                Console.WriteLine("EXCEPCION PINCHADURA CUIDADO AUTO SIN CONTROL");
                Console.WriteLine(fe.Message);
            }
            catch (miExcepcion dvz)
            {
                Console.WriteLine("EXCEPCION GENERAL CUIDADO PUBLICO.");
                Console.WriteLine(dvz.Message);
            }
            catch (Exception ex)//Superiorridad en jerearquia. Si este se pusiese primero no ingresaria a las demas excepciones.
            {

                Console.WriteLine(ex.Message);
                //throw;
            }


            Console.ReadKey();
        }

        /*
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
    */
    }
}
