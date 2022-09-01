using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_16Agregacion
{
    class CPropietario
    {
        private string nombre;
        private CEdificio cEdificioPropiedad=null;

        public CPropietario(string pNombre)
        {
            nombre = pNombre;
        }
        public void MostrarPropiedad()
        {
            if (cEdificioPropiedad!= null)
            {
                Console.WriteLine("{0} tiene:",nombre);
                cEdificioPropiedad.Muestra();
            }
            else Console.WriteLine("{0} aún no tiene propiedades",nombre);
            
        }

     
        public void AdicionarPropiedad( CEdificio pEdificio)
        {
            if (pEdificio != null)
            {
                cEdificioPropiedad = pEdificio;
            }
        }
    }
}
