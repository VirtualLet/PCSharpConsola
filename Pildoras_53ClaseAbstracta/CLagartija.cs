using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_53ClaseAbstracta
{
    class CLagartija : CAnimales
    {
        private string nombre;
        public CLagartija(string pNombre)
        {
            nombre = pNombre;
        }
        public override void GetNombre()
        {
            Console.WriteLine("El nombre del reptil es {0}",nombre);
        }
    }
}
