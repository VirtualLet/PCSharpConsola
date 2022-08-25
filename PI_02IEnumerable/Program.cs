using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_02IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             public interface IEnumerable
            {
                IEnumerator GetEnumerator();
            }

            public interface IEnumerator
            {
                bool MoveNext();
                object Current {get;}
                void Reset();                
            }
             */
            ImplementandoIEnumerator();

        }

        private static void UsoIEnumeratorIncluidoEnArreglos()
        {
            CTiendaAuto cTienda = new CTiendaAuto();

            foreach (CAuto auto in cTienda)
            {
                auto.CalcularTenencia(0.15);
                auto.MostrarInformacion();
            }
            Console.ReadLine();
        }

        private static void ImplementandoIEnumerator()
        {
            CContenedora datos = new CContenedora();
            foreach(int valor in datos)
            {
                Console.WriteLine(valor);
            }
            Console.ReadLine();
        }




    }
}
