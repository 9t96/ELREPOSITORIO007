using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EcrituraArchivosMIO
{
    public class Persona:IArchivo
    {
        string nombre;
        int dni;
        
        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine("Nombre: " + this.nombre);
            str.AppendLine("DNI: " + this.dni);

            return str.ToString();
        }

        public bool Guardar(string archivo, Persona datos)
        {
            StreamWriter escribir;
            bool escribio = false;

            if (!File.Exists(archivo))
            {
                escribir = File.CreateText(archivo);
                escribir.WriteLine(((Persona)datos).ToString());
                escribir.Close();
                escribio = true;
            }
            else if (File.Exists(archivo))
            {
                escribir = File.Open(archivo,
                escribir.WriteLine(((Persona)datos).ToString());
                escribir.Close();
                escribio = true;
            }
            else
                escribio = false;
                throw new Exception("El archivo ya existe.");

            return escribio;


        }

        public bool Leer(string archivo, Persona datos)
        {
            StreamReader leer;
            string dato;
            
            if (File.Exists(archivo))
            {
                leer = File.OpenText(archivo);
                dato = leer.ReadToEnd();
                Console.WriteLine("MIS DATOS");
                Console.WriteLine(dato);
                leer.Close();
                return true;
            }
            else
            {
                throw new FileNotFoundException("No se encontro el archivo del cual desea leer.");
            }
            
            
        }
    }
}
