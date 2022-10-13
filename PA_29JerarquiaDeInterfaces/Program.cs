using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_29JerarquiaDeInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jerarquia de interfaces
            CSuma suma = new CSuma();
            suma.Calcular(5, 3);
            suma.MostrarDatos();

            Console.ReadLine();
        }
    }
}
