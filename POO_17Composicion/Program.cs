using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_17Composicion
{
    class Program
    {
        static void Main(string[] args)
        {

            CPropietario propietario = new CPropietario("Ana");
            propietario.MostrarPropiedad();
            Console.ReadLine();
        }
    }
}
