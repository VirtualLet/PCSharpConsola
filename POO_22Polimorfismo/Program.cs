using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_22Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            CAnimal animal = new CAnimal();
            int opcion;
            Console.WriteLine("Que mascota quieres: 1-Reptil 2-Pato 3-Pez 4-Gato");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: animal = new CReptil(); break;
                case 2: animal = new CPato();break;
                case 3: animal = new CPez(); break;
                case 4: animal = new CGato();break;
            }
            Console.WriteLine("Dame el nombre");
            animal.Nombre = Console.ReadLine();
            Console.WriteLine(animal.Moverse());

            Console.ReadLine();

        }
    }
}
