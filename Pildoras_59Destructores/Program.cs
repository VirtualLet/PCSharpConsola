using System;
using System.IO;

namespace Pildoras_59Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrando funcionamiento del destructor!");
            ManejoArchivos manejoArchivos = new ManejoArchivos();
            manejoArchivos.Mensaje();

            /*A tener en cuenta
             * Los destructores solo se usan en clases
             * Cada clase solo puede tener un destructor
             * Los destructores no se heredan ni se sobrecargan
             * Los destructores no se llaman. Son invocados automáticamente
             * Los destructores no tienen modificadores de acceso ni parámetros
             */
            Console.ReadLine();
        }

     
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;
        public ManejoArchivos()
        {
            archivo = new StreamReader(@"..\..\..\Texto.txt");
            //archivo = new StreamReader(@"H:\GitProyectos\PCsharpConsola\Pildoras_59Destructores\Texto.txt");
            while((linea= archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }
        public void Mensaje()
        {
            Console.WriteLine("Hay {0} lineas",contador);
        }
        ~ManejoArchivos()
        {            
            archivo.Close();
            archivo.Dispose();           
        }
    }
}
