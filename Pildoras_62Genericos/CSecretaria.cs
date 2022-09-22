using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_62Genericos
{
    class CSecretaria:IParaEmpleados
    {
        double salario;
        public CSecretaria(double pSalario)
        {
            salario = pSalario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }
}
