using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_13Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona persona = new CPersona();
            persona.Nombre = "Let";
            persona.Edad = 13;
            persona.Muestra();
            Console.WriteLine("---");

            CEmpleado empleado = new CEmpleado();
            empleado.Nombre = "Raul";
            empleado.Edad = 27;
            empleado.Puesto = "Program";
            empleado.Salario = 10;
            empleado.EmpleadoMuestra();
            empleado.Muestra();
            Console.WriteLine("------------");
            CEmpleado empleado1 = new CEmpleado();
            empleado1.PonerDatos("ate", 23, "alfarero", 123333);
            empleado1.EmpleadoMuestra();

            Console.ReadLine();
        }
    }
}
