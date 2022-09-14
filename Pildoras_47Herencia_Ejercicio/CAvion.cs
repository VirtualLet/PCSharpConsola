using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_47Herencia_Ejercicio
{
    class CAvion:CVehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Se inicia la conducción para el despegue del avión");
        }
    }
}
