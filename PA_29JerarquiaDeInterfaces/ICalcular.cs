using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_29JerarquiaDeInterfaces
{
    /*Creamos la jerarquia de interfaces
     Ahora ICalcualr aparte del método Calcular tiene los métodos de IMostrar*/
    interface ICalcular:IMostrar
    {
        int Calcular(int pValorA, int pValorB);
    }
}
