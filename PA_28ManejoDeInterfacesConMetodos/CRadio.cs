using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_28ManejoDeInterfacesConMetodos
{
    class CRadio:IElectronico
    {
        string marca;
        public CRadio(string pMarca)
        {
            marca = pMarca;
        }

        public void Encender(bool esInterruptor)
        {
            if(esInterruptor)
                Console.WriteLine("Encendido");
            else
                Console.WriteLine("Apagado");
        }

        public override string ToString()
        {
            return string.Format("La marca del radio es {0}", marca);
        }

    }
}
