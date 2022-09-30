using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_20MetodosAnonimos
{
    delegate void delegMensaje();
   
    class CPunto
    {
       public delegate void delegPrueba(string pValor);
        public delegPrueba delPrueba;

        public delegMensaje delMensaje;
        private int x;
        private int y;
       
        public CPunto(int pX, int pY)
        {
            x = pX;
            y = pY;
        }

        public override string ToString()
        {
            return string.Format("X={0} Y={1}", x, y);
        }
    }
}
