using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_11DelegadosIII
{
    class CTienda
    {
        public static void MandarViveres(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-->Vamos a mandar sus viveres, estoy en la tienda");
            Console.WriteLine("-->Seran {0} kilos",pKilos);
        }
    }
}
