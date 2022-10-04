using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_25MetodosDeExtension
{
    class CIngreso:IBienvenida
    {
        private int valor;
        public CIngreso(int pValor)
        {
            valor = pValor;
        }
        public override string ToString()
        {
            return string.Format("Tus ingresos al 0.5 en un año será de:{0}", valor * 0.5 * 365);
        }
        public void Saludar()
        {
            Console.WriteLine("Bienvenido es tiempo de mostrar sus ingresos");
        }

    }
}
