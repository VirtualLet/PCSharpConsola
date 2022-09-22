using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_67DelegadosPredicadoLambdasI
{
    class CMensajeDespedida
    {
        public static void SaludoDespedida()
        {
            Console.WriteLine("Adiosss");
        }

        public static void SaludoDespedidaPersonalizado(string pMensaje)
        {
            Console.WriteLine("Mensaje Despedida:{0}",pMensaje);
        }
    }
}
