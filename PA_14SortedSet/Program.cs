using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_14SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<CPunto> sortPuntos = new SortedSet<CPunto>()
            {
                new CPunto(3,7),
                new CPunto(8,11),
                new CPunto(2,6)
            };
            
            foreach(CPunto item in sortPuntos) Console.WriteLine("->{0}", item);
            Console.WriteLine("--------------");
            sortPuntos.Add(new CPunto(1, 15));
            sortPuntos.Add(new CPunto(1, 2));
            foreach (CPunto item in sortPuntos) Console.WriteLine("->{0}", item);

            Console.ReadLine();
        }
    }
}
