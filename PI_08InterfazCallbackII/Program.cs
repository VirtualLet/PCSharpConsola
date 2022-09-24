using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_08InterfazCallbackII
{
    class Program
    {
        static void Main(string[] args)
        {
            CRefri refri = new CRefri(50, -20);
            Random random = new Random();
            //se crea el sink 
            CRefriSink sinkRefri = new CRefriSink();
            CTiendaSink sinkTienda = new CTiendaSink();
            refri.AgregarSink(sinkRefri);
            refri.AgregarSink(sinkTienda);

            while (refri.Kilos > 0 && sinkRefri.Parar==false)
            {
                refri.Trabajar(random.Next(1, 5));
            }

            Console.ReadLine();
        }
    }
}
