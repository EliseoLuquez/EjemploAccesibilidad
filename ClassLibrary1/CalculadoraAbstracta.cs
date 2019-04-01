using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public abstract class CalculadoraAbstracta
    {
        public int numero;
        internal bool bit;
        protected string letra;
        private long valor;

        public CalculadoraAbstracta()
        {

        }

        public abstract void metodoAbstracto();
        public virtual void metodoVirtual()
        {
            this.bit = true;
        }

        public void metodo()
        {
            this.bit = true;
        }

    }
}
