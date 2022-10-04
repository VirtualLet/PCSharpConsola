using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_03IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lección 03 IEnumerator
            Console.WriteLine("ImplementandoIEnumerator");
      
            CContenedora datos = new CContenedora();

            foreach (int valor in datos)
            {
                Console.WriteLine(valor);
            }

            Console.ReadLine();
        }

    }
}
