using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoTres_Deposito
{
    public class Producto
    {

        private string nombre;
        private int stock;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public Producto()
        {

        }

        public Producto(int stock, string nombre)
        {
            this.Nombre = nombre;
            this.Stock = stock;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.Nombre == p2.Nombre);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("Nombre: " + this.nombre);
            str.AppendLine("Stock" + this.Stock);

            return str.ToString();
        }
    }
}
