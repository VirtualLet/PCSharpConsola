using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_08InterfazCallbackII
{
    class CTiendaSink:IEventoRefri
    {
        public void EventReservasBajas(int pKilos)
        {
            //Colocamos el codigo para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--->Le enviaremos sus viveres");
            Console.WriteLine("--->Seran {0} kilos",pKilos);
        }
        public void  EventDescongelado(int pGrados)
        {
            //Handler vacio
        }
    }
}
