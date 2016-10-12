using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO47
{
    public abstract class Animal
    {

        protected int _patas;

        public Animal(int patas)
        {
            this._patas = patas;
        }

        /// <summary>
        /// El animal camina sobre X cantidad de patas.
        /// </summary>
        /// <returns></returns>
        public virtual string Caminar()
        {
            return "Este animal camina sobre ";
        }

        /// <summary>
        /// Que come el animal.
        /// </summary>
        public abstract void Comer();




           
    }
}
