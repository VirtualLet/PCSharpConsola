using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_14HerenciaConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado("Laura", 32, "Mesera", 5000);
            empleado.MostrarEmpleado();
            Console.ReadLine();
        }
    }
}
