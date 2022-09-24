using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_10DelegadoIIModificado
{
  
    class CRefri
    {
        public delegate void delMetodoInt(int pValor); //Creando el delegado

        private delMetodoInt delMetodoKilos;
        private delMetodoInt delMetodoGrados;

        private int kilos = 0;
        private int grados = 0;

        public CRefri(int pKilos, int pGrados)
        {
            kilos = pKilos;
            grados = pGrados;
        }

        public int Kilos { get => kilos; }
        public int Grados { get => grados; }

        public void AdicionaMetodoKilos(delMetodoInt pMetodo)
        {
            delMetodoKilos = pMetodo;
        }
        public void AdicionaMetodoGrados(delMetodoInt pMetodo)
        {
            delMetodoGrados = pMetodo;
        }


        public void TrabajarMetodo(int pConsumo)
        {
            kilos -= pConsumo;
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} kilos, {1} grados", kilos, grados);

            if (kilos < 10)
            {
                delMetodoKilos(kilos);
            }

            if (grados > 0)
            {
                delMetodoGrados(grados);
            }
        }


        public void TrabajarProbando(int pConsumo, delMetodoInt pMetodoKilos, delMetodoInt pMetodoGrados)
        {
            kilos -= pConsumo;
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} kilos, {1} grados", kilos, grados);

            if (kilos < 10)
            {
                pMetodoKilos(kilos);
            }

            if (grados > 0)
            {
                pMetodoGrados(grados);
            }
        }

    }

}
