using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_58Enum
{
    enum ESTACIONES  {
        primavera, verano, otoño, invierno
    }

    enum BONUS { Bajo=500, Normal=1000, Extra=3000};
    class CEmpleado
    { 
        string nombre;
        double bonus;
        double salario;
        public CEmpleado(string pNombre, BONUS pBonusEmpleado, double pSalario)
        {
            nombre = pNombre;
            bonus = (double)pBonusEmpleado;
            salario = pSalario;
        }

        public double GetSalario()
        {
            return salario + bonus;
        }

        public override string ToString()
        {
            return string.Format("El empleado {0}, tiene un salario total de {1}",nombre,GetSalario());
        }

    }
}
