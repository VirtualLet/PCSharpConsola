using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_62Genericos
{
    class CEstudiante
    {
        private int edad;
        public CEstudiante(int pEdad)
        {
            edad = pEdad;
        }
        public double EDAD
        {
            get => edad;
        }
    }
}
