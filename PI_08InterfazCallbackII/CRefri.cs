using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_08InterfazCallbackII
{
    class CRefri
    {  // Aqui se guardan los sinks con los que se comunicara refri
        private ArrayList listaSinks = new ArrayList();
        private int kilos = 0;
        private int grados = 0;
        public CRefri(int pKilos, int pGrados)
        {
            kilos = pKilos;
            grados = pGrados;
        }

        public int Kilos { get => kilos; }
        public int Grados { get => grados; }

        //Recibe una clase que este implementando a la interfaz IEventoRefri
        public void AgregarSink(IEventoRefri pSink)
        {
            if (pSink != null)
            {
                listaSinks.Add(pSink);
            }
        }

        public void EliminarSink(IEventoRefri pSink)
        {
            if (listaSinks.Contains(pSink))
            {
                listaSinks.Remove(pSink);
            }
        }

        public void Trabajar(int pKilosConsumidos)
        {
            //Se actualizan los kilos del refri
            kilos -= pKilosConsumidos;
            //Se incrementa la temperatura
            grados++;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilos, grados);

            //Condicion para invocar los handlers del evento
            if (kilos < 10)
            {
                //Invoca los handlers de cada sink
                foreach (IEventoRefri handlers in listaSinks)
                {
                    handlers.EventReservasBajas(kilos);
                }
            }

            if (grados >= 0)
            {
                foreach(IEventoRefri handlers in listaSinks)
                {
                    handlers.EventDescongelado(grados);
                }
            }
        }
    }
}
