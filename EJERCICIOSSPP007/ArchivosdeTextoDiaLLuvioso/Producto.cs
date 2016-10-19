using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosdeTextoDiaLLuvioso
{
    public class Producto
    {
        public string descripcion;
        public int codigo;
        public float precioVenta;

        public Producto(string descripcion, int codigo, float precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precioVenta = precio;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            

            str.AppendLine("Codigo: " + this.codigo);
            str.AppendLine("Descripcion: "+this.descripcion);
            str.AppendLine("PrecioVenta: " + this.precioVenta);

            return str.ToString();
        }

       public static bool operator ==(Producto pUno,Producto pDos)
       {
            return pUno.codigo == pDos.codigo;
       }

       public static bool operator !=(Producto pUno, Producto pDos)
       {
           return !(pUno == pDos);
       }

       public override bool Equals(object obj)
       {
           if (obj is Producto)
           {
               return ((Producto)obj) == this;
           }

           return false;
       }
    }
}
