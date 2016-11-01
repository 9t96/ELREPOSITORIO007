using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsctrituraArchivosLlueveChalalora
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Juan", "333");
            List<Persona> lista = null;
            Guardador.GuardarPersona(p1);
            lista=Guardador.RetornarListado();

            foreach (Persona item in lista)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
