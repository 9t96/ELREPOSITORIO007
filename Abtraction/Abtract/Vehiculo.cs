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
        public string patente;

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

        public abstract float CalcularCosto();

    }

}
