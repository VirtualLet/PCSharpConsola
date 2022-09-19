using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_53ClaseAbstracta
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
