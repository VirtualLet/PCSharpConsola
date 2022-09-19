using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_53ClaseAbstracta
{
    class CGorila:CMamifero,IMamiferosTerrestres
    {
        public CGorila(string pNombre):base(pNombre)
        {

        }
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo elevado");
        }

        public int IdentificadorTerrestre()
        {
            return 234;
        }
        public int NumeroPatas()
        {
            return 2;
        }
    }
}
