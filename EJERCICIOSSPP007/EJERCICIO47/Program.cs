using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO47
{
    class Program
    {
        static void Main(string[] args)
        {
            Araña spider = new Araña(8);
            Pez fish = new Pez(0);
            Gato cat = new Gato(4);

            spider.Nombre = "HombreAraña";
            fish.Nombre = "Nemo";
            cat.Nombre = "Garfield";

            List<Animal> listAnimales = new List<Animal>();

            listAnimales.Add(spider);
            listAnimales.Add(cat);
            listAnimales.Add(fish);

            foreach (IMascota item in listAnimales)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(item.Nombre);
                item.Jugar();
                ((Animal)item).Comer();
                Console.WriteLine(((Animal)item).Caminar());
            }


            Console.ReadKey();

        }
    }
}
