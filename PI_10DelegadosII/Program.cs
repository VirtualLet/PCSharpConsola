using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_10DelegadosII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haciendo uso de delegados en dos vias");

            CRefri refri = new CRefri(50, -20);
            Random random = new Random();

            //Adicionamos los handlers
            refri.AdicionaMetodoReservas(new CRefri.delReservasBajas(InformeKilos));
            refri.AdicionaMetodoDescongelado(new CRefri.delDescongeladoGrados(InformeGrados));          

            //El refri trabaja
            while (refri.Kilos > 0)
            {
                refri.Trabajar(random.Next(1, 5));
            }         

            Console.ReadLine();
        }

       
        public static void InformeKilos(int pKilos)
        {
            //para ejecutar cuando se efectue el evento
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--->Reservas bajas de alimentos, estoy a nivel de main");
            Console.WriteLine("--->Quedan {0} kilos", pKilos);
        }

        public static void InformeGrados(int pGrados)
        {
            //para ejecutar cuando se efectue el evento
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--->Se descongela el refri, estoy a nivel de main");
            Console.WriteLine("--->Quedan {0} grados", pGrados);
        }
    }
}
