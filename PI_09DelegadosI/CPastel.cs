using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_09DelegadosI
{
    class CPastel
    {
        public static void MuestraPastel(string pMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Estamos en clase Pastel\n" +
                "Muestra mensaje{0}",pMensaje);
        }
    }
}
