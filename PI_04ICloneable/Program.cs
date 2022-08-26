using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_04ICloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Una clonación de un objeto que después de clonarse sea un objeto independiente, se usa 
              clone de la interfaz ICloneable, para esto hay eque implentar su método,
              cuando se hiciera
                CAuto auto1 = new CAuto("MWX", 300);
                CAuto auto2;
                CAuto auto1= auto2; Esto no es una clonación ya que auto2, estaría referenciandose a auto1
                                    //Lo que significa que lo que se haga en auto1, se reflejaria en auto2 y
                                    //vicevesa
                
             */

            CAuto auto1 = new CAuto("MWX", 300);

            auto1.CalcularTenencia(500);
            auto1.Costo = 0.5;           
            auto1.MostrarInformacion();

            Console.WriteLine("-----");

            CAuto auto2 =(CAuto)auto1.Clone();
            auto1.MostrarInformacion();
            auto2.MostrarInformacion();

            Console.WriteLine("-----");

            auto1.Costo=20;

            auto1.MostrarInformacion();
            auto2.MostrarInformacion();

            Console.WriteLine("----");
            Console.ReadLine();
        }
    }
}
