using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_07InterfazCallback
{
    class Program
    {
        static void Main(string[] args)
        {
            CRefri refri = new CRefri(50, -20);
            Random random = new Random();
            //se crea el sink 
            CRefriSink sink1 = new CRefriSink();
            refri.AgregarSink(sink1);

            while (refri.Kilos > 0)
            {
                refri.Trabajar(random.Next(1, 5));
            }

            Console.ReadLine();
        }
    }
}
