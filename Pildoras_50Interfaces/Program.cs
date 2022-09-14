using System;

namespace Pildoras_50Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Viendo Interfaces!\n");
                /*"Restricciones:\n" +
                ".No se permite definir campos (variables) en interfaces\n" +
                ".No se pueden definir constructores\n" +
                ".No se pueden definir destructores\n" +
                ".No se pueden especificar modificadores de acceso en métodos " +
                "(Todos son public de forma implícita)\n" +
                ".No se pueden anidar clases ni otro tipo de estructuras en las interfaces.\n");*/

            CGorila gorila = new CGorila("Cesar");
            CCaballo caballo = new CCaballo("Pinto");
            CBallena ballena = new CBallena("Willy");

            Console.WriteLine(ballena);
            ballena.GetNombre();
            ballena.Nadar();

            Console.WriteLine();
            Console.WriteLine(gorila);
            gorila.GetNombre();
            Console.WriteLine("Numero de patas:{0}",gorila.NumeroPatas());

            Console.WriteLine();
            Console.WriteLine(caballo);
            caballo.GetNombre();
            Console.WriteLine("Identificador terrestre {0}",caballo.IdentificadorTerrestre());

            IMamiferosTerrestres IMCaballo = new CCaballo("pinto");
            ISaltoConPatas ISCaballo = new CCaballo("pinto");
            Console.WriteLine("Mamifero Numero de patas:{0}", IMCaballo.NumeroPatas());
            Console.WriteLine("Puede saltar con {0} patas",ISCaballo.NumeroPatas());

            Console.ReadLine();

        }
    }
}
