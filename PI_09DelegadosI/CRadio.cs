using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_09DelegadosI
{
    class CRadio
    {
        public static void MuestraRadio(string pMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la clase radio");
            Console.WriteLine("Mostrando mensaje {0}",pMensaje);
        }
    }
}
