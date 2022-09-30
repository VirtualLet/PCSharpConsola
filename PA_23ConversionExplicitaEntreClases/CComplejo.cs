using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_23ConversionExplicitaEntreClases
{
    internal class CComplejo
    {
        private int real;
        private int imaginario;
        public int Real
        {
            get => real;
            set => real = value;
        }
        public int Imaginario
        {
            get => imaginario;
            set => imaginario = value;
        }

        public CComplejo() { }
       
        public CComplejo(int pReal, int pImaginario)
        {
            real = pReal;
            imaginario = pImaginario;
        }

        public override string ToString()
        {
            return String.Format("{0}+{1}i", real, imaginario);
        }

        //Creamos una conversion explicita a cReal
        //CReal=A donde va a quedar la informacion,
        //CComplejo=De donde sale la información
        public static explicit operator CReal(CComplejo pComplejo)
        {
            CReal cReal = new CReal(pComplejo.real);
           // cReal.real= pComplejo.real;
            return cReal;
        }
    }
}
