using System;

namespace Pildoras_43HerenciaIII_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Usando herencia con constructores");

            CHumano humano = new CHumano("Lety");
            CCaballo caballo = new CCaballo("Copito");
            CGorila gorila = new CGorila("Ramon");

            humano.GetNombre();
            humano.Pensar();
            humano.Respirar();
           
            Console.ReadLine();

        }
    }
}
