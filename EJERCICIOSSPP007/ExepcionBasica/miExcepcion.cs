using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionBasica
{
    public class miExcepcion:Exception
    {
        public DateTime timeException;
        public string textoHora;
        private string mssg;
        private DateTime time;

        public miExcepcion(string mssg, DateTime time,Exception anterior)
            :base(mssg,anterior)
        {
            this.timeException = time;
            this.textoHora = time.ToString();
        }

        public miExcepcion(string mssg, DateTime time):base(mssg)
        {
            this.timeException = time;
            this.textoHora = time.ToString();
        }

    }
}
