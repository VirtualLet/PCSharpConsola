using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_43Herencia
{
    class Coche:Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Se inicia conducción del coche");
        }
    }
}
