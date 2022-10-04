using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_12Indexer
{
    class CTiendaAutos
    {
        private CAuto[] autosDisponibles;
       
        public CTiendaAutos()
        {
            autosDisponibles = new CAuto[]
            {
                new CAuto("bmv",100),
                new CAuto("cadilac",500),
                new CAuto("tesla",300)
            };
        }

        //Se crea el indexer
        public CAuto this[int indice]
        {
            //usamos un get para obetner el elemento en ese indice
            get { return autosDisponibles[indice]; }
            //usamos set para colocar un elemento en ese indice
            set => autosDisponibles[indice] = value;
        }

        public int TotalRegistros
        {
            get=> autosDisponibles.Length;
        }

        //Haciendo uso de la interface IEnumerable que tiene un método GetEnumerator que
        //regresa un objeto que implementa a la interface IEnumarator para
        //poder hacer uso del iterador foreach en arrays
        public IEnumerator GetEnumerator()
        {
            return autosDisponibles.GetEnumerator();
        }

    }
}
