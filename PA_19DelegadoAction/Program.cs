using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_19ActionyFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            UsoDeAction(); //para delegados que no tienen valor de retorno
            Console.WriteLine("--EJEM FUNC--");
            UsoDeFunc(); //Para delegados con un tipo de valor de retorno

            Console.ReadLine();
        }

        #region ACTION
        public static void UsoDeAction()
        {
            string info = string.Format("Action permite crear delegados en el momento" +
               "para un maximo de 16 parametros" +
               "y su tipo de retorno siempre será void");
            int numero = 5;
            string mensaje = "hola a todos";

            //Se usa action para registrar el handler con el delegado
            Action<string, int> delAction = new Action<string, int>(RepiteMensaje);

            //Se invoca al delegado
            delAction(mensaje, numero);

            Console.WriteLine("----");

            Action<bool> delInterruptor = new Action<bool>(pInterruptor =>
            {
                if (pInterruptor) Console.WriteLine("Encendido");
                else Console.WriteLine("Apagado");
            });

            bool interruptor = true;
            delInterruptor(interruptor);

        }
        //Método de handler para Action
        public static void RepiteMensaje(string pMensaje, int pRepeticiones)
        {
            for ( int i=0; i<pRepeticiones; i++)
            {
                Console.WriteLine("[{0}]={1}",i+1,pMensaje);
            }
        }
        #endregion

        #region FUNC
        public static void UsoDeFunc()
        {
            string info = string.Format("Fuc funciona similar a Action, pero permite tipo de retorno");
            int x = 5;
            int y = 6;
            //Definición del delegado, el último tipo listado es siempre el tipo de retorno
            Func<int, int, int> delFunc = new Func<int, int, int>(Suma);
            //Invocamos el método
            Console.WriteLine("{0}+{1}={2}", x, y, delFunc(x, y));
        }
        //Metodo de handler para func
        public static int Suma(int valorA, int valorB)
        {
            return valorA + valorB;
        }
        #endregion
    }
}
