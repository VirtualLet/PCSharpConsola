using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_53ClaseAbstracta
{
    abstract class CAnimales
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        //Cuando un método es abstracto se vuelve obligatorio para aquellos que hereden de la clase abstract Animales
        public abstract void GetNombre();
    }
}
