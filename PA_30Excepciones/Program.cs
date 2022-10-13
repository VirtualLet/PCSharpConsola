using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_30Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //EjemploSinUsoDeExcepcionesV1();
            //EjemploConUsoDeExcepcionesV2();
            //EjemploInformacionEnExcepcionV3();
            //EjemploInformacionEnExcepcionV4();
            // EjemploExcepcionesPropias();
            EjemploExcepcionesMultiples();
            Console.ReadLine();
        }
        public void Informativo()
        {
            string.Format("Información en las Excepciones" +
                "TargetSite" +
                "Message" +
                "Source" +
                "DeclaringType" +
                "MemberType");
        }

        public static void EjemploExcepcionesMultiples()
        {
            CCaldera caldera = new CCaldera("Matico", 20);
            try
            {
                caldera.TrabajarConMultiplesExcepciones(-10);
            }
            catch(CCalderaExcepcion ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;               
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Este es el código común en finally");
            }
        }

        public static void EjemploExcepcionesPropias()
        {
            CCaldera caldera = new CCaldera("Matic", 20);
            Random random = new Random();
            while (caldera.Funciona)
            {
                try
                {
                    caldera.TrabajarConExcepcionesPropias(random.Next(10));
                }
                catch(CCalderaExcepcion ex)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.Causa);
                    Console.WriteLine(ex.Momento);
                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El mensaje: {0}",e.Message);
                }
            }
        }

        public static void EjemploInformacionEnExcepcionV4()
        {
            CCaldera caldera = new CCaldera("Dell", 5);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    caldera.TrabajarInformacionExcepcionV4(20);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSucedio la excepcion");
        
                Console.WriteLine("Muestra el mensaje de error definido:{0}", e.Message);
                Console.WriteLine("Nombre del método de la excepción:{0}", e.TargetSite);
                Console.WriteLine("Cual es la aplicación principal de donde salio la excepción:{0}", e.Source);
                Console.WriteLine("Nombre de la clase donde ocurrio:{0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Tipo de miembro:{0}", e.TargetSite.MemberType);
                Console.WriteLine("Stack:{0}", e.StackTrace);
                Console.WriteLine("Help Link:{0}", e.HelpLink);

                Console.WriteLine("---Mostrando los datos propios--");
                if (e.Data != null)//Se verifica que existan datos
                {
                    //Se imprimen los datos extra propios
                    foreach(DictionaryEntry item in e.Data)
                    {
                        Console.WriteLine(">{0}->{1}",item.Key,item.Value);
                    }
                }
            }
        }

        public static void EjemploInformacionEnExcepcionV3()
        {
            CCaldera caldera = new CCaldera("Dell", 5);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    caldera.TrabajarInformacionExcepcionV3(20);
                }
            }
            catch (Exception e)
            {               
                Console.WriteLine("Help Link:{0}", e.HelpLink);
            }
        }

        public static void EjemploConUsoDeExcepcionesV2()
        {
            CCaldera caldera = new CCaldera("Dell", 5);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    caldera.TrabajarConExcepciones(20);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Suceio la excepción");
                Console.WriteLine("Muestra el mensaje de error definido:{0}",e.Message);
                Console.WriteLine("Nombre del método de la excepción:{0}", e.TargetSite);
                Console.WriteLine("Cual es la aplicación principal de donde salio la excepción:{0}",e.Source);
                Console.WriteLine("Nombre de la clase donde ocurrio:{0}",e.TargetSite.DeclaringType);
                Console.WriteLine("Tipo de miembro:{0}",e.TargetSite.MemberType);
                Console.WriteLine("Stack:{0}",e.StackTrace);
            }
        }
        public static void EjemploSinUsoDeExcepcionesV1()
        {
            CCaldera caldera = new CCaldera("philips", 5);
            for (int i = 0; i < 10; i++)
            {
                caldera.TrabajarSinExcepciones(20);
            }
        }
    }
}
