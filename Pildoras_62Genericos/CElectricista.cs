using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_62Genericos
{
    class CElectricista:IParaEmpleados
    {
        double salario;
        public CElectricista(double pSalario)
        {
            salario = pSalario;
        }
        public double GetSalario()
        {
            return salario;
        }
    }
}
