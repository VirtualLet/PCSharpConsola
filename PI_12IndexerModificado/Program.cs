using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_12IndexerModificado
{
    class Program
    {
        static void Main(string[] args)
        {
            CTiendaAuto tiendaAuto = new CTiendaAuto();

            Console.WriteLine("----Muestra información de  posición 1:");
              CAuto auto = tiendaAuto[1];
              auto.MuestraInformacion();

            Console.WriteLine("\n---ListaOriginal");
            for (int i = 0; i < tiendaAuto.TotalRegistro; i++)
            {
                tiendaAuto[i].MuestraInformacion();
            }

            Console.WriteLine("\n");
            CAuto otroAuto = new CAuto("Vocho", 400);
            tiendaAuto[1] = otroAuto;

            Console.WriteLine("---Cambiando valor de \n{0} por {1}\n",auto,otroAuto);

            tiendaAuto.AgregarItems(new CAuto("metro", 220));
            tiendaAuto.AgregarItems(new CAuto("taxi", 400));

            Console.WriteLine("numero de elementos:{0}\n", tiendaAuto.TotalRegistro);

            //Una vez implementando iEnumerator ya se puede usar foreach
            foreach (CAuto item in tiendaAuto)
            {
                item.MuestraInformacion();
            }

            Console.ReadLine();
        }
    }
}
