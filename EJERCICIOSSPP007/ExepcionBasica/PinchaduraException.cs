using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionBasica
{
    public class PinchaduraException:miExcepcion
    {
        public string marca;

        public PinchaduraException(string mssg,DateTime time, string marca,Exception anterior)
            :base(mssg,time,anterior)
        {
            this.marca = marca;
        }

        public PinchaduraException(string mssg, DateTime time, string marca)
            : base(mssg, time)
        {
            this.marca = marca;
        
        }
    }
}
