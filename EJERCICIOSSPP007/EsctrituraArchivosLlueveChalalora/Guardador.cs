using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EsctrituraArchivosLlueveChalalora
{
    public static class Guardador
    {
        public static bool GuardarPersona(Persona p)
        {
            StreamWriter escritor = null;
            bool guardo = true;

            try
            {
                escritor = new StreamWriter("Persona.txt", true);
                escritor.WriteLine(p.ToString());
                guardo = true;

            }
            catch (Exception)
            {

                guardo = false;

            }
            finally
            {
                escritor.Close();
            }

            return guardo;
        }

        public static Persona LeerUnaPersona()
        {
            Persona p = null;
            StreamReader lector = null;
            string[] misDatos;

            try
            {               
                lector = new StreamReader("Persona.txt");
                string datos = lector.ReadLine();
                misDatos = datos.Split(','); //Indico el separador usado.
                p = new Persona(misDatos[0], misDatos[1]);
            }
            catch (Exception)
            {
                return p;
            }
            finally
            {
                lector.Close();
            }

            return p;
        }

        public static List<Persona> RetornarListado()
        {
            string[] misDatos;
            string renglon;
            Persona p;
            List<Persona> lista= null; 
            
            try
            {
                lista = new List<Persona>();
                
                using (StreamReader lector = new StreamReader("Persona.txt"))
                {
                    while ((renglon=lector.ReadLine())!=null)
                    {
                        misDatos = renglon.Split(',');
                        p = new Persona(misDatos[0], misDatos[1]);
                        lista.Add(p);
                    }
                }
            }
            catch (Exception)
            {
                               
            }

            return lista;
        }
    }
}
