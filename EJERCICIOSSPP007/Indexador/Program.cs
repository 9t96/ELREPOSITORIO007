using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaIndexador;

namespace Indexador
{
    class Program
    {
        static void Main(string[] args)
        {
            PC pc1 = "Macintosh";
            PC pc2 = "EXO";
            PC pc3 = "NIKE";

            Laboratorio miLab = new Laboratorio("HOLA");

            //miLab[0] = "exo";
            miLab[1] = "lg";
            //miLab[3] = pc3;
            //miLab[2] = pc3;

            for (int i = 0; i < miLab._listPc.Count; i++)
            {
                Console.WriteLine(miLab[i].marca + miLab[i].so);
            }

            Console.ReadLine();
            
        }
    }
}
