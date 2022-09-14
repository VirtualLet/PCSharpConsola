using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_47Herencia_Ejercicio
{
    class CCoche:CVehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Se inicia conducción del coche");
        }
    }
}
