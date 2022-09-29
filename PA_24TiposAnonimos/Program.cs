using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_24TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string.Format("Creamos tipos anonimos" +
                "Crea un tipo temporal con atributos, propiedades, ToString" +
                "A tener en cuenta, un tipo anonimo es una clase sellada" +
                "Los atributos no se pueden modificar ya que son de sólo memoria" +
                "No puede contener métodos, herencia" +
                "Su mayor uso es en Linq");
            //Se crea el tipo anonimo            
            var Compu = new { Procesador = "7i", Memoria = 16, Graficos = "Intel" };

            //se imprime la variable
            Console.WriteLine(Compu);

            //Se imprime el valor del atributo memoria
            Console.WriteLine("De memoria tiene {0}",Compu.Memoria);

            //No se puede modificar el atributo ya que es de sólo memoria
            //Compu.Graficos = "Nvidia";

            Console.ReadLine();
        }
    }
}
