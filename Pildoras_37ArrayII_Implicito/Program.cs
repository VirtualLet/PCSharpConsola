using System;

namespace Pildoras_37ArrayII_Implicito
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array implicito
            Console.WriteLine("=====Array implicito=======");
            var datos = new[] { "Juan", "Laura", "Ramon" };
            foreach (var item in datos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------");

            var valores = new[] { 2, 3, 4, 5, 10.3 };
            foreach (var item in valores)
            {
                Console.WriteLine(item);
            }

            //Array de objetos
            Console.WriteLine();
            Console.WriteLine("=====Array de objetos========");

            Empleado personaPrueba = new("Leticia", 20);
            Console.WriteLine("----Muestra Array empleadoI");
            Empleado[] arrayEmpleadoI = {new Empleado("Alex",40),
                                        new("Laura",30) ,
                                        personaPrueba };
            foreach (var item in arrayEmpleadoI)
            {
                Console.WriteLine("Nombre:{0} Edad:{1}", item.Nombre, item.Edad);
            }

            Console.WriteLine("----Muestra Array de personaPrueba");

            Empleado[] arrayPrueba = new Empleado[] {  new Empleado("raul", 34),
                                                     new Empleado("Renato", 32),
                                                    new Empleado(){Nombre="Lilia",Edad=20 },
                                                    personaPrueba};
            foreach (var item in arrayPrueba)
            {
                Console.WriteLine("Nombre:{0} Edad:{1}", item.Nombre, item.Edad);
            }

            Console.WriteLine("----Muestra Array de empleado");
            Empleado empleado = new Empleado("Edith", 35);

            Empleado[] arrayEmpleado = new Empleado[3];
            arrayEmpleado[0] = new Empleado() { Nombre = "Laura", Edad = 28 };
            arrayEmpleado[1] = new Empleado("Lety", 37);
            arrayEmpleado[2] = empleado;

            foreach (var item in arrayEmpleado)
            {
                Console.WriteLine("Nombre:{0} Edad:{1}", item.Nombre, item.Edad);
            }

            //Array de tipos o clases anónimas
            Console.WriteLine();
            Console.WriteLine("===Array de tipos o clases anónimas========");
            var personas = new[]
            {
                new{Nombre="Juan",Edad=19},
                new{Nombre="Maria",Edad=49},
                new{Nombre="Luis",Edad=40}
            };
            Console.WriteLine(personas[0]);
            Console.WriteLine("Muestra Nombre={0},Edad={1}", personas[0].Nombre, personas[0].Edad);

            foreach (var item in personas)
            {
                Console.WriteLine("Muestra Nombre={0},Edad={1}", item.Nombre, item.Edad);
            }
            Console.ReadLine();
        }

    }

    class Empleado
    {
        string nombre;
        int edad;
        public Empleado() { }
        public Empleado(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
