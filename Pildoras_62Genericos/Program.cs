using System;

namespace Pildoras_62Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clases Genericas con restricciones!");
            CAlmacenEmpleadosT<CDirector> almacenEmpleadosT = new CAlmacenEmpleadosT<CDirector>(3);
            almacenEmpleadosT.AgregarElemento(new CDirector(200));
            almacenEmpleadosT.AgregarElemento(new CDirector(300));
            almacenEmpleadosT.AgregarElemento(new CDirector(100));

            /*Aqui se puede ver el uso de la restricción de la clase generica ya que no
             * permite hacer uso de la clase generica a las clases que no implementen IParaEmpleados
             */
           // CAlmacenEmpleadosT<CEstudiante> cAlmacenEstudiante = new CAlmacenEmpleadosT<CEstudiante>(2);
        }
    }
}
