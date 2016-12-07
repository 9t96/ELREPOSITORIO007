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
            
            
    public static class MétodosExtensión
    {
        // PUNTO 1
        public static bool EsPar(this Int32 obj)
        {
            if ((obj % 2) == 0)
                return true;
            return false;
        }

        public static bool EsImpar(this Int32 obj)
        {
            return !(obj.EsPar());
        }
    }

    
    
    
    public class ProdExport : Producto
    {
        public int Cantidad;

        public ProdExport()
            : base()
        {

        }
    }
    
    
    public class ProdImpuesto : Producto
    {
        public int Cantidad;

        public ProdImpuesto()
            : base()
        {

        }
        
        
    public class ProdVendido : Producto
    {
        public int Cantidad;

        public ProdVendido()
            : base()
        {

        }
    }
   
    
    
    
    
    
        [Serializable]
    [XmlInclude(typeof(ProdVendido)), XmlInclude(typeof(ProdImpuesto)), XmlInclude(typeof(ProdExport)), XmlInclude(typeof(Deposito)), XmlInclude(typeof(Galpon<Deposito>))]
    public class Producto
    {
        public string Nombre;
        public int Stock;

        public Producto(string nombre, int stock)
        {
            this.Nombre = nombre;
            this.Stock = stock;
        }

        public Producto()
        {
            // para serializar.
        }

        public static bool operator ==(Producto uno, Producto dos)
        {
            if (uno.Nombre == dos.Nombre)
                return true;
            return false;
        }

        public static bool operator !=(Producto uno, Producto dos)
        {
            return !(uno == dos);
        }
    }
}
