using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaIndexador
{
    public class PC
    {
        public string marca;
        public string so;
        public static int contadorPc;
        public int numero;
        
        #region contruct    
        /*public PC(string marca, string sistemaOpertaivo)
        {
            this.marca = marca;
            this.so = sistemaOpertaivo;
        }*/

        static PC()
        {
            contadorPc = 1;
        }

        private PC(string marca)
        {
            this.marca = marca;
            this.numero = contadorPc;
            contadorPc++;
        }  
        #endregion
        
        public static implicit operator PC (string marca)
        {
            return new PC(marca);
        }
     

    }
}
