using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionBasica
{
    class AutoException:miExcepcion
    {
        public Auto miAuto;

        public AutoException(string mssg,DateTime time, Auto car,Exception anterior)
            :base(mssg,time,anterior)
        {
            this.miAuto = car;
        }

        public AutoException(string mssg, DateTime time, Auto car)
            : base(mssg,time)
        {
            this.miAuto = car;
        }
    }
}
