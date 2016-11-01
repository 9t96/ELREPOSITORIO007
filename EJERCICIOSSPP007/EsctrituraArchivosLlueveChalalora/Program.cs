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
            
            Guardador.GuardarPersona(p1);
            p1 = Guardador.LeerUnaPersona();

            Console.WriteLine(p1.ToString());
            
            Console.ReadKey();
        }
    }
}
