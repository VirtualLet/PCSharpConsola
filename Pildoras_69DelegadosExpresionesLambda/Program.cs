using System;
using System.Collections.Generic;

namespace Pildoras_69DelegadosExpresionesLambda
{
    class Program
    {
        public delegate int IntDelegado(int pNumero);
        public delegate int IntDelegadoParam(int pNumero1, int pNumero2);
        public delegate bool DelBoolCompara(int pEdad1, int pEdad2);
        public delegate bool DelBoolComparaString(string pNombreUno, string pNombreDos);
        static void Main(string[] args)
        {
            Console.WriteLine("Delegados con expresiones lambda!");
            //Uso del delegado
            IntDelegado intDelegado = new IntDelegado(FuncionCuadratica);

            Console.WriteLine(intDelegado(2));
            //usando expresiones lambda
            intDelegado = new IntDelegado(numero => numero * numero);

            Console.WriteLine(intDelegado(16));

            Console.WriteLine("----");
            IntDelegadoParam intDelegadoParam = new IntDelegadoParam(FuncionSuma);
            Console.WriteLine(intDelegadoParam(2, 45));
            //Usando expresiones lambda
            intDelegadoParam = new IntDelegadoParam((num1, num2) => num1 + num2);

            Console.WriteLine(intDelegadoParam(4, 5));

            Console.WriteLine("-----");
            List<int> listNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> listNumerosPares = listNumeros.FindAll(i => i % 2 == 0);

            foreach (int item in listNumerosPares)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Haciendo foreach usando expresiones lambda");
            listNumerosPares.ForEach(numero => Console.WriteLine(numero));
            Console.WriteLine("----------------");

            CPersona personaUno = new CPersona { Nombre = "Juan", Edad = 18, Logros = 3 };
            CPersona personaDos = new CPersona { Nombre = "Edith", Edad = 35, Logros = 3 };
            //Delegado con expresion lambda
            DelBoolCompara delComparaInt = new DelBoolCompara((personaUno, personaDos) => personaUno == personaDos);

            Console.WriteLine("La edad es igual?{0}", delComparaInt(personaUno.Edad, personaDos.Edad));
            Console.WriteLine("La cantidad de logros es igual?{0}", delComparaInt(personaUno.Logros, personaDos.Logros));
            Console.WriteLine("-----");
            DelBoolComparaString delComparaString = new DelBoolComparaString((personaUno, personaDos) => personaUno == personaDos);
            Console.WriteLine("Los nombres son iguales?{0}", delComparaString(personaUno.Nombre, personaDos.Nombre));



            Console.ReadLine();
        }


        public static int FuncionSuma(int pNumeroUno, int pNumeroDos)
        {
            return pNumeroUno + pNumeroDos;
        }

        public static int FuncionCuadratica(int numero)
        {
            return numero * numero;
        }

        public void Informativo()
        {
            string info = String.Format("Expresiones lambda" +
                "Son funciones anónimas" +
                "Sirven para ejecutar funciones que no necesitan ser nombradas" +
                "Para simplificar el código" +
                "Se utilizan al crear delegados sencillos" +
                "En expresiones LINQ query" +
                "Etc" +
                "Sintaxis: Parámetros => expresión/bloque de sentencia");
        }
    }
}
