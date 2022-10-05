using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_28ManejoDeInterfacesConMetodos
{
    class CTelevisor:IElectronico
    {
        string marca;
        public CTelevisor(string pMarca)
        {
            marca = pMarca;
        }
        public void Encender(bool pInterruptor)
        { 
            if (pInterruptor) 
                Console.WriteLine("Encendido");
            else 
                Console.WriteLine("Apagado");
        }
        public override string ToString()
        {
            return string.Format("La marca de televisor es {0}", marca);
        }
    }
}
