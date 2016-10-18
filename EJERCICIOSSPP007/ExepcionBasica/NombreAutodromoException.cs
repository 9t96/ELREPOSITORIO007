using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionBasica
{
    public class NombreAutodromoException:miExcepcion
    {


        public NombreAutodromoException(string mssg, DateTime time, Exception anterior)
            : base(mssg, time, anterior)
        { 
            
        }

        public NombreAutodromoException(string mssg, DateTime time) : base(mssg, time) 
        { }
    }
}
