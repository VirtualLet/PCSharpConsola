using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_45Herencia_Polimorfismo
{
    class CHumano : CMamifero
    {
      public  CHumano(string pNombre):base(pNombre)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("Puedo pensar¿?");
        }
    }
}
