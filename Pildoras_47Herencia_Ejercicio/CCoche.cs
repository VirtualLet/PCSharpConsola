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

        public void Acelerar()
        {
            Console.WriteLine("Se acelera");
        }

        public void Frenar()
        {
            Console.WriteLine("Se frena");
        }
    }
}
