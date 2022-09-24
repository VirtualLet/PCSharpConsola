using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_08InterfazCallbackII
{
    interface IEventoRefri
    {
        //Aqui definimos los eventos que tendra el refri
        void EventReservasBajas(int pKilos);
        void EventDescongelado(int pGrados);
    }
}
