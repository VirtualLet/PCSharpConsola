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
                    CVehiculo vehiculo;//= new CVehiculo();
                    switch (opcion)
                    {
                        case 1: vehiculo = new CCoche();
                            ((CCoche)vehiculo).Acelerar();
                            ((CCoche)vehiculo).Frenar();
                            break;
                        case 2: vehiculo = new CAvion();
                            ((CAvion)vehiculo).Despegar();
                            ((CAvion)vehiculo).Aterrizar();
                            break;
                        default: vehiculo = new CVehiculo(); break;                      
                    }

                    vehiculo.Conducir();
                    vehiculo.DetenerMotor();
                    vehiculo.PonerEnMarchaMotor();
                }

            } while (opcion != 4);
        }
    }
}
