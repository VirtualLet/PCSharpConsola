using System;
using System.Collections.Generic;

namespace Pildoras_68DelegadosPredicados
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrandoDelegadosPredicadosyUsodeMetodoFindAlldeLaLista();

            Console.WriteLine("\nMostrando Predicado usando Clases \n");           
            List<CPersona> listPersona = new List<CPersona> {
                    new CPersona { Nombre = "Leticia", Edad = 37 },
                    new CPersona { Nombre = "Lucia", Edad = 7 },
                    new CPersona { Nombre = "Lia", Edad = 30 },
                    new CPersona { Nombre = "Laura", Edad = 17 }};

            listPersona.AddRange(new CPersona[]{ new CPersona { Nombre = "Tomas", Edad = 20 },
                                                 new CPersona { Nombre = "Pedro", Edad = 4 } });
            CPersona persona1 = new CPersona();
            persona1.Nombre = "Tylor";
            persona1.Edad = 32;
            CPersona persona2 = new CPersona { Nombre = "Marcus", Edad = 20 };

            listPersona.AddRange(new CPersona[] { persona1, persona2 });

            foreach(CPersona item in listPersona)
            {
                Console.WriteLine("{0} {1} ",item.Nombre,item.Edad);
            }

            Predicate<CPersona> preDelPersona = new Predicate<CPersona>(ExisteNombre);

            //Haciendo uso del MÉTODO FIND de la lista que pide como argumento un predicado y devuelve resultado en el tipo del predicado
            CPersona personaResultado= listPersona.Find(preDelPersona);            
            Console.WriteLine("\nNombre:{0} Edad{1}",personaResultado.Nombre,personaResultado.Edad);

            Console.WriteLine("------------------");
            //Usando MÉTODO EXISTS de la lista que pide un predicado y devuelve un bool de resultado
            bool existeLaPersona = listPersona.Exists(preDelPersona);
            Console.WriteLine("\nHay personas con el nombre de Lia {0}",existeLaPersona);

            //Usando Método FINDALL de la lista que pide un predicado y devuelve una lista
            preDelPersona = new Predicate<CPersona>(ExistenMayoresDeEdad);
            List<CPersona> personasMayoresDeEdad = listPersona.FindAll(preDelPersona);

            Console.WriteLine("Las personas de la lista mayores de edad encontradas:");
            foreach(CPersona item in personasMayoresDeEdad)
            {
                Console.WriteLine("{0} {1}", item.Nombre, item.Edad);
            }

            Console.ReadLine();
        }

        static bool ExistenMayoresDeEdad(CPersona persona)
        {
            if (persona.Edad > 18)
                return true;
            else
                return false;            
        }

        static bool ExisteNombre(CPersona persona)
        {
            if (persona.Nombre == "Lia")
                return true;
            else
                return false;
        }


        public static void MostrandoDelegadosPredicadosyUsodeMetodoFindAlldeLaLista()
        {
            Console.WriteLine("Mostrando Delegados Predicados!");
            List<int> listNumeros = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            listNumeros.AddRange(new int[] { 8, 9, 10 });
            //Declarando Delegado Predicado
            Predicate<int> preDelPredicado = new Predicate<int>(ElNumeroEsPar); 

            Console.WriteLine("Mostrando numeros pares");
            //Usando método FindAll de la lista que pide un predicado y devuelve una lista
            List<int> listNumerosPares = listNumeros.FindAll(preDelPredicado);
            foreach (int item in listNumerosPares)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nMostrando numeros primos");
            preDelPredicado = new Predicate<int>(ElNumeroEsPrimo);
            List<int> listNumerosPrimos = listNumeros.FindAll(preDelPredicado);
            foreach (int item in listNumerosPrimos)
            {
                Console.WriteLine(item);
            }
        }

        static bool ElNumeroEsPrimo(int numero)
        {
            bool esPrimo = true;
            if (numero > 2)
            {               
                for (int i=2; i<numero; i++)
                {
                    if (numero % i == 0)
                    {                        
                        return esPrimo = false;
                    }
                }
                return esPrimo;
            }
            else return esPrimo=false;
        }

        static bool ElNumeroEsPar(int numero)
        {
            if (numero % 2 == 0) 
                return true; 
            else 
                return false;
        }

        private void Informativo()
        {
         string info=   string.Format("Son delegados que devuelven true o false \n" +
                "Sirven para muchas tareas diferentes" +
                "Muy utilizados para filtrar listas de valores comprobando si una condición " +
                "es cierta para un valor dado" +
                "Sintaxis: Predicate<T>NombrePredicado=new Predicate<T>(funcionDelgado)");
        }

    }
}
