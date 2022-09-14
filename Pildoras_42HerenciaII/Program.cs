    using System;

namespace Pildoras_42HerenciaII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrando herencia");
            CHumano humano = new CHumano();
            CCaballo caballo = new CCaballo();
            CGorila gorila = new CGorila();
            caballo.CuidarCrias();
            caballo.Galopar();

            //Estoy haciendo un casting para poder acceder a los metodos que sólo estan definidos en la 
            //clase CHumano y no en la clase que hereda
            Console.WriteLine("Haciendo un casting");
            CMamifero mamifero = new CHumano();
            ((CHumano)mamifero).Pensar();
            Object gorilaObj = new CGorila();
            ((CGorila)gorilaObj).Trepar();

            Console.ReadLine();
        }
    }
}
