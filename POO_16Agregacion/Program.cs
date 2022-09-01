using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_16Agregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            CPropietario propietario = new CPropietario("Raul");
            CEdificio edificio = new CEdificio("5 de Mayo", 4, 2);
            propietario.MostrarPropiedad();
            //Se adiciona la propiedad
            propietario.AdicionarPropiedad(edificio);
            propietario.MostrarPropiedad();
           
            //Se elimina el propietario
            propietario = null;
            GC.Collect();

            //propietario.MostrarPropiedad();
            Console.WriteLine("-----------");
            edificio.Muestra();

            Console.ReadLine();
        }
    }
}
