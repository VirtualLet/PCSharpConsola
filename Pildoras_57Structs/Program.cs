using System;

namespace Pildoras_57Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando Struct!");
            /* No permite la declaración de constructor por defecto
             * El compilador no inicia los campos. Puedes iniciarlos en el constructor.
             * No puede haber sobrecarga de constructores
             * No heredan de otras clases pero si implementan interfaces
             * Son selladas (sealed)
             */

            Empleado empleado = new Empleado("Juan", 1000, 400);
            Console.WriteLine(empleado);
            //En este caso el valor del incremento no se vera reflejado ya que al ser un struct y no una 
            //clase el cambio lo realiza en la copia y no en la instancia original ya que struct
            //usa valor(stack) a diferencia de la clase que utiliza Referencia(heap)
            empleado.CambiarSalario(empleado, 5);
            Console.WriteLine(empleado);
            Console.WriteLine("----------");
            //para hacer el cambio se tiene que especificar de otra manera pero no por referencia
            empleado.CambiarSalario(4);
            Console.WriteLine(empleado);
            empleado.CambiarSalario(10);
            Console.WriteLine(empleado);

            Empleado empleado1 = new Empleado("Teresa", 200, 100);
            empleado1.CambiarSalario(2);
            Console.WriteLine(empleado1);
            Console.ReadLine();
        }
    }
}
