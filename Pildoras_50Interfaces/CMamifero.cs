using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_50Interfaces
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

        public virtual void Pensar()
        {
            Console.WriteLine("Tengo un pensamiento basico instintivo");
        }
        public void CuidarCrias()
        {
            Console.WriteLine("Puedo cuidar a mis crias");
        }
    }
}
