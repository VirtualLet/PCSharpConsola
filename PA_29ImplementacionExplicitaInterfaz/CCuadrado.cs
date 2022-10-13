using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_29ImplementacionExplicitaInterfaz
{
    /*Implementa dos interfaces que tienen métodos con el  mismo nombre
      Esto se resuelve con la implementación explicita de interfaces*/
    class CCuadrado : IArea, IPerimetro
    {
        private int lado;
        public CCuadrado(int pLado)
        {
            lado = pLado;
        }
        void IArea.Calcular() //Declaración en forma explicita
        {
            Console.WriteLine("Calcular Area={0}",lado*lado);
        }

        void IPerimetro.Calcular() //Declaración en forma explicita
        {
            Console.WriteLine("Calcular Perimetro={0}",lado*4);
        }
    }
}
