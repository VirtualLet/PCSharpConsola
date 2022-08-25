using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_02IEnumerable
{
    class CTiendaAuto
    {
        private CAuto[] autosDisponibles;

        public CTiendaAuto()
        {
            autosDisponibles = new CAuto[4];
            autosDisponibles[0] = new CAuto("Soul", 50000);
            autosDisponibles[1] = new CAuto("Fit", 40000); 
            autosDisponibles[2] = new CAuto("March", 550000);
            autosDisponibles[3] = new CAuto("Spark", 566000);
        }

        public IEnumerator GetEnumerator()
        {
            //Regresa la estructura para que el foreach la pueda recorrer, esta debe de implementar IEnumerator
            return autosDisponibles.GetEnumerator();
        }

    }
}
