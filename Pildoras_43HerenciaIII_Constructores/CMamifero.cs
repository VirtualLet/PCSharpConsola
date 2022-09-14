using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_43HerenciaIII_Constructores
{
    class CMamifero
    {
        private string nombre;
        public CMamifero(String pNombre)
        {
            nombre = pNombre;
        }

        public void GetNombre()
        {
            Console.WriteLine("Su nombre es: {0}", nombre);
        }
        public void Respirar()
        {
            Console.WriteLine("Puedo respirar");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Puedo cuidar a mis crias");
        }
    }
}
