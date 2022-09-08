using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_43Herencia
{
    class Avion:Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Se inicia la conducción para el despegue del avión");
        }
    }
}
