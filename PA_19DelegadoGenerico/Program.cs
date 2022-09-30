using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_19DelegadoGenerico
{
    class Program
    {
        //Creamos el delegado generico
        delegate void delGenerico<T>(T parametroG);
        static void Main(string[] args)
        {
            delGenerico<string> delInformativo = new delGenerico<string>(Mensaje);
            delInformativo("Mostando mensaje enviado des de le delegado generico");

            delInformativo = new delGenerico<string>(Alerta);
            delInformativo("Favor de revisar su buzon");

            delGenerico<int> delPontencia = new delGenerico<int>(MuestraPotenciaNumero);
            delPontencia(5);
            Console.ReadLine();
        }


        //Handler para el caso string
        public static void Mensaje(string pMensaje)
        {
            Console.WriteLine(pMensaje);
        }

        public static void Alerta(string pAlerta)
        {
            Console.WriteLine("Muesta alerta!!{0}",pAlerta);
        }

        //Handler para el caso int
        public static void MuestraPotenciaNumero(int pNumero)
        {
            Console.WriteLine("la potencia de {0} es:{1}", pNumero, pNumero * pNumero);
        }
    }
}
