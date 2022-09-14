using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_45Herencia_Polimorfismo
{
    class CGorila:CMamifero
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
    }
}
