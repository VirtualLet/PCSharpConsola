using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_67DelegadosPredicadoLambdasI
{
    class CMensajeBienvenida
    {
        string nombre;
        public CMensajeBienvenida(string pNombre)
        {
            nombre = pNombre;
        }
        public void SaludoPersonalizado(string pMensaje)
        {
            Console.WriteLine("Mensaje:{0}",pMensaje);
        }
        public void SaludoSinSerStatic()
        {
            Console.WriteLine("Monstando saludooooootes :)");
        }
        public static void SaludoBienvenida()
        {
            Console.WriteLine("Hola Buen dia");
        }

        public string MonstrandoNombre()
        {
            return nombre;
        }

    }
}
