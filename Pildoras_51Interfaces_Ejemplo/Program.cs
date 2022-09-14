using System;

namespace Pildoras_51Interfaces_Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avisos!");

            CAvisoTrafico avisoTrafico = new CAvisoTrafico();
            avisoTrafico.MostrarAviso();

            CAvisoTrafico avisoTrafico1 = new CAvisoTrafico("22-04-2022", "INE", "Actualizar credencial");
            Console.WriteLine(avisoTrafico1.GetFecha());
            avisoTrafico1.MostrarAviso();

            Console.ReadLine();
        }
    }
}
