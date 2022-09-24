using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_11DelegadosIII
{
    delegate void delMetodoInt(int pValor); //Creando el delegado
    class CRefri
    {
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

        //Hacemos multicasting , Estos permiten referenciar las variables
        public void AdicionaMetodoKilos(delMetodoInt pMetodo)
        {
            delMetodoKilos += pMetodo;
        }

        public void EliminaMetodoKilos(delMetodoInt pMetodo)
        {
            delMetodoKilos -= pMetodo;
        }
        public void AdicionaMetodoGrados(delMetodoInt pMetodo)
        {
            delMetodoGrados += pMetodo;
        }

   
        public void TrabajarConEliminar(int pConsumo, delMetodoInt pMetodo)
        {
            kilos -= pConsumo;
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} kilos, {1} grados", kilos, grados);

            if (kilos == 5)
            {
                delMetodoKilos -= pMetodo;
            }


            if (kilos < 15)
            {
                //Invoca los métodos que tiene en su lista interna el Delegado
                // y acada uno le manda el parametro de kilos
                delMetodoKilos(kilos);
            }

            

            if (grados > 0)
            {
                delMetodoGrados(grados);
            }
        }


        public void Trabajar(int pConsumo)
        {
            kilos -= pConsumo;
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} kilos, {1} grados", kilos, grados);

            if (kilos < 15)
            {
                //Invoca los métodos que tiene en su lista interna el Delegado
               // y acada uno le manda el parametro de kilos
                delMetodoKilos(kilos);                
            }

            if (grados > 0)
            {
                delMetodoGrados(grados);
            }
        }
    }
}