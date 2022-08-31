using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_12MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase normal
            CCalculadora calculadora = new CCalculadora(10, 3);
            calculadora.Suma();
            Console.WriteLine("La suma es:{0}", calculadora.Resultado);
            calculadora.Resta();
            Console.WriteLine("La resta es:{0}", calculadora.Resultado);

            //Clase con métodos staticos
            double resultado = 0.0;
            resultado=  CCalcualdoraS.Suma(5, 10);
            Console.WriteLine("La suma es:{0}",resultado);
            resultado = CCalcualdoraS.Resta(5, 10);
            Console.WriteLine("La resta es:{0}", resultado);

            CCalcualdoraS calcualdoraS = new CCalcualdoraS();
            calcualdoraS.Saludos();
            Console.ReadLine();
        }
    }
}
