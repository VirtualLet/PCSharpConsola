using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_44Herencia_PrincipioSustitucion
{
    class CGorila:CMamifero
    {
        public CGorila(string pNombre) : base(pNombre)
        {
        }

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
}
