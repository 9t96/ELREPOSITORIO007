using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionBasica
{
    public class Auto
    {
        public string marca;
        public int numero;
        public List<Rueda> _misRuedas;

        public Auto(string marca, int numero, List<Rueda> list)
        {
            this._misRuedas = list;
            this.numero = numero;
            this.marca = marca;
        }

        public void Andar()
        {
            if (this._misRuedas.Count < 4)
                throw new Exception();
            else
                try
                {
                    foreach (var item in this._misRuedas)
                    {
                        item.Rodar();
                    }
                }
                catch (PinchaduraException mipicnahdura)
                {
                    AutoException miexcepauto =  new AutoException("algo", mipicnahdura.timeException, this);
                  
                    throw miexcepauto;

                }
        }

    }
}
