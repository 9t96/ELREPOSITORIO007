using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract
{
    class Program
    {
        static void Main(string[] args)
        {
            Familiar familiar = new Familiar("ccc777");
            Deportivo deportivo = new Deportivo("aaa999");
            Avion avion = new Avion("888ccc");
            Carreta carreta= new Carreta("hhh888");
            Privada privada = new Privada("avion");

            List<Vehiculo> lista = new List<Vehiculo>();
            List<IAfip> listia = new List<IAfip>();
            
            lista.Add(familiar);
            lista.Add(deportivo);
            lista.Add(avion);
            lista.Add(carreta);

            listia.Add(avion);
            listia.Add(deportivo);
            listia.Add(privada);

            foreach (Vehiculo item in lista)
            {
                Console.WriteLine(item.CalcularCosto());
            }

            Console.WriteLine("---------IMPUESTOS--------");

            foreach (var item in listia)
            {
                Console.WriteLine(item.RetornarImpuesto());
            }


            Console.ReadKey();
        }
    }
}
