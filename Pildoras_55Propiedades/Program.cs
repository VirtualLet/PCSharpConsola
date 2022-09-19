using System;

namespace Pildoras_55Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando utilidad de usar propiedades!");
            CEmpleado empleado = new CEmpleado("Juancho");
            empleado.Salario = 500;
            empleado.MuestraSalario();
            empleado.Salario += 300;

            empleado.MuestraSalario();
            empleado.Salario -= 1000;
            empleado.MuestraSalario();
            Console.ReadLine();
        }
    }
}
