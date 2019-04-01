using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Calculadora
    {

        public int numero;
        internal bool bit;
        protected string letra;
        private long valor;

        public Calculadora()
        {
            
        }
                
        public void metodoPublico()
        {
            this.bit = true;
        }

        internal void metodoInterno()
        {
            this.bit = true;
        }

        protected void metodoProtegido()
        {
            this.bit = true;
        }

        private void metodoPrivado()
        {
            this.bit = true;
        }



    }
}
    