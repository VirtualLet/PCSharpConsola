using System;

namespace Pildoras_43Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {               
                
                Console.WriteLine("Escriba 1-Coche 2-Avion 3-Vehiculo para ver sus métodos");
                opcion = int.Parse(Console.ReadLine());

                if (opcion != 4)
                {
                    Vehiculo vehiculo = opcion switch
                    {
                        1 => new Coche(),
                        2 => new Avion(),
                        _ => new Vehiculo()

                    };

                    vehiculo.Conducir();
                    vehiculo.DetenerMotor();
                    vehiculo.PonerEnMarchaMotor();
                }

            } while (opcion != 4);



        }
    }
}
