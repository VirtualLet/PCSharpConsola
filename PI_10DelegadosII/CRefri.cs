using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_10DelegadosII
{
    class CRefri
    {      

        public delegate void delReservasBajas(int pKilos);
        public delegate void delDescongeladoGrados(int pGrados);

      
        private delReservasBajas delReservas;
        private delDescongeladoGrados delDescongelado;

        private int kilos = 0;
        private int grados = 0;

        public CRefri(int pKilos, int pGrados)
        {
            kilos = pKilos;
            grados = pGrados;
        }

        public int Kilos { get => kilos; }
        public int Grados { get => grados; }

   
        public void AdicionaMetodoReservas(delReservasBajas pMetodo)
        {
            delReservas = pMetodo;
        }

        public void AdicionaMetodoDescongelado(delDescongeladoGrados pMetodo)
        {
            delDescongelado = pMetodo;
        }

        public void Trabajar(int pConsumo)
        {
            kilos -= pConsumo;
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} kilos, {1} grados",kilos,grados);

            if (kilos < 10)
            {
                delReservas(kilos);
            }

            if (grados > 0)
            {
                delDescongelado(grados);
            }
        }
    }
}
