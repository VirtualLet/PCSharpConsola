using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_60GenericosH
{
    class CEmpleado
    {
        double salario;
        public CEmpleado(double pSalario)
        {
            salario = pSalario;
        }

        public double Salario
        {
            get => salario;
        }
    }
}
