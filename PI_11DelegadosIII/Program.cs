using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_11DelegadosIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haciendo uso de delegados en dos vias");

            CRefri refri = new CRefri(50, -20);
            Random random = new Random();

            //Variables para el multicasting, se requier la instancia para poder adiconar o eliminar
            delMetodoInt kilos = new delMetodoInt(InformeKilos);
            delMetodoInt viveres = new delMetodoInt(CTienda.MandarViveres);
            delMetodoInt grados = new delMetodoInt(InformeGrados);

            //Adicionamos los handlers
            refri.AdicionaMetodoKilos(kilos);
            refri.AdicionaMetodoKilos(viveres);
            refri.AdicionaMetodoGrados(grados);
                    
            //El refri trabaja
            while (refri.Kilos > 0)
            {
                //if (refri.Kilos == 5)
                //{
                //    refri.EliminaMetodoKilos(viveres);
                //}
                // refri.Trabajar(random.Next(1, 5));
                refri.TrabajarConEliminar(random.Next(1, 5), viveres);
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
