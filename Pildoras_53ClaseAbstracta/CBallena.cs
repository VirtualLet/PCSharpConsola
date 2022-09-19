using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_53ClaseAbstracta
{
    class CBallena:CMamifero
    {
        public CBallena(string pNombre):base(pNombre) { }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}
