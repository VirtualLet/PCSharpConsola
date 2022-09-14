using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_45Herencia_Polimorfismo
{
    class CCaballo:CMamifero
    {
        public CCaballo(string pNombre) : base(pNombre)
        {
        }

        public void Galopar()
        {
            Console.WriteLine("Puedo galopar");
        }
    }
}
