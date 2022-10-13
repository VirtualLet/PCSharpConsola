using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_27ObjetoImplementaInterfazAsIs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cómo reconocer si un objeto implementa a determinada interfaz");
            //Metodo 1, por excepcion
            MetodoPorExcepcion();
            //Método 2 por as (puede ser tratado como)
            MetodoPorAs();
            //Metodo 3 por is ( p es compatible con
            MetodoIs();          
            Console.ReadLine();
        }


        public static void MetodoIs()
        {
            CTelevisor televisor = new CTelevisor("Sony");
            CPelota pelota = new CPelota("Grande");

            //Metodo 3 por is ( p es compatible con
            Console.WriteLine("Probando con Televisión");
            if (televisor is IElectronico)
                televisor.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probando con Pelota");
            if(pelota is IElectronico)
                Console.WriteLine("ES una pelota electronica");
            else
                Console.WriteLine("No Implementa IElectronico");

            Console.WriteLine("-----");
        }

        public static void MetodoPorAs()
        {
            CTelevisor televisor = new CTelevisor("Sony");
            CPelota pelota = new CPelota("Grande");
            IElectronico objIElectronico = null;

            //Método 2 por as (puede ser tratado como)
            Console.WriteLine("Probando televisión");
            objIElectronico = televisor as IElectronico;
            if (objIElectronico != null)
                objIElectronico.Encender(true);
            else
                Console.WriteLine("No implementa a IElectronico");

            Console.WriteLine("Probando Pelota");
            objIElectronico = pelota as IElectronico;
            if (objIElectronico != null)
                objIElectronico.Encender(true);
            else
                Console.WriteLine("No implementa a IElectronico");

            Console.WriteLine("-----");
        }


        public static void MetodoPorExcepcion()
        {
            Console.WriteLine("Cómo reconocer si un objeto implementa a determinada interfaz");
            CTelevisor televisor = new CTelevisor("Sony");
            CPelota pelota = new CPelota("Grande");
            IElectronico objIElectronico = null;
            try
            {
                Console.WriteLine("Probando television");
                objIElectronico = (IElectronico)televisor;
                objIElectronico.Encender(true);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Probando Pelota");
                objIElectronico = (IElectronico)pelota;
                objIElectronico.Encender(true);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("-----");
        }



    }
}
