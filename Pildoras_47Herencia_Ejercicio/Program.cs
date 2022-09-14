using System;

namespace Pildoras_47Herencia_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herencia en práctica!");
            int opcion;
            do
            {

                Console.WriteLine("Escriba 1-Coche 2-Avion 3-Vehiculo para ver sus métodos");
                opcion = int.Parse(Console.ReadLine());

                if (opcion != 4)
                {
                    CVehiculo vehiculo = opcion switch
                    {
                        1 => new CCoche(),
                        2 => new CAvion(),
                        _ => new CVehiculo()

                    };

                    vehiculo.Conducir();
                    vehiculo.DetenerMotor();
                    vehiculo.PonerEnMarchaMotor();
                }

            } while (opcion != 4);
        }
    }
}
