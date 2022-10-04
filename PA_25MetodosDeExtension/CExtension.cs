using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_25MetodosDeExtension
{
    //Las clases donde se guardan las extensiones debe de ser estatica
    static class CExtension
    {
        /*El método que extiende debe de ser estatico
         *El primer parametro lleva this y representa al tipo que se esta extendiendo
        */        
        public static bool EsPar(this int valor)
        {
            if (valor % 2 == 0) 
                return true;
            else 
                return false;
        }

        //Extiende a un doble
        public static double DoblaValor(this double valor)
        {
            return valor * 2;
        }
        //Extiende a la clase CPersona
        public static int ProyeccionEdad(this CPersona persona, int years)
        {
            return persona.Edad +years;
        }

        //Extiende  solo alas clases que implementen IBienvenida
        public static void Sonido(this IBienvenida obj)
        {
            Console.WriteLine("Llamando al método de sonido que no se escucha jaja");
        }


    }
}
