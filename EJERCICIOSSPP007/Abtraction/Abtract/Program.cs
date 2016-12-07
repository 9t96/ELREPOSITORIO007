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
fffffffffffffffffffffffffffffffffffffffffffffffffffffffffff                return true;
            return false;
        }

        public static bool operator !=(Producto uno, Producto dos)
        {
            return !(uno == dos);
        }
        
        
        
        
                public static void Manejador(Object obj, EventArgs args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\log.txt";
            DateTime time = new DateTime();
            
            // No uso try-catch ya que lo estoy capturando el error en el main.
            StreamWriter sr = new StreamWriter(path, true);

            time = DateTime.Now;
            sr.WriteLine(time.ToLongTimeString() + "  " + ((int)obj).ToString());

            sr.Close();
        }
        
        
        
        
                   // PUNTO 2
            Stack<Double> pila = new Stack<double>();

            pila.Push(1);
            pila.Push(2);
            pila.Push(3);

            pila = ClasePila.OrdenInverso(pila);

            // PUNTO 3
            Deposito depo1 = new Deposito();
            Deposito depo2 = new Deposito();
            Producto prod1 = new Producto("Helado", 5);
            Producto prod2 = new Producto("Azucar", 5);
            Producto prod3 = new Producto("Carne", 5);
            Producto prod4 = new Producto("Helado", 5);

            depo1.Lista.Add(prod1);
            depo1.Lista.Add(prod2);
            depo2.Lista.Add(prod3);
            depo2.Lista.Add(prod4);

            List<Producto> lista = depo1 + depo2;

            // PUNTO 4

            Galpon<int> galpon = new Galpon<int>();

            galpon.EsImpar += new DelegadoCantidad(Program.Manejador);

            try
            {
                galpon.Cantidad = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR AL ESCRIBIR EN ARCHIVO: " + e.Message); 
            }
    }
}
