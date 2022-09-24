using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_08InterfazCallbackII
{
    class CRefriSink:IEventoRefri
    {
        private bool parar = false;
        public bool Parar { get => parar; }
        //Aqui colocamos los handlers de los eventos definidos en la interfaz
        public void EventReservasBajas(int pKilos)
        {
            //para ejecutar cuando se efectue el evento
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--->Reservas bajas de alimentos");
            Console.WriteLine("--->Quedan {0} kilos", pKilos);
        }
        public void EventDescongelado(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--->El refrigerador se esta descongelando");
            if (pGrados > 0)
            {
                parar = true;
            }
        }
    }
}
