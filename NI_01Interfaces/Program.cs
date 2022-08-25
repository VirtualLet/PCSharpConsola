using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NI_01Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            PI_01Interface();
        }


        private static void PI_01Interface()
        {
            string valor;
            double valorA = 0.0;
            double valorB = 0.0;
            int opcion = 0;
            IOperacion operacion = new Suma();

            while (opcion < 5)
            {
                Console.WriteLine("1:Suma, 2:Resta, 3: Multiplicación, 4:División");
                Console.WriteLine("Escribe opción");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion < 5)
                {
                    Console.WriteLine("Dame el valorA");
                    valor = Console.ReadLine();
                    valorA = Convert.ToDouble(valor);
                    Console.WriteLine("Dame el valorB");
                    valor = Console.ReadLine();
                    valorB = Convert.ToDouble(valor);
                }

                switch (opcion)
                {
                    case 1: operacion = new Suma(); break;
                    case 2: operacion = new Resta(); break;
                    case 3: operacion = new Multiplicacion(); break;
                    case 4: operacion = new Division(); break;
                }

                operacion.Calcular(valorA, valorB);
                operacion.Mostrar();
            }
        }


    }
}
