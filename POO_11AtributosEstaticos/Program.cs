using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_11AtributosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            CTipoDeCambio tipoDeCambio = new CTipoDeCambio();
            tipoDeCambio.MuestraDolares();
            tipoDeCambio.TipoCambio = 20;
            tipoDeCambio.MuestraDolares();
            Console.WriteLine("-----------");
            CTipoDeCambio tipoDeCambio1 = new CTipoDeCambio();

            tipoDeCambio1.TipoCambio = 10;//Hace el cambio y como es un atributo estatico lo refleja en todos
            tipoDeCambio1.MuestraDolares();
            tipoDeCambio.MuestraDolares();
            Console.ReadLine();

        }
    }
}
