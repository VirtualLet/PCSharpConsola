using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pildoras_53ClaseAbstracta
{
    class CCaballo:CMamifero,IMamiferosTerrestres,IAnimalesYDeportes,ISaltoConPatas
    {
        public CCaballo(string pNombre) : base(pNombre)
        {
        }

        public void Galopar()
        {
            Console.WriteLine("Puedo galopar");
        }

        public int IdentificadorTerrestre()
        {
            return 3554;
        }
        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }
        public string TipoDeporte()
        {
            return "Hípica";
        }

        public Boolean EsOlimpico()
        {
            return true;
        }




    }
}
