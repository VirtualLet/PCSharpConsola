using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_24ConversionImplicita
{
    internal class CReal
    {
        private double real;
        private double Real
        {
            get => real;
            set => real = value;
        }
        public CReal() { }
        public CReal(double pReal)
        {
            real = pReal;
        }
        public override string ToString()
        {
            return String.Format("real={0}", real);
        }

        //Se crea una conversion implicita de reales a imaginarios
        public static implicit operator CComplejo(CReal pCReal)
        {
            CComplejo complejo = new CComplejo((int)pCReal.Real,0);
            return complejo;
        }
    }
}
