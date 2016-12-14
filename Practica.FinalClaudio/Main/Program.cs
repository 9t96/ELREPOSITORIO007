using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno_MetodosExtension;
using Burbujeo;
using PuntoTres_Deposito;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////PUNTO UNO
            Console.WriteLine("*****PUERBA PUNTO UNO*****");
            Console.WriteLine("Le paso 100 al metodo par y 3 al metodo impar");
            Console.WriteLine(MetodosExtension.EsImpar(3).ToString());
            Console.WriteLine(MetodosExtension.EsPar(100).ToString());
            ////
            ////
            ////
            /////////////PUNTO DOS    
            Stack<Double> miPila = new Stack<double>();
            Stack<Double> auxiliarPila = new Stack<double>();

            miPila.Push(1);
            miPila.Push(2);
            miPila.Push(3);

            ///MUESTRO LA PILA SIN ORDENAR
            Console.WriteLine("SECUENCIA SIN ORDENAR");
            foreach (var item in miPila)
            {
                Console.WriteLine(item.ToString());
            }
            ///ORDENO INVERSAMENTE
            while (miPila.Count>=1)
            {
                auxiliarPila.Push(miPila.Pop());
            }
            ////IMPRIMO ORDENADO
            Console.WriteLine("SECUENCIA ORDENADA");
            foreach (var item in auxiliarPila)
            {
                Console.WriteLine(item.ToString());
            }
            
            ////
            ////
            ////
            ////////BURBUJEO

            Burbuja miBurbuja = new Burbuja();

            try
            {
                Burbuja.Estatico(miBurbuja);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            //////////////           
            //////////////

            ///////DEPOSITO SUMA DE LISTAS
            Deposito dep1 = new Deposito(10);
            Deposito dep2 = new Deposito(50);
            List<Producto> auxiliar = null;


            dep1.miLista.Add(new Producto(5, "Papas"));
            dep1.miLista.Add(new Producto(3, "guiso"));
            dep1.miLista.Add(new Producto(11, "pipas"));
            dep1.miLista.Add(new Producto(8, "mango"));
            dep1.miLista.Add(new Producto(26, "naranja"));

            dep2.miLista.Add(new Producto(5, "Papas"));
            dep2.miLista.Add(new Producto(3, "guiso"));
            dep2.miLista.Add(new Producto(22, "Arcos"));
            dep2.miLista.Add(new Producto(8, "Coca"));
            dep2.miLista.Add(new Producto(26, "naranja"));

            auxiliar = dep1 + dep2;

            foreach (var item in auxiliar)
            {
                Console.WriteLine(item.ToString());
            }
         
            Console.ReadKey();
        }
    }
}
