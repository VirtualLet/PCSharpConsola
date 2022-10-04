using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_12IndexerModificado
{
    class CTiendaAuto
    {
        private List<CAuto> autosDisponibles;
        public CTiendaAuto()
        {
             autosDisponibles = new List<CAuto>() {
                new CAuto("BMV", 100),
                new CAuto("CADILAC", 500),
                new CAuto("TESLA", 300)
                };
        }

        public void AgregarItems(CAuto auto)
        {
            autosDisponibles.Add( auto);
        }
        //Se crea el indexer
        public CAuto this[int indice]
        {
            //usamos un get para obetner el elemento en ese indice
            get { return autosDisponibles[indice]; }
            //usamos set para colocar un elemento en ese indice
            set => autosDisponibles[indice] = value;
        }

        public int TotalRegistro
        {
            get => autosDisponibles.Count;
        }

        public IEnumerator GetEnumerator()
        {
            return autosDisponibles.GetEnumerator();
        }

    }
}
