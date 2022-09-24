using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_09DelegadosI
{
    class Program
    {
        //Definimos el delegado con las caracteristicas que nos interesa
        delegate void  delMuestraString(string pMensaje);
        static void Main(string[] args)
        {
            Console.WriteLine("Viendo delegados");

            //Creamos un objeto del delegado y lo referenciamos a un método
            delMuestraString delMuestra =new delMuestraString(CPastel.MuestraPastel);

            //Por medio del delegado hacemos uso del método
            delMuestra("Estamos probando pasteles");

            //Hacemos que apunte a otro método
            delMuestra = new delMuestraString(CRadio.MuestraRadio);

            //Ahora invocamos el otro método
            delMuestra("Estamos probando mensjaes de radio");
            Console.ReadLine();
        }
    }
}
