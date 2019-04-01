using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    class HeredaNumero : CalculadoraAbstracta
    {
        public HeredaNumero()
        {
            this.bit = false;
        }

        public override void metodoAbstracto()
        {
            throw new NotImplementedException();
        }

        public override void metodoVirtual()
        {
            base.metodoVirtual();
        }

        

    }
}
