using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_62Genericos
{
    class CProfesor:IParaEmpleados
    {
        double salario;
        public CProfesor(double pSalario)
        {
            salario = pSalario;
        }
        public double GetSalario()
        {
            return salario;
        }
    }
}
