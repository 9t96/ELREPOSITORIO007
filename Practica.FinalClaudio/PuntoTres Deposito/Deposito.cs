using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoTres_Deposito
{
    public class Deposito
    {
        public string nombre;
        public int stock;
        public List<Producto> miLista;

        public Deposito()
        {

        }

        public Deposito(int cantidad)
        {
            this.miLista = new List<Producto>(cantidad);
        }

        public List<Producto> Lista
        {
            get
            {
                return miLista;
            }
        }
        
        public static List<Producto> operator +(Deposito d1, Deposito d2)
        {
            List<Producto> auxiliar = null;


            for (int i = 0; i < d1.miLista.Count; i++)
            {
                for (int ji = 0; ji < d2.miLista.Count; ji++)
                {
                    if (d1.miLista[i] == d2.miLista[ji])
                    {
                        d1.miLista[i].Stock = d1.miLista[i].Stock + d2.miLista[ji].Stock;
                        d2.Lista.Remove(d2.miLista[ji]);
                    }
                }
            }

            /*foreach (var prod1 in d1.Lista)
            {
                foreach (var item in d2.Lista)
                {
                    if (prod1 == item)
                    { 
                        prod1.Stock=prod1.Stock + item.Stock;
                        d2.Lista.Remove(item);
                    }                   
                }
            }*/

            /* foreach (var item in d1.Lista)
             {
                 auxiliar.Add(item);
             }*/

            auxiliar = d1.miLista;
            
            foreach (var item in d2.Lista)
            {
                if (!d1.Lista.Contains(item))
                    auxiliar.Add(item);
            }

            return auxiliar;
        }

        
    }
}
