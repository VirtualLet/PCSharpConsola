using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_62Genericos
{
    class CDirector:IParaEmpleados
    {
        double salario;
        public CDirector(double pSalario)
        {
            salario = pSalario;
        }
        public double GetSalario()
        {
            return salario;
        }
    }
}
