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

        public void Despegar()
        {
            Console.WriteLine("Se prepara para despegar");
        }

        public void Aterrizar()
        {
            Console.WriteLine("Se pretende aterrizar");
        }
    }
}
