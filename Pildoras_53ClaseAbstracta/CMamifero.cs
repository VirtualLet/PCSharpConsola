using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_53ClaseAbstracta
{
    class CMamifero:CAnimales
    {
        private string nombre;
        public CMamifero(String pNombre)
        {
            nombre = pNombre;
        }

        public override void GetNombre()
        {
            Console.WriteLine("El nombre del mamifero es: {0}", nombre);
        }
        //public void Respirar()
        //{
        //    Console.WriteLine("Puedo respirar");
        //}

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
