using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_43HerenciaIII_Constructores
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
