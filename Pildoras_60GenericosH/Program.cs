using System;
using System.Collections.Generic;

namespace Pildoras_60GenericosH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usando herencia para entender la diferencia entre usar los genericos!");

            //MostrandoConTipoString();
            //MostrandoConUsoDeClase();


            Console.WriteLine("Usando ahora clase generica");
            CAlmacenObjetosGenerico<CEmpleado> almacenObjetos = new CAlmacenObjetosGenerico<CEmpleado>(3);
            almacenObjetos.AgregarElemento(new CEmpleado(100));
            almacenObjetos.AgregarElemento(new CEmpleado(300));
            almacenObjetos.AgregarElemento(new CEmpleado(400));

            CEmpleado empleado = almacenObjetos.GetElemento(2);
            Console.WriteLine(empleado.Salario);

            Console.WriteLine("--Obteniendo Array--");

            CEmpleado[] ArregloEmpleado = almacenObjetos.GetArray();           
            Console.WriteLine("El salario es {0} ",ArregloEmpleado[2].Salario);

            Console.WriteLine("--Mostrando ahora con strings con la clase generica--");
            CAlmacenObjetosGenerico<string> almacenStrings = new CAlmacenObjetosGenerico<string>(3);
            almacenStrings.AgregarElemento("uno");
            almacenStrings.AgregarElemento("dos");
            almacenStrings.AgregarElemento("tres");
            Console.WriteLine("arreglo string en posición 1 es:{0}",almacenStrings.GetElemento(1));

            Console.ReadLine();
        }

        public static void MostrandoConTipoString()
        {

            CAlmacenObjetos arrayGenerico = new CAlmacenObjetos(3);
            arrayGenerico.AgregarElemento("Juan");
            arrayGenerico.AgregarElemento("Laura");
            arrayGenerico.AgregarElemento("Edith");

            string nombrePersona = (String)arrayGenerico.GetElemento(2);
            Console.WriteLine(nombrePersona);

            Console.WriteLine("Muestra elementos");
            arrayGenerico.MuestraElementosArray();

            Console.WriteLine("------");
        }

        public static void MostrandoConUsoDeClase()
        {

            CEmpleado empleado1 = new CEmpleado(400);

            CAlmacenObjetos almacenObjetos = new CAlmacenObjetos(3);
            almacenObjetos.AgregarElemento(new CEmpleado(100));
            almacenObjetos.AgregarElemento(new CEmpleado(300));
            almacenObjetos.AgregarElemento(empleado1);

            CEmpleado empleado = (CEmpleado)almacenObjetos.GetElemento(2);
            Console.WriteLine(empleado.Salario);

            Console.WriteLine("--Obteniendo Array--");

            Object[] ArregloEmpleado = almacenObjetos.GetArray();
            CEmpleado empleado2 = (CEmpleado)ArregloEmpleado[2];
            Console.WriteLine(empleado2.Salario);
        }

    }
}
