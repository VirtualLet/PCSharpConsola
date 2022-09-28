using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_15VarNulleableDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            UsoVar();
            TiposNulleables();
            TipoDynamic();
            Console.ReadLine();
        }

        public static void UsoVar()
        {
            string info = string.Format("Var :es una declaración implicita de variables" +
                "Solo se permiten en variables locales" +
                "No se pueden usar en atributos" +
                "No se pueden usar como tipos de retorno" +
                "Se debe de colocar un valor en el momento de la declaración y no puede ser null" +
                "No confundir con var o Variant de otros lenguajes" +
                "Es fuertemente tipificado" +
                "Se usan en Linq donde un query puede dar un resultado dinamicamente  creado");

            var a = 4;
            var b = "Hola mundo";
            var c = 14.03003;
            var d = false;
            // var e = null; no puede ser asignado como null;
            // d = 59;// una vez asignado no se puede cambiar de tipo ya que es es fuertemente tipificado
            var f = c;

            //Mostrando valores
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            //Usando reflexión par conoce el tipo
            Console.WriteLine("-----Usando reflexión par conoce el tipo");
            Console.WriteLine("a es {0}", a.GetType().Name);
            Console.WriteLine("b es {0}", b.GetType().Name);
            Console.WriteLine("c es {0}", c.GetType().Name);
            Console.WriteLine("d es {0}", d.GetType().Name);

           
        }

        public static void TiposNulleables()
        {
            //Los tipos de valor no pueden tener un null
            // int valor = null;
            string info = string.Format("Los tipos nulleables pueden representar los mismos valores " +
                "mas al valor de null" +
                "Son utiles en bases de datos, pues podemos encontrar columnas no definidas" +
                "Para definirlo usamos ?" +
                "Pero realmente creamos una instancia de Sytem.Nulleable<T>");

            Console.WriteLine("----Mostrando tipos Nulleables");

            int? dato = 5;
            Console.WriteLine("dato {0}",dato);
            dato = null;
            Console.WriteLine("dato {0}", dato);

            double? precio = null;
            precio = 6.7;
            Console.WriteLine(precio);

            /*El string no es nulleable ya que es un tipo por referencia
             * string? nombre="Laura";
             */

            //Se puede saber si una variable tiene o no valor 
            if (precio.HasValue)
                Console.WriteLine("Tiene valor {0}",precio.Value);
            else
                Console.WriteLine("No tiene valor");

            //El operador ?? nos permite asignar un valor en caso de que tenga null
            Console.WriteLine("---Mostrando uso de operador ??");
            double? numero = 12;            
            numero =numero  ?? 5.55;
            Console.WriteLine("Valor toma numero cuando este fue null: {0}",numero);
            //si tiene valor difeente de null entonces espeta su valor y no le asigna el de la condición
            numero = precio ?? 5.0;
            Console.WriteLine("Respeta el valor a comparara cuando este No fue null: {0}", numero);

        }

        public static void TipoDynamic()
        {
            Console.WriteLine("\n-----Mostrando tipi Dynamic");
            string info = string.Format("Dynamic se puede ver como una forma de System.Object" +
                "en el sentido de que cualquier valor se puede asignar a dynamic" +
                "La diferencia es que no es fuermente tipificado" +
                "Se le puede asignar cualquier tipo al inicio y posteriormente asignar otro" +
                "A diferencia de object , en dynamic se conoce el tipo hasta el tiempo de ejecución" +
                "Dynamic se puede usar como tipo de retorno" +
                "No se puede usar en expresiones lambda o en métodos anonimos" +
                "Puede resultar util si nos comunicamos con bibliotecas COM");

            dynamic a = 5;
            Console.WriteLine("Tipo {0}, valor:{1}",a.GetType(),a);
            a = "Hola mundo";
            Console.WriteLine("Tipo {0}, valor:{1}", a.GetType(), a);

        }
    }
}
