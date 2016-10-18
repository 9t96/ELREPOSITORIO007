using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionBasica
{
    public class Rueda
    {
        public string marca;
        static Random rnd;

        static Rueda()
        {
            rnd = new Random();
        }

        public Rueda(string marca)
        {
            this.marca = marca;
        }

        public void Pinchar()
        {
            throw new PinchaduraException("PinchaduraDura",DateTime.Now,this.marca);
        }

        public void Rodar()
        {          
            int ransom;
            ransom=rnd.Next(1, 10);
            
            if (ransom == 5)
                this.Pinchar();
            else
                Console.WriteLine("Numero" + ransom);
        }

    }
}
