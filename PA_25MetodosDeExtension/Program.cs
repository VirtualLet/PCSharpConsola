using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_25MetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extension del int
            int numero = 55;
            double numDob = 40;

            bool par = numero.EsPar(); //Aqui encontramos la extensión
            Console.WriteLine("{0} es {1}",numero,par);

            double numDoble = numDob.DoblaValor();
            Console.WriteLine("{0} su doble es: {1}",numDob,numDoble);

            //Aqui ocupamos la extension para a la clase persona añadirle el método ProyeccionEdad
            //Que no tiene incluido en la clase original
            CPersona persona = new CPersona("Laura",40);
            int years = 25;            
            Console.WriteLine(persona);
            Console.WriteLine("Edad: {0}, en {1} años tendra: {2}\n",persona.Edad,years,persona.ProyeccionEdad(years));

            
            CIngreso ingreso = new CIngreso(300);
            Console.WriteLine(ingreso);
            ingreso.Sonido();//tiene acceso al método sonido ya que CIngreso implementa  IBienvenida

            Console.ReadLine();
        }
        public void Informativo()
        {
            string.Format("Los métodos de extension es una técnica por el cual" +
                "se puede adiconar un comportamiento, es decir un método a una clase" +
                "que no se tenga acceso al código o por alguna razón no deseemos modificarla" +
                "directamente ya sea por tener herencia y temer afectar el funcionamiento en el proyecto");
        }
    }
}
