using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_12Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indexer Ejemplo");
            CTiendaAutos tiendaAutos = new CTiendaAutos();
            CAuto auto = tiendaAutos[1];
            auto.MuestraInformacion();

            Console.WriteLine("--modifica elemento de la posicion 1");
            CAuto otroAuto = new CAuto("Vocho", 400);
            tiendaAutos[1] = otroAuto;

            Console.WriteLine("numero de elementos:{0}", tiendaAutos.TotalRegistros);

            for (int i = 0; i < tiendaAutos.TotalRegistros; i++)
            {
                Console.WriteLine("[{0}]=", i);
                tiendaAutos[i].MuestraInformacion();
            }

            Console.WriteLine("--Mostrando información con foreach ya implementando IEnumerator");
            foreach( CAuto item in tiendaAutos)
            {
                Console.WriteLine(item.GetInformacion());
            }

        }

        public void Informativo()
        {
            string.Format("Indexer" +
                "Es similar a las propiedades" +
                "Se utiliza con arreglos o estructuras similares");
        }
    }
}
