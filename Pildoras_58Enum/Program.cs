using System;

namespace Pildoras_58Enum
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum: Conjunto de constantes con nombre!");
            ESTACIONES Calidas = ESTACIONES.primavera;
            Console.WriteLine(Calidas.ToString());
            

            double bonusPersona = (double)BONUS.Normal;
            Console.WriteLine(bonusPersona);

            double salarioPersona = 1500 + bonusPersona;
            Console.WriteLine("Su salario mas bonus es {0}",salarioPersona);
            Console.WriteLine("------------");

            CEmpleado empleado = new CEmpleado("Edith", BONUS.Extra, 5000);
            Console.WriteLine(empleado);

            Console.ReadLine();
        }
    }
}
