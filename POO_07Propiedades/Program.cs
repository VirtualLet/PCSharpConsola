using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_07Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado();
            empleado.Sueldo = 50000;
            empleado.CalcularImpuesto();
            Console.WriteLine(empleado.Mostrar());
            Console.ReadLine();
        }
    }
}
