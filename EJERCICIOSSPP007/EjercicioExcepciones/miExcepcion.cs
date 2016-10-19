using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class miExcepcion:Exception
    {
        public miExcepcion(string mssg, Exception ex)
            :base(mssg,ex)
        { 
            
        }
    }
}
