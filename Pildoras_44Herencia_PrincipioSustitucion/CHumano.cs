using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_44Herencia_PrincipioSustitucion
{
    class CHumano:CMamifero
    {
      public  CHumano(string pNombre) : base(pNombre)
        {

        }
        public void Pensar()
        {
            Console.WriteLine("Puedo pensar");
        }
    }
}
