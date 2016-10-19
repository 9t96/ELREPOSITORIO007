using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosdeTextoDiaLLuvioso
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito<Mascota> misMascotas = new Deposito<Mascota>(3);
            Deposito<Vehiculo> misVehiculos = new Deposito<Vehiculo>(3);
            Deposito<Persona> misPersonas = new Deposito<Persona>(3);
            Deposito<Producto> misProductos = new Deposito<Producto>(3);

            Mascota m1 = new Mascota("kike", "Malo");
            Mascota m2 = new Mascota("chiqui", "Bueno");
            Mascota m3 = new Mascota("lulu", "lindo");

            Persona p1 = new Persona("Juani", 11111);
            Persona p2 = new Persona("Marcelo", 2222);
            Persona p3 = new Persona("Elias", 3333);

            Vehiculo v1 = new Vehiculo("Renault", "Verde", "aaa111");
            Vehiculo v2 = new Vehiculo("Chevrolet", "Gris", "bbb222");
            Vehiculo v3 = new Vehiculo("Fiat", "Blanco", "ccc333");

            Producto prod1 = new Producto("Feo", 111, 11);
            Producto prod2 = new Producto("Feo", 222, 22);
            Producto prod3 = new Producto("Amargo", 333, 33);

            misMascotas.Agregar(m1);
            misMascotas.Agregar(m2);
            misMascotas.Agregar(m3);

        }
    }
}
