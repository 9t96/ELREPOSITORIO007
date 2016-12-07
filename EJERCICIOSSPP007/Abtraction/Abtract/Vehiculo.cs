using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1- Metodos abstractos Son obligatorios de implementar en su herencia.
2- Las clases abstractas no se pueden instanciar.
3- Metodos abstractos solo en clases abtrasctas.

 */
namespace Abtract
{
    public abstract class Vehiculo
    {
        
            public class Deposito
    {
        public List<Producto> Lista;

        public Deposito()
        {
            this.Lista = new List<Producto>();
        }

        public static List<Producto> operator +(Deposito uno, Deposito dos)
        {
            List<Producto> lista = new List<Producto>();
            bool estaEnLaLista = false;
            
            foreach (Producto itemUno in uno.Lista)
            {
                lista.Add(itemUno);
            }
            foreach (Producto itemDos in dos.Lista)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (itemDos == lista[i])
                    {
                        lista[i].Stock += itemDos.Stock;
                        estaEnLaLista = true;
                    }
                }
                if (!estaEnLaLista)
                {
                    lista.Add(itemDos);
                }
            }

            return lista;
        
        public string patente;
            
                public class Galpon<T> : IGuardarXML
    {
        public List<T> lista;
        private int _cantidad;

        public int Cantidad
        {
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("El valor a ingresar fue 0");
                }
                else if (value.EsImpar())
                {
                    this.EsImpar(value, new EventArgs());
                }
                this._cantidad = value;
            }
        }

        public event DelegadoCantidad EsImpar;

        public bool SerializarXML()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Galpon<Deposito>));


            return false;
        }

        public Vehiculo(string patente)
        {
            this.patente = patente;
        }

        public override string ToString()
        {
            return this.patente;
        }

        public virtual string MostrarDatos()
        {
            return this.patente;
        }

        //Se debe implementar en la herencia obligatoriamente.
        public abstract float CalcularCosto();

    }
    
     public class ClasePila
    {
        
        public static Stack<Double> OrdenInverso(Stack<Double> pilaOriginal)
        {
            Stack<Double> pilaNueva = new Stack<double>();          
            while(pilaOriginal.Count >= 1)
            {
                pilaNueva.Push(pilaOriginal.Pop());
            }
            return pilaNueva;
        }

}
