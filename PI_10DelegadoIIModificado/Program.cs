using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_10DelegadoIIModificado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haciendo uso de delegados con dos vias");

            CRefri.delMetodoInt delMetodoK = new CRefri.delMetodoInt(InformeKilos);
            CRefri.delMetodoInt delMetodoG = new CRefri.delMetodoInt(InformeGrados);

            CRefri refri = new CRefri(70, -20);
            Random random = new Random();

            //Adicionamos los handlers
            refri.AdicionaMetodoKilos(new CRefri.delMetodoInt(InformeKilos));
            refri.AdicionaMetodoGrados(new CRefri.delMetodoInt(InformeGrados));

            //El refri trabaja
            while (refri.Kilos > 0)
            {
                refri.TrabajarMetodo(random.Next(1, 5));
            }
            Console.ReadLine();
        }



        public void OtraFormaProbando()
        {
            Console.WriteLine("Haciendo uso de delegados con dos vias");
            //Creando los handlers
            CRefri.delMetodoInt delMetodoK = new CRefri.delMetodoInt(InformeKilos);
            CRefri.delMetodoInt delMetodoG = new CRefri.delMetodoInt(InformeGrados);

            CRefri refri = new CRefri(70, -20);
            Random random = new Random();
           
            //El refri trabaja
            while (refri.Kilos > 0)
            {
                 refri.TrabajarProbando(random.Next(1, 5), delMetodoK, delMetodoG);
              
            }
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
