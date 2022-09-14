using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_43HerenciaIII_Constructores
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
